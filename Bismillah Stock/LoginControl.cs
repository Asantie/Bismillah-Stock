using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah_Stock
{
    public partial class LoginControl : UserControl
    {
        private static LoginControl _instance;

        public static LoginControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginControl();
                }

                return _instance;
            }
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void lnReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Parent.Controls.Add(ResetControl.Instance);
            ResetControl.Instance.Dock = DockStyle.Fill;
            ResetControl.Instance.BringToFront();
            Parent.Controls.Remove(LoginControl.Instance);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            } 
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check user and login in valid user
            MainForm.ActiveForm.Controls.Remove(Login.Instance);

            // Add Content controll 
            MainForm.ActiveForm.Controls.Add(ContentControl.Instance);
            ContentControl.Instance.Dock = DockStyle.Fill;


            MainForm.ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
