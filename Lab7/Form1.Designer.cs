namespace tp_lab_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agr_C = new System.Windows.Forms.ComboBox();
            this.Group_C = new System.Windows.Forms.ComboBox();
            this.Sort_C = new System.Windows.Forms.ComboBox();
            this.Filtration_C = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_author = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Agr_C);
            this.groupBox1.Controls.Add(this.Group_C);
            this.groupBox1.Controls.Add(this.Sort_C);
            this.groupBox1.Controls.Add(this.Filtration_C);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(626, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ling запросы";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(440, 178);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 44);
            this.button6.TabIndex = 11;
            this.button6.Text = "Выполнить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(440, 127);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "Выполнить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 78);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Агрегация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Группировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фильтрация";
            // 
            // Agr_C
            // 
            this.Agr_C.FormattingEnabled = true;
            this.Agr_C.Items.AddRange(new object[] {
            "Средний балл последовательности студентов",
            "Минимальный год рождения",
            "Максимальный год рождения",
            "Количество студентов родившихся летом"});
            this.Agr_C.Location = new System.Drawing.Point(156, 180);
            this.Agr_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Agr_C.Name = "Agr_C";
            this.Agr_C.Size = new System.Drawing.Size(253, 33);
            this.Agr_C.TabIndex = 4;
            this.Agr_C.Text = "Выберите значение...";
            // 
            // Group_C
            // 
            this.Group_C.FormattingEnabled = true;
            this.Group_C.Items.AddRange(new object[] {
            "По группе",
            "По году рождения",
            "По стипендии"});
            this.Group_C.Location = new System.Drawing.Point(156, 131);
            this.Group_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Group_C.Name = "Group_C";
            this.Group_C.Size = new System.Drawing.Size(253, 33);
            this.Group_C.TabIndex = 3;
            this.Group_C.Text = "Выберите значение...";
            // 
            // Sort_C
            // 
            this.Sort_C.FormattingEnabled = true;
            this.Sort_C.Items.AddRange(new object[] {
            "По фамилии",
            "По длине имени",
            "По среднему баллу"});
            this.Sort_C.Location = new System.Drawing.Point(156, 83);
            this.Sort_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sort_C.Name = "Sort_C";
            this.Sort_C.Size = new System.Drawing.Size(253, 33);
            this.Sort_C.TabIndex = 2;
            this.Sort_C.Text = "Выберите значение...";
            // 
            // Filtration_C
            // 
            this.Filtration_C.FormattingEnabled = true;
            this.Filtration_C.Items.AddRange(new object[] {
            "Имена больше 6 букв",
            "Рожденные до 2001 года",
            "Первые 3 студента со средним баллом больше 90",
            "Студенты 525 группы со стипендией"});
            this.Filtration_C.Location = new System.Drawing.Point(156, 34);
            this.Filtration_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Filtration_C.Name = "Filtration_C";
            this.Filtration_C.Size = new System.Drawing.Size(253, 33);
            this.Filtration_C.TabIndex = 1;
            this.Filtration_C.Text = "Выберите значение...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 88);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сравнение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_author
            // 
            this.button_author.Location = new System.Drawing.Point(450, 325);
            this.button_author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_author.Name = "button_author";
            this.button_author.Size = new System.Drawing.Size(194, 88);
            this.button_author.TabIndex = 3;
            this.button_author.Text = "Автор";
            this.button_author.UseVisualStyleBackColor = true;
            this.button_author.Click += new System.EventHandler(this.button_author_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(663, 431);
            this.Controls.Add(this.button_author);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Agr_C;
        private System.Windows.Forms.ComboBox Group_C;
        private System.Windows.Forms.ComboBox Sort_C;
        private System.Windows.Forms.ComboBox Filtration_C;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_author;
    }
}

