using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Workflow
{
    /// <summary>
    /// This class provides helps to access the workflow engine of IndexServer.
    /// </summary>
    public class FWWorkflowInterface
    {
        /// <summary>
        /// The class factory creates all objects of the classes in this package.
        /// </summary>
        protected FWWorkflowClassFactory classFactoryVal;
        /// <summary>
        /// IndexServer connection
        /// </summary>
        protected FWConnection connVal;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn">Connection to IndexServer</param>
        /// <param name="connProps">Connection properties</param>
        public FWWorkflowInterface(FWConnection conn, IXProperties connProps)
        {
            this.classFactoryVal = new FWWorkflowClassFactory(this);
            this.connVal = conn;
        }

        /// <summary>
        /// Gets current class factory.
        /// </summary>
        public FWWorkflowClassFactory ClassFactory
        {
            get { return classFactoryVal; }
            set { classFactoryVal = value; }
        }

        /// <summary>
        /// Gets the IndexServer connection.
        /// </summary>
        public FWConnection Conn
        {
            get { return connVal; }
        }

        /// <summary>
        /// Returns all tasks for the current user.
        /// </summary>
        /// <returns>Tasks</returns>
        public FWFindTasksCache GetUserTasks()
        {
            FindTasksInfo fi = new FindTasksInfo();
            fi.lowestPriority = UserTaskPriorityC.LOWEST;
            fi.highestPriority = UserTaskPriorityC.HIGHEST;
            fi.inclDeputy = true;
            fi.inclGroup = true;
            fi.inclReminders = true;
            fi.inclWorkflows = true;
            fi.inclActivities = true;
            FWFindTasksCache tasksCache = new FWFindTasksCache(this, fi);
            return tasksCache;
        }

    }
}
