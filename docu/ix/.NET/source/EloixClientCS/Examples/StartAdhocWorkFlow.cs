using System;
using System.IO;
using EloixClient.IndexServer;


namespace Examples
{
    /// <summary>
    /// This example shows how to start an Ad Hoc Workflow.
    /// 1. Uploads example workflow scripts
    /// 2. Create 3 users: WFUser1, WFUser2, WFUser3
    /// 3. Create a document
    /// 4. Start Ad Hoc Workflow
    /// 5. Forward all nodes
    /// 6. Clean up
    /// </summary>
    public class StartAdhocWorkFlow
    {
        // URL to IndexServer
        public String url;

        // [X] Account to authenticate 
        public String userName = "Administrator";
        public String userPwd = "";

        // [X] Finished script name
        public String finishedScript = "WorkFlowScriptExample.js";

        // The Finished Script includes some helper scripts. This member contains
        // all scripts to upload to the server
        public String[] workflowScripts;

        // This is the server directory where the scripts are stored 
        public String myServerScriptDir = "eloscripts";

        IXConnFactory connFact = null;

        public void run()
        {
            IXConnection ix = null;
            String[] userIds = null;
            String objId = null;
            int flowId = -1;
            String[] userNames = new String[] { "WFUser1", "WFUser2", "WFUser3" };

            workflowScripts = new String[] {finishedScript, 
			                								"DumpWorkFlow.js", 
                                      "DumpSord.js", 
											                "Dump.js"};

            try
            {
                IXProperties connProps = IXConnFactory.CreateConnProperties(url);
                IXProperties sessOpts = IXConnFactory.CreateSessionOptions("IX-Examples", "1.0");
                connFact = new IXConnFactory(connProps, sessOpts);
                Logger.instance().log("create IXConnFactory OK");

                // Prepare ClientInfo object with language and country
                // ClientInfo ci = new ClientInfo();
                // ci.language = "de";
                // ci.country = "DE";

                // LOGIN
                Logger.instance().log("login...");
                ix = connFact.Create(userName, userPwd, "myComputer", null);
                // ci = ix.Login.ci
                Logger.instance().log("login OK");

                // get constants
                Logger.instance().log("get const...");
                IXServicePortC CONST = ix.CONST;
                Logger.instance().log("get const OK");

                //////////////////////////////////////////////////////////////
                // 1. Upload example scripts 
                internalCheckinScripts(ix, CONST, workflowScripts);

                //////////////////////////////////////////////////////////////
                // 2. Create 3 users: WFUser1, WFUser2, WFUser3

                Logger.instance().log("create users...");
                userIds = internalCreateSomeUsers(ix, CONST, userNames);
                Logger.instance().log("create users OK");

                //////////////////////////////////////////////////////////////
                // 3. Create a document

                Logger.instance().log("create document...");
                objId = internalCreateDocument(ix, CONST);
                Logger.instance().log("create document OK, objId=" + objId);

                //////////////////////////////////////////////////////////////
                // 4. Start Ad Hoc Workflow

                Logger.instance().log("start workflow...");
                flowId = ix.Ix.startAdHocWorkFlow("C# Example AdHocWorkflow " + DateTime.Now,
                    objId, userIds, "C# example Ad Hoc Workflow", false, true,
                    "0", "canceled", "0", "Everyone has seen the document.",
                    myServerScriptDir + "\\" + finishedScript
                    );
                Logger.instance().log("start workflow OK, flowId=" + flowId);

                // dump nodes, verify that userNames[0] got an active node
                int testUserId = ix.LoginResult.user.id;
                dumpWFNodes(ix, CONST, flowId, testUserId, userIds);

                //////////////////////////////////////////////////////////////
                // 5. Forward all nodes

                for (int i = 0; i < userIds.Length; i++)
                {
                    internalForwardNode(ix, CONST, flowId, userNames[i], "elo");
                    dumpWFNodes(ix, CONST, flowId, testUserId, userIds);
                }

                // At this point the test user got the finished node
                internalForwardNode(ix, CONST, flowId, userName, userPwd);
                dumpWFNodes(ix, CONST, flowId, testUserId, userIds);

                // Check the sord description: the script should have stored some text in it.
                Sord sord = ix.Ix.checkoutSord(objId, EditInfoC.mbSord, LockC.NO).sord;
                Logger.instance().log("sord.desc=" + sord.desc);

                //////////////////////////////////////////////////////////////
                // 6. Clean up

                // delete document
                bool isDeleteDocument = true;
                if (isDeleteDocument)
                {
                    Logger.instance().log("delete document...");
                    ix.Ix.deleteSord(null, objId, LockC.NO, null);
                    Logger.instance().log("delete document OK");
                }

                // delete users
                bool isDeleteUsers = false;
                if (isDeleteUsers)
                {
                    Logger.instance().log("delete users ...");
                    ix.Ix.deleteUsers(userIds, LockC.NO);
                    Logger.instance().log("delete users OK");
                }

                // delete scripts
                Logger.instance().log("delete scripts ...");
                internalDeleteScripts(ix, CONST, workflowScripts);
                Logger.instance().log("delete scripts OK");

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

                // Logout
                // --
                if (ix != null)
                {
                    Logger.instance().log("IX logout...");
                    ix.Logout();
                    Logger.instance().log("IX logout OK");
                }
            }
        }

        /// <summary>
        /// Create users with given names if they do not already exist.
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="CONST">IndexServer constants</param>
        /// <param name="ci">Client information (ticket)</param>
        /// <param name="userNames">Names of users to create</param>
        /// <returns>User IDs as String array</returns>
        private String[] internalCreateSomeUsers(IXConnection ix,
            IXServicePortC CONST, String[] userNames)
        {
            String[] uids = new String[userNames.Length];

            // Try to create users
            UserInfo[] users = new UserInfo[userNames.Length];
            try
            {
                for (int i = 0; i < userNames.Length; i++)
                {
                    users[i] = ix.Ix.createUser("0");
                    users[i].name = userNames[i];
                    users[i].pwd = "elo";
                }
                ix.Ix.checkinUsers(users, CheckinUsersC.WRITE_PASSWORD, LockC.NO);
            }
            catch (Exception e)
            {
                Logger.instance().log("exception=" + e);
                throw e;
            }

            // checkout users to get their IDs
            users = ix.Ix.checkoutUsers(userNames, CheckoutUsersC.BY_IDS, LockC.NO);
            for (int i = 0; i < users.Length; i++)
            {
                uids[i] = Convert.ToString(users[i].id);
                Logger.instance().log("uids[" + i + "]=" + uids[i]);
            }

            return uids;
        }

        /// <summary>
        /// Creates a Sord object. 
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="CONST">IndexServer constants</param>
        /// <param name="ci">Client information (ticket)</param>
        /// <returns>Sord GUID</returns>
        private String internalCreateDocument(IXConnection ix,
            IXServicePortC CONST)
        {
            Sord sord = ix.Ix.createSord("1", null, EditInfoC.mbSord).sord;
            sord.name = "C# Workflow example " + DateTime.Now;
            int objId = ix.Ix.checkinSord(sord, SordC.mbAll, LockC.NO);
            return Convert.ToString(objId);
        }

        /// <summary>
        /// Dumps the node information of the workflow to Logger object.
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="CONST">IndexServer constants</param>
        /// <param name="ci">Client information (ticket)</param>
        /// <param name="flowId">Workflow ID</param>
        /// <param name="testUserId">ID of user which started the test.</param>
        /// <param name="wfUserIds">IDs of users which receive the workflow.</param>
        private void dumpWFNodes(IXConnection ix,
            IXServicePortC CONST,
            int flowId, int testUserId, String[] wfUserIds)
        {
            // add current user to userIds
            String[] userIds = new String[wfUserIds.Length + 1];
            userIds[0] = Convert.ToString(testUserId);
            for (int i = 0; i < wfUserIds.Length; i++)
            {
                userIds[i + 1] = wfUserIds[i];
            }

            // collect nodes
            WFCollectNode[] nodes = ix.Ix.collectWorkFlowNodes("" + flowId,
        WFTypeC.ACTIVE, null, WFNodeC.TYPE_NOTHING, null,
                null, null, userIds, false, false);

            // dump
            Logger.instance().log("Workflow Nodes, #nodes=" + nodes.Length);
            for (int i = 0; i < nodes.Length; i++)
            {
                Logger.instance().log("  " +
                    (nodes[i].active ? "*" : " ") +
                    "nodes[" + i + "]: id=" + nodes[i].nodeId +
                      ", name=" + nodes[i].nodeName +
                      ", userId=" + nodes[i].userId +
                      ", inUseDate=" + nodes[i].inUseDateIso);
            }
        }

        /// <summary>
        /// Forwards a node of a user. Logs in as user and edit the node.
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="CONST">IndexServer constants</param>
        /// <param name="flowId">Workflow ID</param>
        /// <param name="userName">Name of user that forwards it's node.</param>
        /// <param name="userPwd">User password</param>
        private void internalForwardNode(IXConnection ix,
            IXServicePortC CONST, int flowId, String userName, String userPwd)
        {
            Logger.instance().log("internalForwardNode(user=" + userName);

            String okMessage = "OK from " + userName;

            // login user
            Logger.instance().log("  login...");
            ClientInfo ci2 = new ClientInfo();
            ci2.language = "de";
            ci2.country = "DE";
            ci2.callId = "WF" + userName; // for debug purposes
            IXConnection ixUser = connFact.Create(ci2, userName, userPwd, "mypc", null);
            Logger.instance().log("  login OK");

            // get active nodes (should be only one)
            Logger.instance().log("  Get active nodes...");
            FindTasksInfo fti = new FindTasksInfo();
            fti.inclWorkflows = true;
            FindResult findResult = ixUser.Ix.findFirstTasks(fti, 1000);
            WFCollectNode node = findResult.tasks[0].wfNode;

            int nodeId = node.nodeId;
            Logger.instance().log("  Forward node, nodeId=" + nodeId);

            // begin edit node -> real world: show dialog to forward 
            Logger.instance().log("    begin edit ...");
            WFEditNode en = ixUser.Ix.beginEditWorkFlowNode(flowId, nodeId, LockC.NO);
            Logger.instance().log("    begin edit OK");

            // select successor (only one for serial flow)
            int[] succNodeIds = new int[en.succNodes.Length];
            if (en.succNodes.Length > 0) succNodeIds[0] = en.succNodes[0].id;

            // end edit node -> real world: user clicks OK button
            Logger.instance().log("    end edit ...");
            ixUser.Ix.endEditWorkFlowNode(flowId, node.nodeId,
                      false,							// terminate
                      false,							// cancel
                      okMessage,						// name
                      "I don't mind " + userName,		// comment
                      succNodeIds						// nodes to forward to
                      );
            Logger.instance().log("    end edit OK");

            Logger.instance().log("  Forward node OK");

            // logout
            Logger.instance().log("  logout...");
            ixUser.Ix.logout();
            Logger.instance().log("  logout OK");

            Logger.instance().log(")internalForwardNode");
        }

        /// <summary>
        /// Checkin workflow scripts.
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="CONST">IndexServer constants</param>
        /// <param name="ci">Client information (ticket)</param>
        /// <param name="scriptNames">Array of script names</param>
        private void internalCheckinScripts(IXConnection ix,
            IXServicePortC CONST,
            String[] scriptNames)
        {
            Logger.instance().log("internalCheckinScripts(");

            ConfigFile[] currentScripts = ix.Ix.checkoutConfigFiles(
                new String[] { myServerScriptDir + "/*" }, ConfigFileC.mbNoFileData, LockC.NO);

            Logger.instance().log("read script files...");
            ConfigFile[] ixScripts = new ConfigFile[scriptNames.Length];
            for (int i = 0; i < ixScripts.Length; i++)
            {
                ixScripts[i] = new ConfigFile();
                ixScripts[i].name = scriptNames[i];
                ixScripts[i].dir = myServerScriptDir;

                String fileName = "..\\..\\" + ixScripts[i].name;
                FileStream fstrm = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                ixScripts[i].fileData = new FileData();
                ixScripts[i].fileData.data = new byte[(int)fstrm.Length];
                fstrm.Read(ixScripts[i].fileData.data, 0, (int)fstrm.Length);
                fstrm.Close();
            }
            Logger.instance().log("read script files OK");

            Logger.instance().log("checkin...");
            ix.Ix.checkinConfigFiles(ixScripts, LockC.NO);
            Logger.instance().log("checkin OK");

            currentScripts = ix.Ix.checkoutConfigFiles(
                new String[] { myServerScriptDir + "/*" }, ConfigFileC.mbNoFileData, LockC.NO);

            Logger.instance().log(")internalCheckinScripts");
        }

        /// <summary>
        /// Delets the example scripts
        /// </summary>
        /// <param name="ix">IndexServer connection</param>
        /// <param name="CONST">IndexServer constants</param>
        /// <param name="ci">Client information (ticket)</param>
        /// <param name="scriptNames">Array of script names</param>
        private void internalDeleteScripts(IXConnection ix,
            IXServicePortC CONST,
            String[] scriptNames)
        {
            String[] scriptPaths = new String[scriptNames.Length];
            for (int i = 0; i < scriptNames.Length; i++)
            {
                scriptPaths[i] = myServerScriptDir + "\\" + scriptNames[i];
            }
            ix.Ix.deleteConfigFiles(scriptPaths, LockC.NO);
        }
    }
}
