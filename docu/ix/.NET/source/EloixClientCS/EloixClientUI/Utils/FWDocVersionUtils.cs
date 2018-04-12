using System;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Content;
using EloixClientUI.Dialogs;

namespace EloixClientUI.Utils
{
    public static class FWDocVersionUtils
    {
        public static string DocumentFile(FWDocVersion docVersion, FWDocument document)
        {
            string documentFile = null;

            int encryptionSet = docVersion.Core.encryptionSet;

            if (encryptionSet > 0)
            {
                bool keyExists = false;

                if (docVersion.Conn.Session.EncrPasswords[encryptionSet.ToString()] != null)
                    //return docVersion.File;
                    keyExists = true;

                // Anzeige eines Dialogs zur Eingabe des Verschlüsselungspassworts
                if (docVersion.Conn != null && docVersion.Conn.Ix != null)
                {
                    EncryptionPasswordDialog dlg = new EncryptionPasswordDialog(encryptionSet);
                    if (keyExists || dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            if (!keyExists)
                            {
                                string key = Convert.ToString(encryptionSet);
                                docVersion.Conn.Session.EncrPasswords[key] = dlg.Password;
                                docVersion.Conn.Session.EncrPasswords.Checkin();
                                document.Checkin();
                            }
                            document = document.Conn.Content.GetSord(document.Id) as FWDocument;
                            foreach (FWDocVersion version in document.Versions)
                            {
                                if (version.Id == docVersion.Id)
                                {
                                    docVersion = version;
                                    break;
                                }
                            }

                            documentFile = docVersion.File;
                        }
                        catch (Exception exc)
                        {
                            if (document.Conn.IsException(exc, IXExceptionC.INVALID_CRYPT_KEY))
                            {
                                string key = Convert.ToString(encryptionSet);
                                docVersion.Conn.Session.EncrPasswords[key] = null;
                                IXExceptionData exceptionData = document.Conn.Ix.parseException(exc.ToString());
                                MessageBox.Show(exceptionData.message, "ELO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
                documentFile = docVersion.File;

            return documentFile;
        }
    }
}
