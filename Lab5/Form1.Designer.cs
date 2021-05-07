namespace Lab5
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Histogram = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Pie_Chart = new System.Windows.Forms.RadioButton();
            this.button_Open_Form2 = new System.Windows.Forms.Button();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.button_generate_array = new System.Windows.Forms.Button();
            this.button_sort_array = new System.Windows.Forms.Button();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.button_Form3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(17, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число значений на диаграмме";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(633, 657);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Histogram
            // 
            this.Histogram.AutoSize = true;
            this.Histogram.Location = new System.Drawing.Point(21, 469);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(174, 29);
            this.Histogram.TabIndex = 3;
            this.Histogram.TabStop = true;
            this.Histogram.Text = "Гистограмма";
            this.Histogram.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вид диаграммы";
            // 
            // Pie_Chart
            // 
            this.Pie_Chart.AutoSize = true;
            this.Pie_Chart.Location = new System.Drawing.Point(21, 520);
            this.Pie_Chart.Name = "Pie_Chart";
            this.Pie_Chart.Size = new System.Drawing.Size(250, 29);
            this.Pie_Chart.TabIndex = 5;
            this.Pie_Chart.TabStop = true;
            this.Pie_Chart.Text = "Круговая диаграмма";
            this.Pie_Chart.UseVisualStyleBackColor = true;
            // 
            // button_Open_Form2
            // 
            this.button_Open_Form2.Location = new System.Drawing.Point(22, 578);
            this.button_Open_Form2.Name = "button_Open_Form2";
            this.button_Open_Form2.Size = new System.Drawing.Size(240, 74);
            this.button_Open_Form2.TabIndex = 6;
            this.button_Open_Form2.Text = "Сгенерировать диаграмму";
            this.button_Open_Form2.UseVisualStyleBackColor = true;
            this.button_Open_Form2.Click += new System.EventHandler(this.button_Open_Form2_Click);
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(22, 147);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(245, 31);
            this.textBox_min.TabIndex = 7;
            this.textBox_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_min_KeyPress);
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(22, 220);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(245, 31);
            this.textBox_max.TabIndex = 8;
            this.textBox_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_max_KeyPress);
            // 
            // button_generate_array
            // 
            this.button_generate_array.Location = new System.Drawing.Point(19, 268);
            this.button_generate_array.Name = "button_generate_array";
            this.button_generate_array.Size = new System.Drawing.Size(249, 72);
            this.button_generate_array.TabIndex = 9;
            this.button_generate_array.Text = "Генерировать массив";
            this.button_generate_array.UseVisualStyleBackColor = true;
            this.button_generate_array.Click += new System.EventHandler(this.button_generate_array_Click);
            // 
            // button_sort_array
            // 
            this.button_sort_array.Location = new System.Drawing.Point(18, 354);
            this.button_sort_array.Name = "button_sort_array";
            this.button_sort_array.Size = new System.Drawing.Size(249, 54);
            this.button_sort_array.TabIndex = 10;
            this.button_sort_array.Text = "Сортировать массив";
            this.button_sort_array.UseVisualStyleBackColor = true;
            this.button_sort_array.Click += new System.EventHandler(this.button_sort_array_Click);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(17, 119);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(245, 25);
            this.label_max.TabIndex = 11;
            this.label_max.Text = "Минимальный элемент";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(17, 192);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(261, 25);
            this.label_min.TabIndex = 12;
            this.label_min.Text = "Максимальный  элемент";
            // 
            // button_Form3
            // 
            this.button_Form3.Location = new System.Drawing.Point(22, 677);
            this.button_Form3.Name = "button_Form3";
            this.button_Form3.Size = new System.Drawing.Size(240, 74);
            this.button_Form3.TabIndex = 13;
            this.button_Form3.Text = "Автор";
            this.button_Form3.UseVisualStyleBackColor = true;
            this.button_Form3.Click += new System.EventHandler(this.button_Form3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 772);
            this.Controls.Add(this.button_Form3);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.button_sort_array);
            this.Controls.Add(this.button_generate_array);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.button_Open_Form2);
            this.Controls.Add(this.Pie_Chart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton Histogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Pie_Chart;
        private System.Windows.Forms.Button button_Open_Form2;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.Button button_generate_array;
        private System.Windows.Forms.Button button_sort_array;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Button button_Form3;
    }
}

