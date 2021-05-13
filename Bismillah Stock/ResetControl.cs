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
    public partial class ResetControl : UserControl
    {
        private static ResetControl _instance;

        public static ResetControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ResetControl();
                }

                return _instance;
            }
        }

        public ResetControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(LoginControl.Instance);
            LoginControl.Instance.Dock = DockStyle.Fill;
            LoginControl.Instance.BringToFront();
            Parent.Controls.Remove(ResetControl.Instance);
        }
    }
}
