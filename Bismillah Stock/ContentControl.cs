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
    public partial class ContentControl : UserControl
    {
        private static ContentControl _instance;

        public static ContentControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContentControl();
                }

                return _instance;
            }
        }

        public ContentControl()
        {
            InitializeComponent();
        }

        private void ContentControl_Load(object sender, EventArgs e)
        {
            //MainForm.ActiveForm.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            
            //MainForm.ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;

            if(MainForm.ActiveForm.WindowState.ToString() == "Normal")
            {
                MainForm.ActiveForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MainForm.ActiveForm.WindowState = FormWindowState.Normal;
            }
            
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm.dragging = true;
            MainForm.startPoint = new Point(e.X, e.Y);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            MainForm.dragging = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainForm.dragging)
            {
                Point p = PointToScreen(e.Location);
                MainForm.ActiveForm.Location = new Point(p.X - MainForm.startPoint.X, p.Y - MainForm.startPoint.Y);
            }
        }

        private void panel4_DoubleClick(object sender, EventArgs e)
        {
            if (MainForm.ActiveForm.WindowState.ToString() == "Normal")
            {
                MainForm.ActiveForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MainForm.ActiveForm.WindowState = FormWindowState.Normal;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Controls.Remove(ContentControl.Instance);
            MainForm.ActiveForm.Controls.Add(Login.Instance);
            Login.Instance.Dock = DockStyle.Fill;
            Login.Instance.BringToFront();
            MainForm.ActiveForm.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
