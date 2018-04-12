using System;
using System.Windows.Forms;

namespace EloixClientUI.Dialogs
{
    public partial class EncryptionPasswordDialog : Form
    {
        public string Password
        {
            get { return pw1.Text; }
        }

        public EncryptionPasswordDialog(int encryptionSet)
        {
            InitializeComponent();
            ApplyResources(encryptionSet);
        }

        private void ApplyResources(int encryptionSet)
        {
            Text = Properties.Resources.EncryptionPassword;
            lblEncryptedDocumentInstruction.Text = string.Format(Properties.Resources.EncryptedDocumentInstructionLabel_Text, encryptionSet);
            lblPw1.Text = Properties.Resources.Password1_Label;
            lblPw2.Text = Properties.Resources.Password2_Label;
            lblErrorMessage.Text = Properties.Resources.Error_PasswordMismatch;
            lblErrorMessage.Visible = false;
            btnOK.Text = Properties.Resources.BtnOK;
            btnCancel.Text = Properties.Resources.BtnCancel;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            /*
            if (pw1.Text.Length == 0 && pw2.Text.Length == 0)
            {
                btnOK.Enabled = false;
                lblErrorMessage.Visible= false;
                return;
            }

            if (pw1.Text.Length == 0 || pw2.Text.Length == 0)
            {
                btnOK.Enabled = false;
                lblErrorMessage.Visible = true;
                return;
            }

            if (!string.Equals(pw1.Text, pw2.Text))
            {
                btnOK.Enabled = false;
                lblErrorMessage.Visible = true;
                return;
            }
            */
            if (pw1.Text.Length == 0)
            {
                btnOK.Enabled = false;
                return;
            }

            btnOK.Enabled = true;
            //lblErrorMessage.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
