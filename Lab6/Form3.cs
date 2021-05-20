using System;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //link to author's github
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Qwysam");
        }

    }
}