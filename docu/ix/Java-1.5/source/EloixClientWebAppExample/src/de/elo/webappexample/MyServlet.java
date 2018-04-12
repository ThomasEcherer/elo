package de.elo.webappexample;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Properties;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import de.elo.ix.client.IXConnection;
import de.elo.ix.client.webapp.AppConfig;
import de.elo.ix.client.webapp.AppPropertyNames;
import de.elo.ix.client.webapp.Application;
import de.elo.ix.client.webapp.servlet.IXClientServletUniqueConnection;
import de.elo.utils.PropertiesEx;
import byps.RemoteException;
import de.elo.utils.webapp.status.StatusData;
import de.elo.utils.webapp.status.StatusPageHandler;

/**
 * This class demonstrates how to use the IXClientServletUniqueConnection class.
 * 
 * The web.xml should contain a <load-on-startup> tag for this Servlet. This 
 * ensurces, that the IXConnection is initialized, when the applications starts.
 */
public class MyServlet extends IXClientServletUniqueConnection {

  private static final long serialVersionUID = 1L;
  private static Logger log = LoggerFactory.getLogger( MyServlet.class );
  
  /**
   * Program name, required to initialize IXClientServlet
   */
  private final static String PROGRAM_NAME = "MyApplication";
  
  /**
   * Program version, required to initialize IXClientServlet
   */
  private final static String PROGRAM_VERSION = "1.2.3";

  /**
   * Default constructor. 
   */
  public MyServlet() {
    
    // IXClientServlet must be initialized before getApplication() can be called. 
    super.initApplication(PROGRAM_NAME, PROGRAM_VERSION, "");
    
    // Set the property names used in web.xml (or config.xml) to define the IndexServer connection.
    // See class documentation of AppPropertyNames for default values. 
    AppPropertyNames propNames = super.getApplication().getAppConfig().getAppPropertyNames();
    propNames.setIxUrl( "IndexServer.URL" );  
    propNames.setIxUser( "IndexServer.UserName" );
    propNames.setIxPwd( "IndexServer.UserPwd" );
      
  }
       
  /**
   * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
   */
  protected void doGet( HttpServletRequest request, HttpServletResponse response ) throws ServletException, IOException {
    PrintWriter pr = response.getWriter();
    
    // This code shows how to use the Application and AppConfig interfaces. 
    // This is not the status page. The status page is printed in IXClientServletUniqueConnection.service.
    
    pr.print( "<html>" );
    pr.print( "<body>" );

    ////////////////////////////////////////////////////////////////////////////
    // Link to the status page supplied by IXClientServletUniqueConnection.service
    
    pr.print( "<h1><a href=\"MyServlet?" + StatusPageHandler.URL_COMMAND_STATUS + "\">Show Status</a></h1>" );

      
    ////////////////////////////////////////////////////////////////////////////
    // Show configuration properties in a table.
    // Passwords have already been decrypted (AppConfig.encrypt can be used to encrypt/decrypt passwords)  
    
    Application app = getApplication();
    AppConfig appConfig = app.getAppConfig();
    Properties configProps = appConfig.getProperties();

    pr.println( "<table border=\"2\">" );
    pr.print( "<tr><td colspan=\"2\"><h2>Configuration options from web.xml and config.xml</h2></td></tr>" );
    for (Object k : configProps.keySet()) {
      String v = configProps.getProperty( ( String )k );
      pr.print( "<tr><td>" );
      pr.print( k );
      pr.print( "</td><td>" );
      pr.print( v );
      pr.println( "</td></tr>" );
    }
    pr.println( "</table>" );

    ////////////////////////////////////////////////////////////////////////////
    // Show user profile options

    IXConnection ix = getConnection();
    PropertiesEx userProfile = appConfig.readUserProfile( ix, PROGRAM_NAME + "*" );
    pr.println( "<table border=\"2\">" );
    pr.print( "<tr><td colspan=\"2\"><h2>User profile options</h2></td></tr>" );
    for (Object k : userProfile.keySet()) {
      String v = userProfile.getProperty( ( String )k );
      pr.print( "<tr><td>" );
      pr.print( k );
      pr.print( "</td><td>" );
      pr.print( v );
      pr.println( "</td></tr>" );
    }
    pr.println( "</table>" );

    pr.println( "</body>" );
    pr.println( "</html>" );

    // This lines demonstrate how to read and write a profile option. 
    String counterName = PROGRAM_NAME + ".counter";
    int counter = userProfile.getProperty( counterName, 0 ) + 1;
    appConfig.writeUserProfileValue( ix, counterName, Integer.toString( counter ) );
  }

  @Override
  public void destroyBeforeDisconnect() {
  }

  @Override
  public void initAfterConnect() {
    try {
      IXConnection ix = getConnection();
      Application app = getApplication();
      AppConfig appConfig = app.getAppConfig();

      // read user profile options
      Properties userProfile = appConfig.readUserProfile( ix, PROGRAM_NAME + "*" );
      log.info( "userProfile=" + userProfile);

      
      // initialize other application specific objects
      // ...
      
      
      // finally set state to RUNNING
      getApplication().getStatusData().setState(StatusData.State.RUNNING);
    }
    catch (RemoteException e) {

      // Initialization error, set status to STOPPED
      getApplication().getStatusData().setState(StatusData.State.STOPPED);
      // Add a fatal error to the list of errors in the StatusData object
      getApplication().getStatusData().getFatals().add( "Initialization failed", e );
      
      // log error... 
      
    }
  }

  @Override
  public StatusData StatusPageHandler_updateStatusData( boolean isAuth ) throws IOException {

    StatusData statusData = getApplication().getStatusData();
    StatusData.Properties props = statusData.getProperties();
    props.clear();
    
    props.addVersion(true).addEmptyLine();
    
    IXConnection ix = getConnection();
  
    // some connection informations 
    props.addHeader( "IndexServer" )
         .add( "Version", ix.getImplVersion())
         .add( "Stream version", ix.getStreamVersion())
         .add( "User", ix.getUserName() )
         .add( "Ticket", ix.getLoginResult().getClientInfo().getTicket() );

    
    // Logger level
    props.addHeader( "Logging" ).addLogLevel( "", "MyServlet?" );

    // Memory and server time
    props.addHeader( "Details" ).addMemory().addServerTime();
    
    return statusData;
  }

}
