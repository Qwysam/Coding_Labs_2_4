using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form2 : Form
    {
        //used to update DataGrid values
        void DataGridUpdate(int[,]arr)
        {
            int n = arr.GetLength(0);
            Matrix.RowCount = n;
            Matrix.ColumnCount = n;
            int i, j;
            for (i = 0; i < n; ++i)
            {
                Matrix.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                for (j = 0; j < n; ++j)
                    Matrix.Rows[i].Cells[j].Value = arr[i, j];
            }
        }
        //stores matrix from Form1
        Tmas MyMatrix = new Tmas();
        //stores selected operation
        private int op_num;
        public Form2()
        {
            InitializeComponent();
        }
        //constructor to pass data from Form1
        public Form2(Tmas matrix,string a, string b, string element_b_str,string op, int num)
        {
            InitializeComponent();
            N1.Text = matrix.FA.GetLength(0).ToString();
            A1.Text = a;
            B1.Text = b;
            element_b.Text = element_b_str;
            Op_number.Text = op;
            op_num = num;
            MyMatrix = matrix;
            DataGridUpdate(MyMatrix.FA);
        }
        //Used to repeat matrix generation
        private void Generate_Matrix_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(N1.Text);
                int a = int.Parse(A1.Text);
                int b = int.Parse(B1.Text);
                MyMatrix.GenerateMatrix(a, b, n);
            }
            catch { }
            DataGridUpdate(MyMatrix.FA);
        }
        //invokes method to save base matrix
        private void Save_Matrix_Click(object sender, EventArgs e)
        {
            MyMatrix.WriteMatrix(MyMatrix.flattened_matr);
        }
        //invokes method to read base matrix
        private void Read_Matrix_Click(object sender, EventArgs e)
        {
            MyMatrix.flattened_matr = MyMatrix.ReadMatrix();
            DataGridUpdate(MyMatrix.FA);
        }
        //performs operation chosen in Form1
        private void Operations_Click(object sender, EventArgs e)
        {
            //matrix max element 
            if (op_num == 1)
            {
                //finds max element of matrix using Linq
                int max = MyMatrix.FA.Cast<int>().Max();
                MessageBox.Show($"Максимальный элемент : {max}");
            }
            //sort columns
            if (op_num == 2)
            {
                MyMatrix.SortColumns();
                DataGridUpdate(MyMatrix.res);
            }
            //matrix - b
            if (op_num == 3)
            {
                //input check for b
                int b;
                if(!int.TryParse(element_b.Text, out b))
                    MessageBox.Show("Введены некорректные данные");
                else
                {
                    int size = MyMatrix.FA.GetLength(0);
                    MyMatrix.res = new int[size, size];
                    for (int i = 0; i < size; ++i)
                        for (int j = 0; j < size; ++j)
                            MyMatrix.res[i, j] = MyMatrix.FA[i, j] - b;
                    DataGridUpdate(MyMatrix.res);
                }
            }
        }
        //invokes method to save results of operation
        private void save_res_Click(object sender, EventArgs e)
        {
            MyMatrix.WriteMatrix(MyMatrix.flattened_res);
        }
        //invokes method to save results of operation
        private void read_res_Click(object sender, EventArgs e)
        {
            MyMatrix.flattened_res = MyMatrix.ReadMatrix();
            DataGridUpdate(MyMatrix.res);
        }
    }
}
