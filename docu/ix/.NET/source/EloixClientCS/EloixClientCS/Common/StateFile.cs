using System;
using System.IO;

namespace EloixClient.Common
{
    /// <summary>
    /// The class StateFile represents a state file.
    /// </summary>
    public class StateFile
    {










        #region Initialization
        /// <summary>
        /// Constructor
        /// </summary>
        public StateFile(string stateFilePath)
        {
            bool existsStateFile = (!string.IsNullOrEmpty(stateFilePath) && File.Exists(stateFilePath));
            if (!existsStateFile)
                throw new InvalidOperationException("Loading state file data from specific file path was not possible. State file not found or does not exists.");
            else
            {
                string stateFileExt = System.IO.Path.GetExtension(stateFilePath);
                if (string.Compare(stateFileExt, ".state", true) == 0)
                {
                    LoadFileDate(stateFilePath);
                    Path = stateFilePath;
                }
                else
                    throw new InvalidOperationException("Loading state file data from specific file is not possible. File is no sstate file.");
            }
        }
        #endregion










        /// <summary>
        /// Returns back or setst id of specific object, to that this file belongs.
        /// </summary>
        public int? ObjectId
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns back or sets id of specific document, to that this file belongs.
        /// </summary>
        public int? DocumentId
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns back or sets id of user that has locked a document, to which this file belongs.
        /// </summary>
        public int? LockId
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns back a path to the state file.
        /// </summary>
        public string Path
        {
            get;
            private set;
        }

        /// <summary>
        /// Loads a state file data from a specific file and saves them in class properties.
        /// </summary>
        /// <param name="filePath"></param>
        protected virtual void LoadFileDate(string filePath)
        {
            string line    = null;
            int lineNumber = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        int intValue = -1;

                        try
                        {
                            if (lineNumber == 0)
                            {
                                if (int.TryParse(line, out intValue))
                                    ObjectId = intValue;
                                else
                                    ObjectId = new int?();
                            }
                            else if (lineNumber == 1)
                            {
                                if (int.TryParse(line, out intValue))
                                    DocumentId = intValue;
                                else
                                    DocumentId = new int?();
                            }
                            else if (lineNumber == 2)
                            {
                                if (int.TryParse(line, out intValue))
                                    LockId = intValue;
                                else
                                    LockId = new int?();
                            }
                        }
                        catch { }
                        finally
                        {
                            lineNumber++;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
