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
using System.Text.Json;

namespace Lab3
{
    public partial class Form1 : Form
    {
        CustomArray MyArray = new CustomArray();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button_write_F1.Enabled = false;
            button_write_F2.Enabled = false;
        }

        private void CheckInput(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)||textBox.Text.Length>9) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void variable_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(variable_N, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }

        private void variable_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(variable_A, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }

        private void variable_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(variable_B, sender, e);
            }
            catch(System.FormatException)
            {
            }
        }

        private void variable_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CheckInput(variable_C, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            try
            {
                MyArray.GenerateArray(int.Parse(variable_N.Text),
                    int.Parse(variable_A.Text), int.Parse(variable_B.Text));
                textBox_array.Text = string.Join(" ", MyArray.GetArray());
                dgV.ReadOnly = true;
                if (radioButton1.Checked)
                {
                    MyArray.save_array = new string[4];
                    dgV.ColumnCount = 2;
                    dgV.RowCount = 2;
                    int[] res = MyArray.SumLessAndGreater(MyArray.GetArray()
                        , int.Parse(variable_C.Text));
                    MyArray.save_array[0] = "Меньше";
                    MyArray.save_array[1] = $"{res[0]}";
                    MyArray.save_array[1] = "Больше";
                    MyArray.save_array[2] = $"{res[1]}";
                    dgV[0, 0].Value = "Меньше";
                    dgV[0, 1].Value = "Больше";
                    dgV[1,0].Value = res[0];
                    dgV[1,1].Value = res[1];

                }

                if (radioButton2.Checked)
                {
                    dgV.ColumnCount = 2;
                    int[] res = MyArray.SortArray(MyArray.GetArray());
                    MyArray.save_array = new string[res.Length * 2];
                    dgV[0,0].Value = "i";
                    dgV[1,0].Value= "Value";
                    dgV.RowCount = res.Length+1;
                    for(int i = 0; i < res.Length; i++)
                    {
                        dgV[0, i+1].Value = i;
                        dgV[1, i+1].Value = res[i];
                    }
                    for(int i = 0; i < res.Length * 2; i += 2)
                    {
                        MyArray.save_array[i] = $"{i/2}";
                        MyArray.save_array[i+1] = $"{res[i / 2]}";
                    }
                }

                if (radioButton3.Checked)
                {
                    MyArray.save_array = new string[4];
                    dgV.ColumnCount = 2;
                    dgV.RowCount = 2;
                    dgV[0, 0].Value = "Количество";
                    dgV[0, 1].Value = "Сумма";
                    int[] res = MyArray.SumAndCountEven(MyArray.GetArray(),
                        int.Parse(variable_C.Text));
                    dgV[1, 0].Value = res[1];
                    dgV[1, 1].Value = res[0];
                    MyArray.save_array[0] = "Количество";
                    MyArray.save_array[1] = $"{res[1]}";
                    MyArray.save_array[1] = "Сумма";
                    MyArray.save_array[2] = $"{res[0]}";
                }
                if (radioButton4.Checked)
                {
                    MyArray.save_array = new string[2];
                    dgV.ColumnCount = 1;
                    dgV.RowCount = 2;
                    int res = MyArray.CountPrimes(MyArray.GetArray());
                    dgV[0, 0].Value = "Количество";
                    dgV[0, 1].Value = res;
                    MyArray.save_array[0] = "Количество";
                    MyArray.save_array[1] = $"{res}";
                }

                button_read_F1.Enabled = true;
                button_read_F2.Enabled = true;
                button_write_F1.Enabled = true;
                button_write_F2.Enabled = true;
            }
            catch (System.FormatException exception)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void button_write_F1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    string jsonString = JsonSerializer.Serialize(MyArray.GetArray());
                    myStream.Close();
                    File.WriteAllText(saveFileDialog1.FileName, jsonString);
                }
            }
        }

        private void button_write_F2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    string jsonString = JsonSerializer.Serialize(MyArray.save_array);
                    myStream.Close();
                    File.WriteAllText(saveFileDialog1.FileName, jsonString);
                }
            }
        }

        private void button_read_F1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        MyArray.SetArray(JsonSerializer.Deserialize<int[]>(reader.ReadToEnd()));
                        textBox_array.Text = string.Join(" ", MyArray.GetArray());
                    }
                }
            }
        }

        private void button_read_F2_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        MyArray.save_array = JsonSerializer.Deserialize<string[]>(reader.ReadToEnd());
                        dgV.ColumnCount = 2;
                        dgV.RowCount = MyArray.save_array.Length/2;
                        for (int i = 0; i < MyArray.save_array.Length; i += 2)
                        {
                            dgV[0, i/2].Value = MyArray.save_array[i];
                            dgV[1, i/2].Value = MyArray.save_array[i+1];
                        }
                    }
                }
            }
        }
    }

    public class CustomArray
    {
        public string[] save_array;
        int[] arr;
        public void GenerateArray(int size,int min, int max)
        {
            arr = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = r.Next(min, max);
        }

        public void SetArray(int[] array)
        {
            arr = new int[array.Length];
            Array.Copy(array, arr, array.Length);
        }

        public int[] GetArray()
        {
            return arr;
        }

        public int[]SumLessAndGreater(int[]array,int C)
        {
            int[] sum = new int[2];
            int sum_less = 0, sum_greater = 0;
            for(int i = 1; i < array.Length; i+=2)
            {
                if (array[i] < C)
                    sum_less += array[i];
                if (array[i] > C)
                    sum_greater += array[i];
            }
            sum[0] = sum_less;
            sum[1] = sum_greater;
            return sum;
        }

        public int[] SortArray(int[] array)
        {
            int[] res = new int[array.Length];
            Array.Copy(array,res,array.Length);
            Array.Sort(res);
            return res;
        }

        public int[] SumAndCountEven(int[] array, int C)
        {
            int[] res = new int[2];
            int count = 0, sum = 0;
            for(int i = 2; i < array.Length; i+=2)
            {
                if (array[i] > C)
                {
                    sum += array[i];
                    count++;
                }
            }
            res[0] = sum;
            res[1] = count;
            return res;
        }

        private bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public int CountPrimes(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    if (IsPrimeNumber((uint)array[i]))
                        count++;
            }
            return count;
        }
    }
}
