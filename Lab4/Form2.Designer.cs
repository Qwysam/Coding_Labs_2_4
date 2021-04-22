using System.Windows.Forms;

namespace Lab4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.N1 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.TextBox();
            this.Generate_Matrix = new System.Windows.Forms.Button();
            this.Matrix = new System.Windows.Forms.DataGridView();
            this.Op_number = new System.Windows.Forms.TextBox();
            this.Save_Matrix = new System.Windows.Forms.Button();
            this.Read_Matrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Operations = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.element_b = new System.Windows.Forms.TextBox();
            this.save_res = new System.Windows.Forms.Button();
            this.read_res = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // N1
            // 
            this.N1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.N1.Location = new System.Drawing.Point(328, 29);
            this.N1.Margin = new System.Windows.Forms.Padding(6);
            this.N1.Name = "N1";
            this.N1.ReadOnly = true;
            this.N1.Size = new System.Drawing.Size(196, 31);
            this.N1.TabIndex = 1;
            // 
            // A1
            // 
            this.A1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.A1.Location = new System.Drawing.Point(328, 79);
            this.A1.Margin = new System.Windows.Forms.Padding(6);
            this.A1.Name = "A1";
            this.A1.ReadOnly = true;
            this.A1.Size = new System.Drawing.Size(196, 31);
            this.A1.TabIndex = 2;
            // 
            // B1
            // 
            this.B1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.B1.Location = new System.Drawing.Point(328, 129);
            this.B1.Margin = new System.Windows.Forms.Padding(6);
            this.B1.Name = "B1";
            this.B1.ReadOnly = true;
            this.B1.Size = new System.Drawing.Size(196, 31);
            this.B1.TabIndex = 3;
            // 
            // Generate_Matrix
            // 
            this.Generate_Matrix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Generate_Matrix.Location = new System.Drawing.Point(40, 570);
            this.Generate_Matrix.Margin = new System.Windows.Forms.Padding(6);
            this.Generate_Matrix.Name = "Generate_Matrix";
            this.Generate_Matrix.Size = new System.Drawing.Size(484, 84);
            this.Generate_Matrix.TabIndex = 4;
            this.Generate_Matrix.Text = "Генерация матрицы";
            this.Generate_Matrix.UseVisualStyleBackColor = true;
            this.Generate_Matrix.Click += new System.EventHandler(this.Generate_Matrix_Click);
            // 
            // Matrix
            // 
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix.Location = new System.Drawing.Point(540, 23);
            this.Matrix.Margin = new System.Windows.Forms.Padding(6);
            this.Matrix.Name = "Matrix";
            this.Matrix.RowHeadersWidth = 82;
            this.Matrix.Size = new System.Drawing.Size(1034, 763);
            this.Matrix.TabIndex = 5;
            // 
            // Op_number
            // 
            this.Op_number.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Op_number.Location = new System.Drawing.Point(40, 798);
            this.Op_number.Margin = new System.Windows.Forms.Padding(6);
            this.Op_number.Name = "Op_number";
            this.Op_number.ReadOnly = true;
            this.Op_number.Size = new System.Drawing.Size(1534, 31);
            this.Op_number.TabIndex = 6;
            // 
            // Save_Matrix
            // 
            this.Save_Matrix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Save_Matrix.Location = new System.Drawing.Point(40, 250);
            this.Save_Matrix.Margin = new System.Windows.Forms.Padding(6);
            this.Save_Matrix.Name = "Save_Matrix";
            this.Save_Matrix.Size = new System.Drawing.Size(484, 68);
            this.Save_Matrix.TabIndex = 7;
            this.Save_Matrix.Text = "Сохранить класс в файл";
            this.Save_Matrix.UseVisualStyleBackColor = true;
            this.Save_Matrix.Click += new System.EventHandler(this.Save_Matrix_Click);
            // 
            // Read_Matrix
            // 
            this.Read_Matrix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Read_Matrix.Location = new System.Drawing.Point(40, 330);
            this.Read_Matrix.Margin = new System.Windows.Forms.Padding(6);
            this.Read_Matrix.Name = "Read_Matrix";
            this.Read_Matrix.Size = new System.Drawing.Size(484, 68);
            this.Read_Matrix.TabIndex = 8;
            this.Read_Matrix.Text = "Считать класс из файла";
            this.Read_Matrix.UseVisualStyleBackColor = true;
            this.Read_Matrix.Click += new System.EventHandler(this.Read_Matrix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Размерность массива N=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Минимальная граница A=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Максимальная граница B=";
            // 
            // Operations
            // 
            this.Operations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Operations.Location = new System.Drawing.Point(40, 707);
            this.Operations.Margin = new System.Windows.Forms.Padding(6);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(484, 79);
            this.Operations.TabIndex = 12;
            this.Operations.Text = "Выполнение выбранной операции";
            this.Operations.UseVisualStyleBackColor = true;
            this.Operations.Click += new System.EventHandler(this.Operations_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(40, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Элемент b=";
            // 
            // element_b
            // 
            this.element_b.ForeColor = System.Drawing.SystemColors.Highlight;
            this.element_b.Location = new System.Drawing.Point(182, 179);
            this.element_b.Margin = new System.Windows.Forms.Padding(6);
            this.element_b.Name = "element_b";
            this.element_b.ReadOnly = true;
            this.element_b.Size = new System.Drawing.Size(342, 31);
            this.element_b.TabIndex = 14;
            // 
            // save_res
            // 
            this.save_res.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save_res.Location = new System.Drawing.Point(40, 410);
            this.save_res.Margin = new System.Windows.Forms.Padding(6);
            this.save_res.Name = "save_res";
            this.save_res.Size = new System.Drawing.Size(484, 68);
            this.save_res.TabIndex = 15;
            this.save_res.Text = "Сохранить результат в файл";
            this.save_res.UseVisualStyleBackColor = true;
            this.save_res.Click += new System.EventHandler(this.save_res_Click);
            // 
            // read_res
            // 
            this.read_res.ForeColor = System.Drawing.SystemColors.ControlText;
            this.read_res.Location = new System.Drawing.Point(40, 490);
            this.read_res.Margin = new System.Windows.Forms.Padding(6);
            this.read_res.Name = "read_res";
            this.read_res.Size = new System.Drawing.Size(484, 68);
            this.read_res.TabIndex = 16;
            this.read_res.Text = "Считать результат из файла";
            this.read_res.UseVisualStyleBackColor = true;
            this.read_res.Click += new System.EventHandler(this.read_res_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1609, 844);
            this.Controls.Add(this.read_res);
            this.Controls.Add(this.save_res);
            this.Controls.Add(this.element_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Read_Matrix);
            this.Controls.Add(this.Save_Matrix);
            this.Controls.Add(this.Op_number);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.Generate_Matrix);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.N1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Вычисления";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox N1;
        public System.Windows.Forms.TextBox A1;
        public System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.Button Generate_Matrix;
        private System.Windows.Forms.DataGridView Matrix;
        public System.Windows.Forms.TextBox Op_number;
        private System.Windows.Forms.Button Save_Matrix;
        private System.Windows.Forms.Button Read_Matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Operations;
        private Label label4;
        public TextBox element_b;
        private Button save_res;
        private Button read_res;
    }
}
