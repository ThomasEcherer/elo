package de.elo.ix.examples.serverevents;

import byps.RemoteException;
import de.elo.ix.client.Activity;
import de.elo.ix.client.Any;
import de.elo.ix.client.CheckAccessOptions;
import de.elo.ix.client.CheckinUsersZ;
import de.elo.ix.client.CheckoutUsersZ;
import de.elo.ix.client.DeleteOptions;
import de.elo.ix.client.DocVersion;
import de.elo.ix.client.Document;
import de.elo.ix.client.EditInfo;
import de.elo.ix.client.EditInfoZ;
import de.elo.ix.client.FindInfo;
import de.elo.ix.client.FindInfoAsInternalSQL;
import de.elo.ix.client.FindResult;
import de.elo.ix.client.HttpRequestInfo;
import de.elo.ix.client.HttpResponseInfo;
import de.elo.ix.client.IXConnection;
import de.elo.ix.client.IXServerEventsContext;
import de.elo.ix.client.InheritKeywordingResult;
import de.elo.ix.client.KeyValue;
import de.elo.ix.client.LockZ;
import de.elo.ix.client.LoginScriptOptions;
import de.elo.ix.client.Note;
import de.elo.ix.client.Reminder;
import de.elo.ix.client.Sord;
import de.elo.ix.client.SordC;
import de.elo.ix.client.SordZ;
import de.elo.ix.client.UserInfo;
import de.elo.ix.client.UserName;
import de.elo.ix.client.WFDiagram;
import de.elo.ix.client.WFNode;
import de.elo.ix.client.serverevents.IXServerEventsHandler;

public class MyServerEventsHandler extends IXServerEventsHandler {
  
  public MyServerEventsHandler(String appName, String appVersion) {
    super(appName, appVersion);
    implementedMethods.add( "onAfterCheckinSord" ); 
  }

  public void onAfterCheckinDocEnd( IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, Document doc,
      SordZ sordZ, LockZ unlockZ ) throws RemoteException {
  }

  public void onAfterCheckinSord( IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, SordZ sordZ,
      LockZ unlockZ ) throws RemoteException {
    
    if (sordDB == null && sord.getType() >= SordC.LBT_DOCUMENT) {
      IXConnection conn = connMap.getConn( ec );
      conn.ix().startWorkFlow( "myworkflow", sord.getName() + "-workflow", sord.getGuid() );
    }
  }

  public void onAfterDeleteSord( IXServerEventsContext ec, Sord parentSord, Sord sord, LockZ unlockZ,
      DeleteOptions delOpts, boolean ret ) throws RemoteException {
  }

  public void onAfterRefSord( IXServerEventsContext ec, Sord parentSordOld, Sord parentSordNew, Sord sord,
      int manSortIndex ) throws RemoteException {
  }

  public void onBeforeCheckinDocEnd( IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, Document doc,
      SordZ sordZ, LockZ unlockZ ) throws RemoteException {
  }

  public void onBeforeCheckinSord( IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, SordZ sordZ,
      LockZ unlockZ ) throws RemoteException {
    sord.setDesc( sord.getDesc() + "onBeforeCheckinSord was called" );
  }

  public void onBeforeDeleteSord( IXServerEventsContext ec, Sord parentSord, Sord sord, LockZ unlockZ,
      DeleteOptions delOpts ) throws RemoteException {
  }

  public void onBeforeRefSord( IXServerEventsContext ec, Sord parentSordOld, Sord parentSordNew, Sord sord,
      int manSortIndex ) throws RemoteException {
  }
  
  public void onAfterCheckinReminder( IXServerEventsContext ec, Reminder[] remis, Sord sord, SordZ sordZ, LockZ lockZ )
      throws RemoteException {
  }

  public void onAfterEndEditWorkFlowNode( IXServerEventsContext ec, WFDiagram workflow, int nodeId, Sord sord,
      SordZ sordZ ) throws RemoteException {
  }
  
  public void onAfterStartWorkFlow( IXServerEventsContext ec, WFDiagram workflow, Sord sord, SordZ sordZ ) 
      throws RemoteException {
  }
  
  public Any executeRegisteredFunction( IXServerEventsContext ec, String functionName, Any args )
      throws RemoteException {
    return null;
  }

	public void onBeforeCheckinActivity(IXServerEventsContext ec, Activity act,
			boolean isNew, Sord sord, SordZ sordZ, LockZ unlockZ)
			throws RemoteException {
	}

	public void onAfterCheckinActivity(IXServerEventsContext ec, Activity act,
			boolean isNew, Sord sord, SordZ sordZ, LockZ unlockZ)
			throws RemoteException {
	}

	public void onFileUploadBuildResponse(IXServerEventsContext ec,
			DocVersion dv, String filePath, HttpRequestInfo httpServletRequest,
			HttpResponseInfo httpServletResponse) throws RemoteException {
	}

	public UserName[] getUserNames(IXServerEventsContext ec, String[] ids,
			CheckoutUsersZ checkoutUsersZ) throws RemoteException {
		return null;
	}

  public void onReadSord(IXServerEventsContext ec, Sord sord, SordZ sordZ,
      Document doc, LockZ lockZ) throws RemoteException {
  }

  public boolean onCheckSordAccess(IXServerEventsContext ec, Sord sord,
      SordZ sordZ, int lur, CheckAccessOptions opts) throws RemoteException {
    return true;
  }

  public void onBeforeLogin(IXServerEventsContext ec, String userName,
      LoginScriptOptions opts) throws RemoteException {
  }

  @Override
  public EditInfo onCreateSord(IXServerEventsContext ec, String parentId, String maskId, EditInfoZ editZ) throws RemoteException {
    return null;
  }

  @Override
  public EditInfo onCreateDoc(IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EditInfoZ editInfoZ) throws RemoteException {
    return null;
  }

  @Override
  public UserInfo[] onBeforeCheckinUsers(IXServerEventsContext ec, UserInfo[] userInfos, CheckinUsersZ checkinUsersZ, LockZ lockZ) throws RemoteException {
    return null;
  }

  @Override
  public void onAfterCheckinUsers(IXServerEventsContext ec, UserInfo[] userInfos, CheckinUsersZ checkinUsersZ, LockZ lockZ) throws RemoteException {
  }

	@Override
	public void onBeforeCheckinNotes(IXServerEventsContext ec, Note[] notes, Sord[] sords, long noteC, LockZ unlockZ) 
			throws RemoteException {
	}
	
	@Override
	public void onAfterCheckinNotes(IXServerEventsContext ec, Note[] notes, Sord[] sords, long noteC, LockZ unlockZ) 
			throws RemoteException {
	}

  @Override
  public KeyValue[] onBeforeCheckinMap(IXServerEventsContext ec, String domainName, String id, int objId, KeyValue[] data, LockZ unlockZ)
      throws RemoteException {
    return null;
  }

  @Override
  public void onAfterCheckinMap(IXServerEventsContext ec, String domainName, String id, int objId, KeyValue[] data, LockZ unlockZ)
      throws RemoteException {
  }

  @Override
  public String[] onBeforeDeleteMap(IXServerEventsContext ec, String domainName, String id, String[] keyNames, LockZ unlockZ) throws RemoteException {
    return null;
  }

  @Override
  public void onAfterDeleteMap(IXServerEventsContext ec, String domainName, String id, String[] keyNames, LockZ unlockZ) throws RemoteException {
  }

  @Override
  public String executeRegisteredFunctionString(IXServerEventsContext ec, String functionName, String args) throws RemoteException {
    return null;
  }

  @Override
  public void onBeforeTakeWorkFlowNode(IXServerEventsContext ec, WFDiagram workflow, WFNode node, UserInfo user, int flags, LockZ lockZ)
      throws RemoteException {
    
  }

  @Override
  public void onFindSordsResult(IXServerEventsContext ec, FindInfo findInfo, SordZ sordZ, FindResult fr) throws RemoteException {
    
  }

  @Override
  public void onFindClose(IXServerEventsContext ec, Object findInfo) throws RemoteException {
    
  }

  @Override
  public void onBeforeFindSords(IXServerEventsContext ec, FindInfo findInfo, SordZ sordZ) throws RemoteException {
  }

  @Override
  public void onBeforeFindSordsInternalSQL(IXServerEventsContext ec, FindInfo findInfo, SordZ sordZ, FindInfoAsInternalSQL findSql) throws RemoteException {
  }

  @Override
  public InheritKeywordingResult onInheritKeywording(IXServerEventsContext ec, Sord sord, Sord parentSord, String[] okeyNames, Object reserved)
      throws RemoteException {
    return InheritKeywordingResult.APPLY_DEFAULT;
  }

  @Override
  public void onBeforeStartWorkFlow(IXServerEventsContext ec, WFDiagram workflow, Sord sord, SordZ sordZ) throws RemoteException {
  }

  @Override
  public void onAfterLogin(IXServerEventsContext ec, String userName, LoginScriptOptions opts) throws RemoteException {
  }
}
