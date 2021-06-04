using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace tp_lab_7
{
    public partial class Form1 : Form
    {
        public Form2 res;

        public Form3 comp;

        public Student[] arr = new Student[10];

        public string[] names = new string[10] { "Иван", "Филипп", "Артем", "Макар", "Ольга", "Анастасия", "Ян", "Кристина", "Богдан", "Юлия" };

        public string[] surnames = new string[10] { "Воронков", "Жуков", "Блохин", "Новодворский", "Овсянникова",
            "Матвиенко", "Непомнящий", "Петрова", "Черных", "Шевцова" };

        public string[] patronymics = new string[10] { "Александрович", "Михайлович", "Сергеевич", "Викторович", "Олеговна",
            "Захаровна", "Алекснадрович", "Ивановна", "Вячеславович", "Геннадиевна" };

        public uint[] grants = new uint[4] { 0, 1420, 1170, 1990 };

        public string[] groups = new string[3] { "525", "515", "535"};

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student[] st = new Student[arr.Length];
            switch (Filtration_C.SelectedIndex)
            {
                case 0:
                    {
                        st = arr.Where(s => s.name.Length > 6).ToArray();
                        break;
                    }
                case 1:
                    {
                        st = arr.Where(s => s.birth.Year < 2001).ToArray();
                        break;
                    }
                case 2:
                    {
                        st = arr.Where(s => s.mark > 90).Take(3).ToArray();
                        break;
                    }
                case 3:
                    {
                        st = arr.Where(s => s.group == "525" && s.grant!=0).ToArray();
                        break;
                    }
            }
            res = new Form2(arr);
            res.Filtration(st, label1.Text + "(" + Filtration_C.Text + ")");
            res.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Student[] st = new Student[arr.Length];
            switch (Sort_C.SelectedIndex)
            {
                case 0:
                    {
                        st = arr.OrderBy(s=>s.surname).ToArray();
                        break;
                    }
                case 1:
                    {
                        st = arr.OrderBy(s => s.name.Length).ToArray();
                        break;
                    }
                case 2:
                    {
                        st = arr.OrderBy(s => s.mark).ToArray();
                        break;
                    }
            }
            res = new Form2(arr);
            res.Sorting(st, label1.Text + "(" + Sort_C.Text + ")");
            res.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Student[] st = new Student[arr.Length];
            res = new Form2(arr);
            switch (Group_C.SelectedIndex)
            {
                case 0:
                    {
                        var gr = arr.GroupBy(m => m.mark).OrderBy(n => n.Key);
                        string s = "";
                        foreach (var re in gr)
                        {
                            s += "Группа: " + re.Key.ToString() + "\r\n";
                            foreach (var r in re)
                            {
                                s += r.ToString();
                            }
                        }
                        res.Grouping(s, label1.Text + "(" + Group_C.Text + ")");
                        res.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        var gr = arr.GroupBy(m => m.birth.Year).OrderBy(n => n.Key);
                        string s = "";
                        foreach (var re in gr)
                        {
                            s += "Год рождения: " + re.Key.ToString() + "\r\n";
                            foreach (var r in re)
                            {
                                s += r.ToString();
                            }
                        }
                        res.Grouping(s, label1.Text + "(" + Group_C.Text + ")");
                        res.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        var gr = arr.GroupBy(m => m.grant).OrderBy(n => n.Key);
                        string s = "";
                        foreach (var re in gr)
                        {
                            s += "Стипендия: " + re.Key.ToString() + " грн" + "\r\n";
                            foreach (var r in re)
                            {
                                s += r.ToString();
                            }
                        }
                        res.Grouping(s, label1.Text + "(" + Group_C.Text + ")");
                        res.ShowDialog();
                        break;
                    }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = "";
            switch (Agr_C.SelectedIndex)
            {
                case 0:
                    {
                        s = "Средний балл: " + arr.Average(n => n.mark).ToString();
                        break;
                    }
                case 1:
                    {
                        s = "Минимальный год рождения: " + arr.Min(n => n.birth.Year).ToString();
                        break;
                    }
                case 2:
                    {
                        s = "Минимальный год рождения: " + arr.Max(n => n.birth.Year).ToString();
                        break;
                    }
                case 3:
                    {
                        s = "Студентов родившихся летом: " + arr.Count(n => n.birth.Month > 5 && n.birth.Month < 9).ToString();
                        break;
                    }
            }
            res = new Form2(arr);
            res.Agr(s, label1.Text + "(" + Agr_C.Text + ")");
            res.ShowDialog();
        }

        public void Generate()
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            for(int i = 0; i < 10; i++)
            {
                arr[i] = new Student((uint)i, surnames[i], names[i], patronymics[i],
                    new DateTime(r.Next(1999, 2004), r.Next(1, 12), r.Next(1, 28)), groups[r.Next(3)], 
                    r.Next(70, 100) + r.NextDouble(), grants[r.Next(4)]);
            }
            XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
            using (FileStream fs = new FileStream("Students.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, arr);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comp = new Form3();
            comp.ChartFiller();
            comp.ShowDialog();
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Text = "Автор";
            f.ShowDialog();
        }
    }

    public class Student
    {
        public uint id;
        public string surname;
        public string name;
        public string patronymic;
        public DateTime birth;
        public string group;
        public double mark;
        public uint grant;

        public Student()
        {

        }

        public Student(uint id, string surname, string name, string patronymic, DateTime birth, string group, double mark, uint grant)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.birth = birth;
            this.group = group;
            this.mark = mark;
            this.grant = grant;
        }

        public override string ToString()
        {
            return "Идентификационный номер: " + id.ToString() + "\r\n" + "Фамилия: " + surname.ToString() +
                "\r\n" + "Имя: " + name.ToString() + "\r\n" + "Отчетсво: " + patronymic.ToString() + "\r\n" +
                "Дата рождения: " + birth.ToString("d") + "\r\n" + "Группа: " + group.ToString() + "\r\n" +
                "Средний балл: " + mark.ToString("F2") + "\r\n" + "Стипендия: " + grant.ToString() + " грн";
        }
    }
}
