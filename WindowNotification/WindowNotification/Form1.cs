using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void DisplayNotify()
        {
            try
            {
                //notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"image\graph.ico"));
                notifyIcon1.Text = "Testing";
                notifyIcon1.Visible = true;

                notifyIcon1.BalloonTipTitle = "This is Test by Dhananjay";
                notifyIcon1.BalloonTipText = "Click here to see message";
                notifyIcon1.ShowBalloonTip(100);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayNotify();
        }
    }
}
