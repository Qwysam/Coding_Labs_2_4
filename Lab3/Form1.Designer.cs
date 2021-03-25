
namespace Lab3
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
            this.dgV = new System.Windows.Forms.DataGridView();
            this.variable_N = new System.Windows.Forms.TextBox();
            this.variable_B = new System.Windows.Forms.TextBox();
            this.variable_A = new System.Windows.Forms.TextBox();
            this.variable_C = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.label_default_array = new System.Windows.Forms.Label();
            this.textBox_array = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_write_F1 = new System.Windows.Forms.Button();
            this.button_read_F2 = new System.Windows.Forms.Button();
            this.button_read_F1 = new System.Windows.Forms.Button();
            this.button_write_F2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgV
            // 
            this.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV.Location = new System.Drawing.Point(12, 136);
            this.dgV.Name = "dgV";
            this.dgV.RowHeadersWidth = 82;
            this.dgV.RowTemplate.Height = 33;
            this.dgV.Size = new System.Drawing.Size(524, 682);
            this.dgV.TabIndex = 0;
            // 
            // variable_N
            // 
            this.variable_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.variable_N.Location = new System.Drawing.Point(215, 23);
            this.variable_N.Name = "variable_N";
            this.variable_N.Size = new System.Drawing.Size(150, 38);
            this.variable_N.TabIndex = 1;
            this.variable_N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_N_KeyPress);
            // 
            // variable_B
            // 
            this.variable_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.variable_B.Location = new System.Drawing.Point(785, 23);
            this.variable_B.Name = "variable_B";
            this.variable_B.Size = new System.Drawing.Size(150, 38);
            this.variable_B.TabIndex = 2;
            this.variable_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_B_KeyPress);
            // 
            // variable_A
            // 
            this.variable_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.variable_A.Location = new System.Drawing.Point(500, 23);
            this.variable_A.Name = "variable_A";
            this.variable_A.Size = new System.Drawing.Size(150, 38);
            this.variable_A.TabIndex = 3;
            this.variable_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_A_KeyPress);
            // 
            // variable_C
            // 
            this.variable_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.variable_C.Location = new System.Drawing.Point(1070, 23);
            this.variable_C.Name = "variable_C";
            this.variable_C.Size = new System.Drawing.Size(150, 38);
            this.variable_C.TabIndex = 4;
            this.variable_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_C_KeyPress);
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_N.Location = new System.Drawing.Point(160, 23);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(34, 31);
            this.label_N.TabIndex = 5;
            this.label_N.Text = "N";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_A.Location = new System.Drawing.Point(445, 23);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(32, 31);
            this.label_A.TabIndex = 6;
            this.label_A.Text = "A";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_B.Location = new System.Drawing.Point(730, 23);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(32, 31);
            this.label_B.TabIndex = 7;
            this.label_B.Text = "B";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_C.Location = new System.Drawing.Point(1015, 23);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(34, 31);
            this.label_C.TabIndex = 8;
            this.label_C.Text = "C";
            // 
            // label_default_array
            // 
            this.label_default_array.AutoSize = true;
            this.label_default_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_default_array.Location = new System.Drawing.Point(12, 80);
            this.label_default_array.Name = "label_default_array";
            this.label_default_array.Size = new System.Drawing.Size(239, 31);
            this.label_default_array.TabIndex = 9;
            this.label_default_array.Text = "Исходный массив";
            // 
            // textBox_array
            // 
            this.textBox_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_array.Location = new System.Drawing.Point(276, 83);
            this.textBox_array.Name = "textBox_array";
            this.textBox_array.ReadOnly = true;
            this.textBox_array.Size = new System.Drawing.Size(1153, 38);
            this.textBox_array.TabIndex = 10;
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_generate.Location = new System.Drawing.Point(649, 136);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(230, 55);
            this.button_generate.TabIndex = 11;
            this.button_generate.Text = "Генерировать";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_write_F1
            // 
            this.button_write_F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_write_F1.Location = new System.Drawing.Point(649, 292);
            this.button_write_F1.Name = "button_write_F1";
            this.button_write_F1.Size = new System.Drawing.Size(230, 55);
            this.button_write_F1.TabIndex = 12;
            this.button_write_F1.Text = "Записать F1";
            this.button_write_F1.UseVisualStyleBackColor = true;
            this.button_write_F1.Click += new System.EventHandler(this.button_write_F1_Click);
            // 
            // button_read_F2
            // 
            this.button_read_F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_read_F2.Location = new System.Drawing.Point(649, 763);
            this.button_read_F2.Name = "button_read_F2";
            this.button_read_F2.Size = new System.Drawing.Size(230, 55);
            this.button_read_F2.TabIndex = 13;
            this.button_read_F2.Text = "Считать F2";
            this.button_read_F2.UseVisualStyleBackColor = true;
            this.button_read_F2.Click += new System.EventHandler(this.button_read_F2_Click);
            // 
            // button_read_F1
            // 
            this.button_read_F1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_read_F1.Location = new System.Drawing.Point(649, 604);
            this.button_read_F1.Name = "button_read_F1";
            this.button_read_F1.Size = new System.Drawing.Size(230, 55);
            this.button_read_F1.TabIndex = 14;
            this.button_read_F1.Text = "Считать F1";
            this.button_read_F1.UseVisualStyleBackColor = true;
            this.button_read_F1.Click += new System.EventHandler(this.button_read_F1_Click);
            // 
            // button_write_F2
            // 
            this.button_write_F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_write_F2.Location = new System.Drawing.Point(649, 448);
            this.button_write_F2.Name = "button_write_F2";
            this.button_write_F2.Size = new System.Drawing.Size(230, 55);
            this.button_write_F2.TabIndex = 15;
            this.button_write_F2.Text = "Записать F2";
            this.button_write_F2.UseVisualStyleBackColor = true;
            this.button_write_F2.Click += new System.EventHandler(this.button_write_F2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(1070, 146);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(194, 35);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Операция 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton2.Location = new System.Drawing.Point(1070, 302);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(194, 35);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Операция 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton3.Location = new System.Drawing.Point(1070, 458);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(194, 35);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Операция 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton4.Location = new System.Drawing.Point(1070, 614);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(194, 35);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Операция 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 830);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button_write_F2);
            this.Controls.Add(this.button_read_F1);
            this.Controls.Add(this.button_read_F2);
            this.Controls.Add(this.button_write_F1);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_array);
            this.Controls.Add(this.label_default_array);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.variable_C);
            this.Controls.Add(this.variable_A);
            this.Controls.Add(this.variable_B);
            this.Controls.Add(this.variable_N);
            this.Controls.Add(this.dgV);
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgV;
        private System.Windows.Forms.TextBox variable_N;
        private System.Windows.Forms.TextBox variable_B;
        private System.Windows.Forms.TextBox variable_A;
        private System.Windows.Forms.TextBox variable_C;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_default_array;
        private System.Windows.Forms.TextBox textBox_array;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_write_F1;
        private System.Windows.Forms.Button button_read_F2;
        private System.Windows.Forms.Button button_read_F1;
        private System.Windows.Forms.Button button_write_F2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

