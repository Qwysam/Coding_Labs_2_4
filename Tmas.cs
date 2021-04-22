using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab4
{
    //class that stores matrix, methods and results
    public class Tmas
    {
        //base matrix
        public int[,] FA { get; set; }
        //1 dimensional version of matrix that converts to and from 2d
        public int [] flattened_matr
        {
            get { return To1DArray(FA); }
            set { FA = Make2DArray(value, value.Length); }
        }
        //stores results of operations
        public int[,] res { get; set; }
        //same as flattened_matr for res
        public int[] flattened_res
        {
            get { return To1DArray(res); }
            set { res = Make2DArray(value, value.Length); }
        }
        //basic constructor
        public Tmas() { }
        //method to check if used index is in bounds
        bool CheckIndex(int i, int j)
        {
            if ((i < FA.GetLength(0) && i >= 0) && (j < FA.GetLength(0) && j >= 0))
                return true;
            else
                return false;
        }
        //generates matrix using set parameters and stores it in field FA
        public void GenerateMatrix(int min, int max, int size)
        {
            FA = new int[size, size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    FA[i, j] = r.Next(min, max);
        }
        //reads onedimensional array from the chosen XML file
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
        //writes onedimensional array to the chosen XML file
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
        //uses bubble sort to put elements in columns in descending order
        public void SortColumns()
        {
            int size = FA.GetLength(0);
            //a cope of main array to avoid changing it
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
        //converts 1d array to matrix
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
        //flattens matrix into a 1d array
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
