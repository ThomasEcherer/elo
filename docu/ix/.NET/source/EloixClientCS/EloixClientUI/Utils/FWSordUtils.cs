using System;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Content;
using EloixClientUI.Dialogs;

namespace EloixClientUI.Utils
{
    public static class FWSordUtils
    {
        public static string GetDocumentFile(FWSord sord)
        {
            string documentFile = null;

            if (sord is FWDocument)
            {
                FWDocument doc = sord as FWDocument;
                int encryptionSet = doc.Core.details.encryptionSet;
                if (encryptionSet > 0)
                {
                    if (doc.Conn.Session.EncrPasswords[encryptionSet.ToString()] != null)
                        return doc.File;

                    // Anzeige eines Dialogs zur Eingabe des Verschlüsselungspassworts
                    if (doc.Conn != null && doc.Conn.Ix != null)
                    {
                        EncryptionPasswordDialog dlg = new EncryptionPasswordDialog(encryptionSet);
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                string key = Convert.ToString(encryptionSet);
                                doc.Conn.Session.EncrPasswords[key] = dlg.Password;
                                doc.Conn.Session.EncrPasswords.Checkin();
                                doc = doc.Conn.Content.GetDocument(doc.Id);
                                documentFile = doc.File;
                            }
                            catch (Exception exc)
                            {
                                if (sord.Conn.IsException(exc, IXExceptionC.INVALID_CRYPT_KEY))
                                {
                                    string key = Convert.ToString(encryptionSet);
                                    doc.Conn.Session.EncrPasswords[key] = null;
                                    IXExceptionData exceptionData = sord.Conn.Ix.parseException(exc.ToString());
                                    MessageBox.Show(exceptionData.message, "ELO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                    documentFile = doc.File;

            }

            return documentFile;
        }
    }
}
