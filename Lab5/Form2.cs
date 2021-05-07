using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        private void chooseDiagramFormat(string name, int i = 0)
        {
            if (name == comboBox1.Items[0].ToString())
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            if (name == comboBox1.Items[1].ToString())
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            if (name == comboBox1.Items[2].ToString())
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            if (name == comboBox1.Items[3].ToString())
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            if (name == comboBox1.Items[4].ToString())
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            if (name == comboBox1.Items[5].ToString())
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }
        private void Generate_Chart()
        {
            chooseDiagramFormat(comboBox1.Text);

            double[] mas = new double[arr.Length];
            for (int j = 1; j < dataGridView1.Columns.Count; j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    //Ошибка которая происходит когда пытаешся изменить элементы dataGridViewer (исправить через invalidCastException)

                    mas[i] = (int)dataGridView1[j, i].Value;

                    chart1.Series[0].Points.AddY(mas[i]);
                }
            }
        }
        int[] arr = Form1.array;
        public Form2()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("x", "x");
            dataGridView1.Columns.Add("y1", "y1");
            if (Form1.histogram)
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = 1;
            dataGridView1.Rows.Add(arr.GetLength(0));

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //Вырванивание таблицы
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dataGridView1[0, i].Value = i+1;
                dataGridView1[1, i].Value = arr[i];

            }
            Generate_Chart();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            Generate_Chart();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_Form3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Text = "Автор";
            f.ShowDialog();
        }
    }
    
}
