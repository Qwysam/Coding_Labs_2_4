using System;
using System.Windows.Forms;

namespace tp_lab_7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            Initialize();
        }

        //link to author's github
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Qwysam");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(820, 308);
            this.Name = "Form4";
            this.ResumeLayout(false);

        }
    }
}