using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace tp_lab_7
{
    public partial class Form3 : Form
    {
        List<double> data = new List<double>();

        public Form3()
        {
            InitializeComponent();
        }

        public void Generate(int n)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            for(int i = 0; i < n; i++)
            {
                data.Add(r.Next(0, 99) + r.NextDouble());
            }
        }

        public List<double> LinqMethod(List<double> l)
        {
            return l.Where(n => n > 40 && n < 80).ToList();
        }

        public List<double> PLinqMethod(List<double> l)
        {
            return l.AsParallel().Where(n => n > 40 && n < 80).ToList();
        }

        public List<double> MyMethod1(List<double> l)
        {
            List<double> res = new List<double>();
            foreach(double d in l)
            {
                if (d > 40 && d < 80)
                {
                    res.Add(d);
                }
            }
            return res;
        }

        public List<double> MyMethod2(List<double> l)
        {
            List<double> res = new List<double>();
            for (int i = 0; i < l.Count; i++) 
            {
                if (l[i] > 40 && l[i] < 80)
                {
                    res.Add(l[i]);
                }
            }
            return res;
        }

        public void ChartFiller()
        {
            Color[] c = new Color[4] { Color.Black, Color.Red, Color.Green, Color.Yellow };
            chart1.ChartAreas[0].AxisX.Title = "Размерность";
            chart1.ChartAreas[0].AxisY.Title = "Время, мс";
            chart1.Series.Clear();
            chart1.Series.Add("Linq");
            chart1.Series.Add("PLinq");
            chart1.Series.Add("MyMethod1");
            chart1.Series.Add("MyMethod2");
            for (int i = 0; i < 4; i++)
            {
                chart1.Series[i].ChartType = SeriesChartType.FastLine;
                chart1.Series[i].BorderWidth = 3;
                chart1.Series[i].Color = c[i];
                //chart1.Series[i].Legend = "Series" + i.ToString();
            }
            Stopwatch timer = new Stopwatch();
            for(int i = 100000, j = 0; i <= 1000000; i+=100000, j++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = i.ToString();
                Generate(i);
                timer.Restart();
                LinqMethod(data);
                timer.Stop();
                chart1.Series[0].Points.AddXY(i, timer.ElapsedMilliseconds);
                dataGridView1.Rows[j].Cells[1].Value = timer.ElapsedMilliseconds.ToString() + " мс";
                timer.Restart();
                PLinqMethod(data);
                timer.Stop();
                chart1.Series[1].Points.AddXY(i, timer.ElapsedMilliseconds);
                dataGridView1.Rows[j].Cells[2].Value = timer.ElapsedMilliseconds.ToString() + " мс";
                timer.Restart();
                MyMethod1(data);
                timer.Stop();
                chart1.Series[2].Points.AddXY(i, timer.ElapsedMilliseconds);
                dataGridView1.Rows[j].Cells[3].Value = timer.ElapsedMilliseconds.ToString() + " мс";
                timer.Restart();
                MyMethod2(data);
                timer.Stop();
                chart1.Series[3].Points.AddXY(i, timer.ElapsedMilliseconds);
                dataGridView1.Rows[j].Cells[4].Value = timer.ElapsedMilliseconds.ToString() + " мс";
            }
        }
    }
}
