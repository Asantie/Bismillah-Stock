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
    public partial class MainForm : Form
    {
        public static bool dragging = false;
        public static Point startPoint = new Point(0, 0);

        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            //Check login user
            this.Controls.Add(Login.Instance);
            Login.Instance.Dock = DockStyle.Fill;
            Login.Instance.BringToFront();
            //this.WindowState = FormWindowState.Maximized;
        }

    }
}
