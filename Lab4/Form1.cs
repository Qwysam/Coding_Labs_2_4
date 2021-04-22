using System;
using System.Linq;
using System.Windows.Forms;


namespace Lab4
{
    public partial class Form1 : Form
    {
        //object of class Tmas used to pass data to other forms
        Tmas MyMatrix;
        public Form2 f;
        public Form1()
        {
            MyMatrix = new Tmas();
            InitializeComponent();
            Op_1.Checked = true;
        }
        //limits user input to avoid exceptions while parsing
        private void CheckInput(TextBox textBox, object sender, KeyPressEventArgs e) 
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                //limits negative sing input to one
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('-'))
                        e.KeyChar = (char)Keys.None;
                }
                //disables the ability to input positive sign
                if (e.KeyChar == '+')
                        e.KeyChar = (char)Keys.None;
                //disables the ability to input non-integer values
                if (e.KeyChar == ',')
                {
                    e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ',')
                    e.KeyChar = (char)Keys.None;
            }

        }
        //input array size
        private void N_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(N, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        //input min value for array generation
        private void A_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(A, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        //input max value for array generation
        private void B_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                CheckInput(B, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        //input element b for third operation
        private void element_b_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                CheckInput(element_b, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        //button that closes the app
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        //opens forms with info about the author
        private void Author_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Text = Author.Text;
            f.ShowDialog();
        }
        //opens form2 and passes all the necessary data
        private void OpenForm2_Click(object sender, EventArgs e)
        {
            int size, min, max, b;
            try
            {
                size = int.Parse(N.Text);
                min = int.Parse(A.Text);
                max = int.Parse(B.Text);
                MyMatrix.GenerateMatrix(min, max, size);
            }
            catch { }
            string op = " ";
            int num = 0;
            if (Op_1.Checked)
            {
                op = "Определить максимальный элемент массива";
                num = 1;
            }
            if (Op_2.Checked)
            {
                op = "Отсортировать элементы столбцов массива по убыванию, представить их в квадратном массиве";
                num = 2;
            }
            if (Op_3.Checked)
            {
                op = "Вычесть из всех элементов массива элемент b";
                num = 3;
            }
            f = new Form2(MyMatrix, A.Text, B.Text,element_b.Text, op, num);
            f.Show();
        }
    }

}
