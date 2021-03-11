using System.Windows.Forms;
namespace Lab2
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
            this.variable_a = new System.Windows.Forms.TextBox();
            this.variable_b = new System.Windows.Forms.TextBox();
            this.variable_c = new System.Windows.Forms.TextBox();
            this.First_Method = new System.Windows.Forms.RadioButton();
            this.Second_Method = new System.Windows.Forms.RadioButton();
            this.Third_Method = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // variable_a
            // 
            this.variable_a.Location = new System.Drawing.Point(62, 115);
            this.variable_a.Margin = new System.Windows.Forms.Padding(6);
            this.variable_a.Name = "variable_a";
            this.variable_a.Size = new System.Drawing.Size(196, 31);
            this.variable_a.TabIndex = 0;
            this.variable_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_a_KeyPress);
            // 
            // variable_b
            // 
            this.variable_b.Location = new System.Drawing.Point(62, 202);
            this.variable_b.Margin = new System.Windows.Forms.Padding(6);
            this.variable_b.Name = "variable_b";
            this.variable_b.Size = new System.Drawing.Size(196, 31);
            this.variable_b.TabIndex = 1;
            this.variable_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_b_KeyPress);
            // 
            // variable_c
            // 
            this.variable_c.Location = new System.Drawing.Point(62, 288);
            this.variable_c.Margin = new System.Windows.Forms.Padding(6);
            this.variable_c.Name = "variable_c";
            this.variable_c.Size = new System.Drawing.Size(196, 31);
            this.variable_c.TabIndex = 2;
            this.variable_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variable_c_KeyPress);
            // 
            // First_Method
            // 
            this.First_Method.AutoSize = true;
            this.First_Method.Checked = true;
            this.First_Method.Location = new System.Drawing.Point(86, 413);
            this.First_Method.Name = "First_Method";
            this.First_Method.Size = new System.Drawing.Size(125, 29);
            this.First_Method.TabIndex = 3;
            this.First_Method.TabStop = true;
            this.First_Method.Text = "Метод 1";
            this.First_Method.UseVisualStyleBackColor = true;
            // 
            // Second_Method
            // 
            this.Second_Method.AutoSize = true;
            this.Second_Method.Location = new System.Drawing.Point(86, 471);
            this.Second_Method.Name = "Second_Method";
            this.Second_Method.Size = new System.Drawing.Size(125, 29);
            this.Second_Method.TabIndex = 4;
            this.Second_Method.Text = "Метод 2";
            this.Second_Method.UseVisualStyleBackColor = true;
            // 
            // Third_Method
            // 
            this.Third_Method.AutoSize = true;
            this.Third_Method.Location = new System.Drawing.Point(86, 528);
            this.Third_Method.Name = "Third_Method";
            this.Third_Method.Size = new System.Drawing.Size(125, 29);
            this.Third_Method.TabIndex = 5;
            this.Third_Method.Text = "Метод 3";
            this.Third_Method.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(13, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "c";
            // 
            // Run
            // 
            this.Run.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Run.Location = new System.Drawing.Point(410, 413);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(184, 56);
            this.Run.TabIndex = 9;
            this.Run.Text = "Запустить";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Clear
            // 
            this.Clear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Clear.Location = new System.Drawing.Point(410, 501);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(184, 56);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(398, 115);
            this.x1.Margin = new System.Windows.Forms.Padding(6);
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            this.x1.Size = new System.Drawing.Size(196, 31);
            this.x1.TabIndex = 11;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(398, 202);
            this.x2.Margin = new System.Windows.Forms.Padding(6);
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            this.x2.Size = new System.Drawing.Size(196, 31);
            this.x2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(346, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "x1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(346, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "x2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(659, 608);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Third_Method);
            this.Controls.Add(this.Second_Method);
            this.Controls.Add(this.First_Method);
            this.Controls.Add(this.variable_c);
            this.Controls.Add(this.variable_b);
            this.Controls.Add(this.variable_a);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variable_a;
        private System.Windows.Forms.TextBox variable_b;
        private System.Windows.Forms.TextBox variable_c;
        private System.Windows.Forms.RadioButton First_Method;
        private System.Windows.Forms.RadioButton Second_Method;
        private System.Windows.Forms.RadioButton Third_Method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Clear;
        private TextBox x1;
        private TextBox x2;
        private Label label4;
        private Label label5;
    }
}

