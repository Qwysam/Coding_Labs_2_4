using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void Roots(double a ,double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                try
                {
                    double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 5);
                    double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 5);
                    x1.Text = x1_res.ToString();
                    x2.Text = x2_res.ToString();
                }
                catch { }
            }
            if (D == 0)
            {
                try
                {
                    double x1_res = Math.Round(-b / (2 * a), 5);
                    x1.Text = x1_res.ToString();
                }
                catch { }
                x2.Text = "";
            }
            if (D < 0)
            {
                x1.Text = "Дискриминант";
                x2.Text = "равен нулю";
            }

        }

        private void CheckInput(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('-'))
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '+')
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('+'))
                        e.KeyChar = (char)Keys.None;
                if (e.KeyChar == ',')
                {
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0)
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ',')
                    e.KeyChar = (char)Keys.None;
            }
        }
        private void variable_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(variable_a, sender, e);
        }

        private void variable_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(variable_b, sender, e);
        }
        private void variable_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(variable_c, sender, e);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (First_Method.Checked)
            {
                try
                {
                    double a = Convert.ToDouble(variable_a.Text);
                    double b = Convert.ToDouble(variable_b.Text);
                    double c = Convert.ToDouble(variable_c.Text);
                    double D = b * b - 4 * a * c;
                    if (D > 0)
                    {
                        double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a),5);
                        double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a),5);
                        x1.Text = x1_res.ToString();
                        x2.Text = x2_res.ToString();
                    }
                    if (D == 0)
                    {
                        double x1_res = Math.Round(-b / (2 * a),5);
                        x1.Text = x1_res.ToString();
                        x2.Text = "";
                    }
                    if (D < 0)
                    {
                        x1.Text = "Дискриминант";
                        x2.Text = "равен нулю";
                    }
                }
                catch (OverflowException of)
                {

                }

            }
            if (Second_Method.Checked)
            {
                try
                {
                    double a = Convert.ToDouble(variable_a.Text);
                    double b = Convert.ToDouble(variable_b.Text);
                    double c = Convert.ToDouble(variable_c.Text);
                    Roots(a, b, c);

                }
                catch
                {

                }
            }
            if (Third_Method.Checked)
            {
                try
                {
                    double a = Convert.ToDouble(variable_a.Text);
                    double b = Convert.ToDouble(variable_b.Text);
                    double c = Convert.ToDouble(variable_c.Text);
                    Calculation calc = new Calculation();
                    double?[]res = calc.ShowRoots(a, b, c);
                    if (res[0] != null && res[1] != null)
                    {
                        x1.Text = res[0].ToString();
                        x2.Text = res[1].ToString();
                    }
                    if(res[0]!= null && res[1] == null)
                    {
                        x1.Text = res[0].ToString();
                        x2.Text = "";
                    }
                    if (res[0] == null && res[1] == null)
                    {
                        x1.Text = "Дискриминант";
                        x2.Text = "равен нулю";
                    }
                }
                catch
                {

                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            variable_a.Text = "";
            variable_b.Text = "";
            variable_c.Text = "";
        }
    }
    public class Calculation
    {
        public double?[] ShowRoots(double a, double b, double c)
        {
            double?[] results = new double?[2];
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                try
                {
                    double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 5);
                    double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 5);
                    results[0] = x1_res;
                    results[1] = x2_res;
                }
                catch { }
            }
            if (D == 0)
            {
                try
                {
                    double x1_res = Math.Round(-b / (2 * a), 5);
                    results[0] = x1_res;
                }
                catch { }
                results[1] = null;
            }
            if (D < 0)
            {
                results[0] = null;
                results[1] = null;
            }
            return results;
        }
    }
}
