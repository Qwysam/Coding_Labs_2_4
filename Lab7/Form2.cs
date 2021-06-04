using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_lab_7
{
    public partial class Form2 : Form
    {
        public Form2(Student[] initial)
        {
            InitializeComponent();
            textBox2.Text = Fulfill(initial);
        }

        public void Agr(string result, string text)
        {
            label1.Text = text;
            textBox1.Text = result;
        }

        public void Grouping(string result, string text)
        {
            label1.Text = text;
            textBox1.Text = result;
        }

        public void Sorting(Student[] students, string text)
        {
            string str = "";
            for (int i = 0; i < students.Length; i++)
            {
                str += students[i].ToString() + "\r\n\r\n";
            }
            label1.Text = text;
            textBox1.Text = str;
        }
        public void Filtration(Student[] students, string text)
        {
            string str = "";
            for (int i = 0; i < students.Length; i++)
            {
                str += students[i].ToString() + "\r\n\r\n";
            }
            label1.Text = text;
            textBox1.Text = str;
        }
        public string Fulfill(Student[] students)
        {
            string str = "";
            for(int i = 0; i < students.Length; i++)
            {
                str += students[i].ToString() + "\r\n\r\n";
            }
            return str;
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Text = "Автор";
            f.ShowDialog();
        }
    }
}
