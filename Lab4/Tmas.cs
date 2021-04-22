using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Linq;

namespace Lab4
{
    public class Tmas
    {
        public int[,] FA { get; set; }
        public int [] flattened_matr
        {
            get { return To1DArray(FA); }
            set { FA = Make2DArray(value, value.Length); }
        }
        public int[,] res { get; set; }
        public int[] flattened_res
        {
            get { return To1DArray(res); }
            set { res = Make2DArray(value, value.Length); }
        }
        public Tmas() { }
        bool CheckIndex(int i, int j)
        {
            if ((i < FA.GetLength(0) && i >= 0) && (j < FA.GetLength(0) && j >= 0))
                return true;
            else
                return false;
        }
        public void GenerateMatrix(int min, int max, int size)
        {
            FA = new int[size, size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    FA[i, j] = r.Next(min, max);
        }
        public int[] ReadMatrix()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML Files|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(int[]));
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    return (int[])formatter.Deserialize(fs);
                }
            }
            else
                return null;
        }
        public void WriteMatrix(int[] arr)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xml";
            sfd.Filter = "XML Files|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(int[]));
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs,arr);
                }
                MessageBox.Show("Файл сохранен");
            }
        }

        public void SortColumns()
        {
            int size = FA.GetLength(0);
            int[,] tmp = new int[size,size];
            Array.Copy(FA, tmp,FA.Length);
            for (int k = 0; k < size;k++) {
                for (int j = 0; j <= size - 2; j++)
                {
                    for (int i = 0; i <= size - 2; i++)
                    {
                        if (tmp[i,k] < tmp[i + 1,k])
                        {
                            int t = tmp[i + 1,k];
                            tmp[i + 1,k] = tmp[i,k];
                            tmp[i,k] = t;
                        }
                    }
                }
            }
            res = new int[size, size];
            Array.Copy(tmp, res, tmp.Length);
        }

        int[,] Make2DArray(int[] input, int size)
        {
            int height = (int)Math.Sqrt(size);
            int width = height;
            int[,] output = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[i, j] = input[i * width + j];
                }
            }
            return output;
        }

        int[] To1DArray(int[,] input)
        {
            // Step 1: get total size of 2D array, and allocate 1D array.
            int size = input.Length;
            int[] result = new int[size];

            // Step 2: copy 2D array elements into a 1D array.
            int write = 0;
            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                for (int z = 0; z <= input.GetUpperBound(1); z++)
                {
                    result[write++] = input[i, z];
                }
            }
            // Step 3: return the new array.
            return result;
        }
    }
}
