using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class Form1 : Form
    {
        public int Counter { get; set; }
        public Form1()
        {
            Counter = 0;
            InitializeComponent();
        }

        private void WhenButtonClicked(object sender, EventArgs e)
        {
            Counter += 1;
            lblResult.Text = $"I've been clicked {Counter} times!";

            if (Counter >= 10)
            {
                btnClickMe.Click -= WhenButtonClicked;
                btnClickMe.Click += WhenButtonClickedBy2;
            }

        }
        private void WhenButtonClickedBy2(object sender, EventArgs e)
        {
            Counter += 2;
            lblResult.Text = $"I've been clicked {Counter} times!";

            if (Counter >= 30)
            {
                btnClickMe.Enabled = false;
            }
        }
        public void Form_Load(object sender, EventArgs e)
        {

        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            lblResult.Text = "I just hovered over the button";
        }
    }
}
