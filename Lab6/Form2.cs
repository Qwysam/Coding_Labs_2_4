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

namespace AnalogClock
{
    public partial class Form2 : Form
    {
        public string input;
        private void CheckInput(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || textBox.Text.Length > 2) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = (char)Keys.None;
            }
            if (int.Parse(textBox.Text) > 255)
                e.KeyChar = (char)Keys.None;
        }
        public Form2()
        {
            InitializeComponent();
            textBoxABackground.Text = Form1.LinearBrush1.A.ToString();
            textBoxRBackground.Text = Form1.LinearBrush1.R.ToString();
            textBoxGBackground.Text = Form1.LinearBrush1.G.ToString();
            textBoxBBackground.Text = Form1.LinearBrush1.B.ToString();
            textBoxAHourHand.Text = Form1.Hour_Dash_Pen.A.ToString();
            textBoxRHourHand.Text = Form1.Hour_Dash_Pen.R.ToString(); 
            textBoxGHourHand.Text = Form1.Hour_Dash_Pen.G.ToString(); 
            textBoxBHourHand.Text = Form1.Hour_Dash_Pen.B.ToString(); 
            textBoxAMinuteHand.Text = Form1.MinutePen.A.ToString();
            textBoxRMinuteHand.Text = Form1.MinutePen.R.ToString();
            textBoxGMinuteHand.Text = Form1.MinutePen.G.ToString();
            textBoxBMinuteHand.Text = Form1.MinutePen.B.ToString();
            textBoxASecondHand.Text = Form1.SecondPen.A.ToString();
            textBoxRSecondHand.Text = Form1.SecondPen.R.ToString();
            textBoxGSecondHand.Text = Form1.SecondPen.G.ToString();
            textBoxBSecondHand.Text = Form1.SecondPen.B.ToString();
            buttonSaveConfig.Enabled = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput((TextBox)sender, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Form1.LinearBrush1 = Color.FromArgb(int.Parse(textBoxABackground.Text), int.Parse(textBoxRBackground.Text),
                                 int.Parse(textBoxGBackground.Text), int.Parse(textBoxBBackground.Text));
            Form1.Hour_Dash_Pen = Color.FromArgb(int.Parse(textBoxAHourHand.Text), int.Parse(textBoxRHourHand.Text),
                                 int.Parse(textBoxGHourHand.Text), int.Parse(textBoxBHourHand.Text));
            Form1.MinutePen = Color.FromArgb(int.Parse(textBoxAMinuteHand.Text), int.Parse(textBoxRMinuteHand.Text),
                                 int.Parse(textBoxGMinuteHand.Text), int.Parse(textBoxBMinuteHand.Text));
            Form1.SecondPen = Color.FromArgb(int.Parse(textBoxASecondHand.Text), int.Parse(textBoxRSecondHand.Text),
                                 int.Parse(textBoxGSecondHand.Text), int.Parse(textBoxBSecondHand.Text));
            buttonSaveConfig.Enabled = true;
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            string default_config = Color.Green.ToArgb().ToString();
            default_config += "\n";
            default_config += Color.White.ToArgb().ToString();
            default_config += "\n";
            default_config += Color.LightGray.ToArgb().ToString();
            default_config += "\n";
            default_config += Color.Red.ToArgb().ToString();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.Filter = "TXT Files|*.txt";
            sfd.FileName = "Default_config.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, default_config);
            }
            string user_config = Form1.LinearBrush1.ToArgb().ToString();
            user_config += "\n";
            user_config += Form1.Hour_Dash_Pen.ToArgb().ToString();
            user_config += "\n";
            user_config += Form1.MinutePen.ToArgb().ToString();
            user_config += "\n";
            user_config += Form1.SecondPen.ToArgb().ToString();
            sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.Filter = "TXT Files|*.txt";
            sfd.FileName = "User_config.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, user_config);
            }
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    input = File.ReadAllText(theDialog.FileName);
                    string[] settings = input.Split('\n');
                    Form1.LinearBrush1 = Color.FromArgb(int.Parse(settings[0]));
                    Form1.Hour_Dash_Pen = Color.FromArgb(int.Parse(settings[1]));
                    Form1.MinutePen = Color.FromArgb(int.Parse(settings[2]));
                    Form1.SecondPen = Color.FromArgb(int.Parse(settings[3]));
                    textBoxABackground.Text = Form1.LinearBrush1.A.ToString();
                    textBoxRBackground.Text = Form1.LinearBrush1.R.ToString();
                    textBoxGBackground.Text = Form1.LinearBrush1.G.ToString();
                    textBoxBBackground.Text = Form1.LinearBrush1.B.ToString();
                    textBoxAHourHand.Text = Form1.Hour_Dash_Pen.A.ToString();
                    textBoxRHourHand.Text = Form1.Hour_Dash_Pen.R.ToString();
                    textBoxGHourHand.Text = Form1.Hour_Dash_Pen.G.ToString();
                    textBoxBHourHand.Text = Form1.Hour_Dash_Pen.B.ToString();
                    textBoxAMinuteHand.Text = Form1.MinutePen.A.ToString();
                    textBoxRMinuteHand.Text = Form1.MinutePen.R.ToString();
                    textBoxGMinuteHand.Text = Form1.MinutePen.G.ToString();
                    textBoxBMinuteHand.Text = Form1.MinutePen.B.ToString();
                    textBoxASecondHand.Text = Form1.SecondPen.A.ToString();
                    textBoxRSecondHand.Text = Form1.SecondPen.R.ToString();
                    textBoxGSecondHand.Text = Form1.SecondPen.G.ToString();
                    textBoxBSecondHand.Text = Form1.SecondPen.B.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
