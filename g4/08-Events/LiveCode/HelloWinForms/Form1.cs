using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sayButtonClicked(object sender, EventArgs e)
        {
            lblCounter.Text = $"{(sender as Control).Name}'s been clicked";
        }

        private void btnHello_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X > 50)
            {
                lblCounter.Text = "Clicked right";
            }
            else
            {
                lblCounter.Text = "Clicked left";
            }
        }

    }
}
