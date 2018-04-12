using System;
using EloixClient.IndexServer;


namespace Examples
{
	/// <summary>
	///
	/// 1. Create 100 Sords under a root folder:
	/// 2. Read the created Sords
	/// 3. Delete root folder logically (implicitly deletes the 100 included Sords)
	/// 4. Delete root folder finally (implicitly deletes the 100 included Sords)
	///
	/// </summary>
	public class SordPerformance
	{
		// URL to IndexServer
		public String url;

		// [X] Account to authenticate 
		public String userName = "Administrator"; 
		public String userPwd = "";					

		public void run()
		{
			IXConnFactory connFact = null;
			IXConnection ix = null;
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

				// Create a root folder
				Sord e1 = ix.Ix.createSord("1", "0", EditInfoC.mbSord).sord;
				e1.name = "e1";
				e1.id = ix.Ix.checkinSord(e1, SordC.mbAll, LockC.NO);
				Logger.instance().log("created e1: id=" + e1.id);

				// Create 100 Sords
				int nbOfSords  = 100;
				String[] guids = new String[nbOfSords];
				DateTime startTime, endTime;
				long createTicks = 0, checkinTicks = 0;

				startTime = System.DateTime.Now;
				for (int i = 0; i < nbOfSords; i++) 
				{
					DateTime t1 = System.DateTime.Now;					
					Sord e2 = ix.Ix.createSord(e1.guid, "Email", EditInfoC.mbSord).sord;
					DateTime t2 = System.DateTime.Now;
					createTicks += t2.Ticks - t1.Ticks;

					e2.name = "e1." + i;
					for (int idx = 0; idx < e2.objKeys.Length; idx++) 
					{
						e2.objKeys[idx].data = new String[] {e2.name + ".idx" + idx};
					}

					t1 = System.DateTime.Now;					
					e2.id = ix.Ix.checkinSord(e2, SordC.mbAll, LockC.NO);
					t2 = System.DateTime.Now;
					checkinTicks += t2.Ticks - t1.Ticks;

					guids[i] = e2.guid;
					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("create: " + (i+1) + "/" + nbOfSords);
					}
				}
				endTime = System.DateTime.Now; 

				// Log time values
				logTimeValues("createSord()", createTicks, nbOfSords);
				logTimeValues("checkinSord()", checkinTicks, nbOfSords);
				logTimeValues("create", startTime, endTime, nbOfSords);
		
				// 2. Read 100 Sords
				startTime = System.DateTime.Now;
				for (int i = 0; i < nbOfSords; i++) 
				{
					Sord sord = ix.Ix.checkoutSord(guids[i], EditInfoC.mbSord, LockC.NO).sord;
					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("read: " + (i+1) + "/" + nbOfSords);
					}
				}
				endTime = System.DateTime.Now; 

				// Log time values
				logTimeValues("read", startTime, endTime, nbOfSords);

				// 3. Read 100 Sords - lean 
				startTime = System.DateTime.Now;
				for (int i = 0; i < nbOfSords; i++) 
				{
					Sord sord = ix.Ix.checkoutSord(guids[i], 
						EditInfoC.mbSordLean, LockC.NO).sord;
					if ((i+1) % 20 == 0) 
					{
						Logger.instance().log("read: " + (i+1) + "/" + nbOfSords);
					}
				}
				endTime = System.DateTime.Now; 

				// Log time values
				logTimeValues("read-lean", startTime, endTime, nbOfSords);

				// 3. Delete root folder logically (implicitly deletes the 100 included Sords)
				Logger.instance().log("delete logically...");
				startTime = System.DateTime.Now;
				ix.Ix.deleteSord(null, e1.guid, LockC.NO, null);
				endTime = System.DateTime.Now;
				logTimeValues("delete logically", startTime, endTime, nbOfSords);

				// 4. Delete root folder finally (implicitly deletes the 100 included Sords)
				Logger.instance().log("delete finally...");
				startTime = System.DateTime.Now;
        DeleteOptions delOpts = new DeleteOptions();
        delOpts.deleteFinally = true;
				ix.Ix.deleteSord(null, e1.guid, LockC.NO, delOpts);
				endTime = System.DateTime.Now;
				logTimeValues("delete finally", startTime, endTime, nbOfSords);
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

		private void logTimeValues(String actionName, double dt, int n)
		{
			double ns100 = 1000L * 1000L * 10;
			dt /= ns100;
			double secondsPerAction = dt / (double)n;
			double actionsPerSecond = 1.0 / secondsPerAction;
			Logger.instance().log("action=" + actionName + ": dt=" + dt);
			Logger.instance().log("  secondsPerAction=" + secondsPerAction);
			Logger.instance().log("  actionsPerSecond=" + actionsPerSecond);
		}

		private void logTimeValues(String actionName, DateTime startTime, DateTime endTime, int n)
		{
			double dt = (double)endTime.Ticks - (double)startTime.Ticks;
			logTimeValues(actionName, dt, n);
		}
	}
}