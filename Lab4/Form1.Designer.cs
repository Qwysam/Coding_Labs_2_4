using System.Windows.Forms;
namespace Lab4
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.element_b = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Op_3 = new System.Windows.Forms.RadioButton();
            this.Op_2 = new System.Windows.Forms.RadioButton();
            this.Op_1 = new System.Windows.Forms.RadioButton();
            this.Close = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Button();
            this.OpenForm2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.element_b);
            this.groupBox1.Controls.Add(this.N);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(28, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(690, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(26, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Элемент b";
            // 
            // element_b
            // 
            this.element_b.Location = new System.Drawing.Point(532, 405);
            this.element_b.Margin = new System.Windows.Forms.Padding(6);
            this.element_b.Name = "element_b";
            this.element_b.Size = new System.Drawing.Size(105, 50);
            this.element_b.TabIndex = 6;
            this.element_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.element_b_KeyPress);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(532, 103);
            this.N.Margin = new System.Windows.Forms.Padding(6);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(105, 50);
            this.N.TabIndex = 5;
            this.N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(532, 205);
            this.A.Margin = new System.Windows.Forms.Padding(6);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(105, 50);
            this.A.TabIndex = 4;
            this.A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(26, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Максимальная граница B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Минимальная граница A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размерность массива N";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(532, 307);
            this.B.Margin = new System.Windows.Forms.Padding(6);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(105, 50);
            this.B.TabIndex = 1;
            this.B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.B_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Op_3);
            this.groupBox2.Controls.Add(this.Op_2);
            this.groupBox2.Controls.Add(this.Op_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(738, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(690, 554);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // Op_3
            // 
            this.Op_3.AutoSize = true;
            this.Op_3.Location = new System.Drawing.Point(25, 405);
            this.Op_3.Margin = new System.Windows.Forms.Padding(6);
            this.Op_3.Name = "Op_3";
            this.Op_3.Size = new System.Drawing.Size(538, 92);
            this.Op_3.TabIndex = 2;
            this.Op_3.TabStop = true;
            this.Op_3.Text = "Вычесть из всех элементов\r\nмассива элемент b";
            this.Op_3.UseVisualStyleBackColor = true;
            // 
            // Op_2
            // 
            this.Op_2.AutoSize = true;
            this.Op_2.Location = new System.Drawing.Point(25, 209);
            this.Op_2.Margin = new System.Windows.Forms.Padding(6);
            this.Op_2.Name = "Op_2";
            this.Op_2.Size = new System.Drawing.Size(635, 180);
            this.Op_2.TabIndex = 1;
            this.Op_2.TabStop = true;
            this.Op_2.Text = "Отсортировать элементы\r\nстолбцов массива по убыванию, \r\nпредставить их в\r\nквадрат" +
    "ном массиве";
            this.Op_2.UseVisualStyleBackColor = true;
            // 
            // Op_1
            // 
            this.Op_1.AutoSize = true;
            this.Op_1.Location = new System.Drawing.Point(25, 105);
            this.Op_1.Margin = new System.Windows.Forms.Padding(6);
            this.Op_1.Name = "Op_1";
            this.Op_1.Size = new System.Drawing.Size(553, 92);
            this.Op_1.TabIndex = 0;
            this.Op_1.TabStop = true;
            this.Op_1.Text = "Определить максимальный \r\nэлемент массива";
            this.Op_1.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Close.Location = new System.Drawing.Point(28, 653);
            this.Close.Margin = new System.Windows.Forms.Padding(6);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(144, 87);
            this.Close.TabIndex = 2;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Author.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Author.Location = new System.Drawing.Point(1168, 653);
            this.Author.Margin = new System.Windows.Forms.Padding(6);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(260, 87);
            this.Author.TabIndex = 5;
            this.Author.Text = "Об авторе";
            this.Author.UseVisualStyleBackColor = true;
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // OpenForm2
            // 
            this.OpenForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenForm2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OpenForm2.Location = new System.Drawing.Point(506, 653);
            this.OpenForm2.Margin = new System.Windows.Forms.Padding(6);
            this.OpenForm2.Name = "OpenForm2";
            this.OpenForm2.Size = new System.Drawing.Size(212, 87);
            this.OpenForm2.TabIndex = 6;
            this.OpenForm2.Text = "Вычисления";
            this.OpenForm2.UseVisualStyleBackColor = true;
            this.OpenForm2.Click += new System.EventHandler(this.OpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1453, 755);
            this.Controls.Add(this.OpenForm2);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Ввод данных и выбор операции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Op_3;
        private System.Windows.Forms.RadioButton Op_2;
        private System.Windows.Forms.RadioButton Op_1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Author;
        public System.Windows.Forms.TextBox B;
        public System.Windows.Forms.TextBox N;
        public System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox element_b;
        private Button OpenForm2;
    }
}

