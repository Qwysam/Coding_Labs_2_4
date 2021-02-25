using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator 
{
    public interface InterfaceCalc
    {
        //а - first argument, b - second argument
        void Put_A(double a); //save а

        void Clear_A();

        double Multiplication(double b);

        double Division(double b);

        double Sum(double b);

        double Subtraction(double b); 

        double Sqrt();

        double Square();

        double MemoryShow();

        void Memory_Clear(); 
        double sin();
    }
    public partial class Form1 : Form, InterfaceCalc
    {
        private double a = 0;
        private double memory = 0;
        int k;
        public void Put_A(double a)
        {
            this.a = a;
        }
        /// <summary>
        /// Clear row
        /// </summary>
        public void Clear_A()
        {
            a = 0;
        }
        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiplication(double b)
        {
            return a * b;
        }
        /// <summary>
        /// Division
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Division(double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
                return a / b;
        }
        /// <summary>
        /// sum
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sum(double b)
        {
            return a + b;
        }
        /// <summary>
        /// Substruction
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Subtraction(double b)
        {
            return a - b;
        }
        /// <summary>
        /// sin operation
        /// </summary>
        /// <returns></returns>
        public double sin()
        {
            return Math.Sin(a);
        }
        /// <summary>
        /// sqrt method
        /// </summary>
        /// <returns></returns>
        public double Sqrt()
        {
            return Math.Sqrt(a);
        }
        /// <summary>
        /// square method
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return Math.Pow(a, 2.0);
        }
        /// <summary>
        /// memory return
        /// </summary>
        /// <returns></returns>
        public double MemoryShow()
        {
            return memory;
        }
        /// <summary>
        /// clean memory
        /// </summary>
        public void Memory_Clear()
        {
            memory = 0.0;
        }
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
        }
        /// <summary>
        /// Check what buttons are able to be pressed
        /// </summary>
        /// <returns></returns>
        private bool CanPress()
        {
            //+
            if (!button_plus.Enabled)
                return false;
            // -
            if (!button_minus.Enabled)
                return false;
            // *
            if (!button_mult.Enabled)
                return false;
            // sqrt
            if (!button_sin.Enabled)
                return false;
            // /
            if (!button_div.Enabled)
                return false;
            if (!button_sqrt.Enabled)
                return false;
            if (!button_square.Enabled)
                return false;
            return true;


        }
        /// <summary>
        /// Check what button are free to be press
        /// </summary>
        private void FreeButtons()
        {
            button_square.Enabled = true;
            button_sqrt.Enabled = true;
            button_sin.Enabled = true;
            button_div.Enabled = true;
            button_minus.Enabled = true;
            button_mult.Enabled = true;
            button_plus.Enabled = true;
        }
        /// <summary>
        /// Main window where numbers are placed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 13;
             
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Check correct input
        /// </summary>
        private void CorrectNumber()

        {
            if (textBox1.TextLength == 13)
                textBox1.Text = textBox1.Text.Remove(0, 1);
           
            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (textBox1.TextLength >= 2)
            { 
                if (textBox1.Text[0] == '0' && (textBox1.Text.IndexOf(",") != 1))
                    textBox1.Text = textBox1.Text.Remove(0, 1);
            }

            //аналогично предыдущему, только для отрицательного числа
            if (textBox1.Text[0] == '-')
                if (textBox1.Text[1] == '0' && (textBox1.Text.IndexOf(",") != 2))
                    textBox1.Text = textBox1.Text.Remove(1, 1);
        }
        /// <summary>
        /// 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "1";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "2";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "3";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "4";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "5";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "6";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "7";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "8";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "9";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) <= 1000000 && int.Parse(textBox1.Text) >= -1000000)
                textBox1.Text += "0";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// <summary>
        /// =
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_equals_Click(object sender, EventArgs e)
        {
            if (!button_plus.Enabled)
                textBox1.Text = Sum(Convert.ToDouble(textBox1.Text)).ToString();
            if (!button_minus.Enabled)
                textBox1.Text = Subtraction(Convert.ToDouble(textBox1.Text)).ToString();
            if (!button_mult.Enabled)
                textBox1.Text = Multiplication(Convert.ToDouble(textBox1.Text)).ToString();
            if (!button_sin.Enabled)
            {
                textBox1.Text = sin().ToString();
            }
            if (!button_sqrt.Enabled)
                textBox1.Text = Sqrt().ToString();
            if (!button_square.Enabled)
                textBox1.Text = Square().ToString();
            if (!button_div.Enabled)
            {
                double result = Division(Convert.ToDouble(textBox1.Text));
                if (result == 0)
                    MessageBox.Show("Zero division");
                else
                    textBox1.Text = result.ToString();
            }
            textBox2.Visible = true;
            textBox2.Text = "RESULT";
            Clear_A();
            FreeButtons();

            k = 0;
        }
        /// <summary>
        /// +/-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sign_change_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }
        /// <summary>
        /// C
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox2.Visible = false;

            Clear_A();
            //FreeButtons();
            //k = 0;
        }
        /// <summary>
        /// + operator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_plus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                textBox2.Text = "";
                Put_A(Convert.ToDouble(textBox1.Text));
                button_plus.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// * operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_mult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                textBox2.Text = "";
                Put_A(Convert.ToDouble(textBox1.Text));
                button_mult.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// - operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_minus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));
                textBox2.Text = "";

                button_minus.Enabled = false;

                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// sin() operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sin_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button_sin.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// Sqrt button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button_sqrt.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// square button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_square_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button_square.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// Division button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_div_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button_div.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// <summary>
        /// clear one element button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_last_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));
                if (textBox1.TextLength == 1)
                {
                    textBox1.Text = "0";
                }
                else if (textBox1.TextLength == 2)
                { 
                    if (textBox1.Text[0] == '-')
                    { 
                    textBox1.Text = "0";
                    }
                    else
                    {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                }
            }
        }
    }
}
