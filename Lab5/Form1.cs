using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public static int[] array { get; set; }
        public static bool histogram { get; set; }
        public static bool pie_chart { get; set; }

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 2;
            dataGridView1.RowCount = (int)numericUpDown1.Value;
            dataGridView1.ColumnCount = 1;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            Histogram.Select();
            button_Open_Form2.Enabled = false;
        }
        private void CheckInput(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || textBox.Text.Length > 9) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void textBox_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(textBox_min, sender, e);
            }
            catch { }
        }
        private void textBox_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(textBox_max, sender, e);
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 10)
                numericUpDown1.Value = 10;
            if (numericUpDown1.Value < 2)
                numericUpDown1.Value = 2;
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }
        private void dataGridView1_CellValueChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }
        
        private int[] ParseDataGrid()
        {
            int[] tmp = new int[dataGridView1.RowCount];
            for(int i = 0; i < tmp.Length; i++)
            {
                try
                {
                    tmp[i] = int.Parse(dataGridView1[0, i].Value.ToString());
                }
                catch
                {

                }
            }
            return tmp;
        }

        private void button_Open_Form2_Click(object sender, EventArgs e)
        {
            array = ParseDataGrid();
            if (Histogram.Checked)
            {
                histogram = true;
                pie_chart = false;
            }
            else
            {
                histogram = false;
                pie_chart = true;
            }
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private int[] GenerateArray(int min, int max, int length)
        {
                int[] LocalArray = new int[length];
                Random randElem = new Random();
                for (int i = 0; i < length; i++)
                {
                    LocalArray[i] = randElem.Next(min, max);
                }
                return LocalArray;
        }

        private void ArrayToDataGrid(DataGridView dgr, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //Вырванивание таблицы
                dgr.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgr[0, i].Value = arr[i];

            }
        }

        private void button_generate_array_Click(object sender, EventArgs e)
        {
            int max, min;
            if(int.TryParse(textBox_min.Text, out min) && int.TryParse(textBox_max.Text, out max)) 
            {
                array = GenerateArray(min, max, (int)numericUpDown1.Value);
                ArrayToDataGrid(dataGridView1, array);
                button_Open_Form2.Enabled = true;
            }
        }

        private void button_sort_array_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(array);
                Array.Reverse(array);
                ArrayToDataGrid(dataGridView1, array);
            }
            catch { }
        }

        private void button_Form3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Text = "Автор";
            f.ShowDialog();
        }
    }
    
}
