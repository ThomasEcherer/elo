package de.elo.ix.examples.serverevents;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import de.elo.ix.client.IXServerEventsC;
import de.elo.ix.client.serverevents.IXServerEventsHandler;
import de.elo.ix.strm.IxDataStreamServer;

/**
 * Servlet implementation class ServerEventsServlet
 */
public class ServerEventsServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	String appName = "EloixExampleServerEvents";
	String appVersion = "1.0";
	
	protected IXServerEventsHandler eventHandler = new MyServerEventsHandler(appName, appVersion);
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ServerEventsServlet() {
        super();
    }

	@Override
   protected void service( HttpServletRequest httpServletRequest, HttpServletResponse httpServletResponse ) throws ServletException, IOException {

     // IndexServer sends POST requests the servlet.
     // To negotiate the protocol version, the request URL contains the 
     // paramter cmd=negotiate.
     
     // IX submits its stream version in the HTTP header IXDATASTREAM
     String ixStreamVersion = httpServletRequest.getHeader("IXDATASTREAM");

     if (ixStreamVersion != null) {

       // Create the helper object for:
       // - reading event methods and parameters from the HTTP input stream
       // - executing the methods on the target eventHandler, which is a IXServerEvents implementation
       // - writing method results to the HTTP output stream
       IxDataStreamServer strmServer = new IxDataStreamServer(eventHandler, 
           IXServerEventsC.STREAM_VERSION, 
           de.elo.ix.client.IxDataStreamRegistry.getRegistry(),
           null);

       // Negotiate stream verion: return the lowest version
       String negotiatedStreamVersion = strmServer.negotiate( ixStreamVersion );
       
       // Just negotiate?
       String cmd = httpServletRequest.getParameter( "cmd" );
       if (cmd != null && cmd.equals( "negotiate" )) {
         // The negotiated stream version is returned below.
       }
       else {
         // Process the request.
         strmServer.processRequest( negotiatedStreamVersion, null,
             httpServletRequest.getInputStream(), 
             httpServletResponse.getOutputStream(), 
             null);
       }

       // Return the negotiated stream version. 
       httpServletResponse.setHeader("IXDATASTREAM", negotiatedStreamVersion);
       
     }
     else {
       
       // Write application name and application version as plain text.
       PrintWriter pr = new PrintWriter(httpServletResponse.getOutputStream());
       httpServletResponse.setContentType( "text/plain" );
       pr.println(appName + " " + appVersion);
       pr.close();
       
     }
	}

 }
