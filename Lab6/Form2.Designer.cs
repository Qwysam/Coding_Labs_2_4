
namespace AnalogClock
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
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxABackground = new System.Windows.Forms.TextBox();
            this.textBoxAHourHand = new System.Windows.Forms.TextBox();
            this.textBoxAMinuteHand = new System.Windows.Forms.TextBox();
            this.textBoxASecondHand = new System.Windows.Forms.TextBox();
            this.textBoxRSecondHand = new System.Windows.Forms.TextBox();
            this.textBoxRMinuteHand = new System.Windows.Forms.TextBox();
            this.textBoxRHourHand = new System.Windows.Forms.TextBox();
            this.textBoxRBackground = new System.Windows.Forms.TextBox();
            this.textBoxGSecondHand = new System.Windows.Forms.TextBox();
            this.textBoxGMinuteHand = new System.Windows.Forms.TextBox();
            this.textBoxGHourHand = new System.Windows.Forms.TextBox();
            this.textBoxGBackground = new System.Windows.Forms.TextBox();
            this.textBoxBSecondHand = new System.Windows.Forms.TextBox();
            this.textBoxBMinuteHand = new System.Windows.Forms.TextBox();
            this.textBoxBHourHand = new System.Windows.Forms.TextBox();
            this.textBoxBBackground = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(130, 9);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(127, 25);
            this.labelBackground.TabIndex = 0;
            this.labelBackground.Text = "Background";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(306, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(112, 25);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "Hour hand";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(482, 9);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(131, 25);
            this.labelMinute.TabIndex = 2;
            this.labelMinute.Text = "Minute hand";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(658, 9);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(139, 25);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "Second hand";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 50);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 25);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(12, 100);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(27, 25);
            this.labelR.TabIndex = 5;
            this.labelR.Text = "R";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(12, 150);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(28, 25);
            this.labelG.TabIndex = 6;
            this.labelG.Text = "G";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(12, 200);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(26, 25);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "B";
            // 
            // textBoxABackground
            // 
            this.textBoxABackground.Location = new System.Drawing.Point(130, 50);
            this.textBoxABackground.Name = "textBoxABackground";
            this.textBoxABackground.Size = new System.Drawing.Size(122, 31);
            this.textBoxABackground.TabIndex = 8;
            this.textBoxABackground.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAHourHand
            // 
            this.textBoxAHourHand.Location = new System.Drawing.Point(306, 50);
            this.textBoxAHourHand.Name = "textBoxAHourHand";
            this.textBoxAHourHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxAHourHand.TabIndex = 9;
            this.textBoxAHourHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxAMinuteHand
            // 
            this.textBoxAMinuteHand.Location = new System.Drawing.Point(482, 50);
            this.textBoxAMinuteHand.Name = "textBoxAMinuteHand";
            this.textBoxAMinuteHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxAMinuteHand.TabIndex = 10;
            this.textBoxAMinuteHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxASecondHand
            // 
            this.textBoxASecondHand.Location = new System.Drawing.Point(658, 50);
            this.textBoxASecondHand.Name = "textBoxASecondHand";
            this.textBoxASecondHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxASecondHand.TabIndex = 11;
            this.textBoxASecondHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxRSecondHand
            // 
            this.textBoxRSecondHand.Location = new System.Drawing.Point(658, 100);
            this.textBoxRSecondHand.Name = "textBoxRSecondHand";
            this.textBoxRSecondHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxRSecondHand.TabIndex = 15;
            this.textBoxRSecondHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxRMinuteHand
            // 
            this.textBoxRMinuteHand.Location = new System.Drawing.Point(482, 100);
            this.textBoxRMinuteHand.Name = "textBoxRMinuteHand";
            this.textBoxRMinuteHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxRMinuteHand.TabIndex = 14;
            this.textBoxRMinuteHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxRHourHand
            // 
            this.textBoxRHourHand.Location = new System.Drawing.Point(306, 100);
            this.textBoxRHourHand.Name = "textBoxRHourHand";
            this.textBoxRHourHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxRHourHand.TabIndex = 13;
            this.textBoxRHourHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxRBackground
            // 
            this.textBoxRBackground.Location = new System.Drawing.Point(130, 100);
            this.textBoxRBackground.Name = "textBoxRBackground";
            this.textBoxRBackground.Size = new System.Drawing.Size(122, 31);
            this.textBoxRBackground.TabIndex = 12;
            // 
            // textBoxGSecondHand
            // 
            this.textBoxGSecondHand.Location = new System.Drawing.Point(658, 150);
            this.textBoxGSecondHand.Name = "textBoxGSecondHand";
            this.textBoxGSecondHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxGSecondHand.TabIndex = 19;
            this.textBoxGSecondHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxGMinuteHand
            // 
            this.textBoxGMinuteHand.Location = new System.Drawing.Point(482, 150);
            this.textBoxGMinuteHand.Name = "textBoxGMinuteHand";
            this.textBoxGMinuteHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxGMinuteHand.TabIndex = 18;
            this.textBoxGMinuteHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxGHourHand
            // 
            this.textBoxGHourHand.Location = new System.Drawing.Point(306, 150);
            this.textBoxGHourHand.Name = "textBoxGHourHand";
            this.textBoxGHourHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxGHourHand.TabIndex = 17;
            this.textBoxGHourHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxGBackground
            // 
            this.textBoxGBackground.Location = new System.Drawing.Point(130, 150);
            this.textBoxGBackground.Name = "textBoxGBackground";
            this.textBoxGBackground.Size = new System.Drawing.Size(122, 31);
            this.textBoxGBackground.TabIndex = 16;
            this.textBoxGBackground.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxBSecondHand
            // 
            this.textBoxBSecondHand.Location = new System.Drawing.Point(658, 200);
            this.textBoxBSecondHand.Name = "textBoxBSecondHand";
            this.textBoxBSecondHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxBSecondHand.TabIndex = 23;
            this.textBoxBSecondHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxBMinuteHand
            // 
            this.textBoxBMinuteHand.Location = new System.Drawing.Point(482, 200);
            this.textBoxBMinuteHand.Name = "textBoxBMinuteHand";
            this.textBoxBMinuteHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxBMinuteHand.TabIndex = 22;
            this.textBoxBMinuteHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxBHourHand
            // 
            this.textBoxBHourHand.Location = new System.Drawing.Point(306, 200);
            this.textBoxBHourHand.Name = "textBoxBHourHand";
            this.textBoxBHourHand.Size = new System.Drawing.Size(122, 31);
            this.textBoxBHourHand.TabIndex = 21;
            this.textBoxBHourHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxBBackground
            // 
            this.textBoxBBackground.Location = new System.Drawing.Point(130, 200);
            this.textBoxBBackground.Name = "textBoxBBackground";
            this.textBoxBBackground.Size = new System.Drawing.Size(122, 31);
            this.textBoxBBackground.TabIndex = 20;
            this.textBoxBBackground.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(884, 9);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(159, 49);
            this.buttonApply.TabIndex = 24;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(884, 91);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(159, 49);
            this.buttonSaveConfig.TabIndex = 25;
            this.buttonSaveConfig.Text = "Save";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Location = new System.Drawing.Point(884, 176);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(159, 49);
            this.buttonLoadConfig.TabIndex = 26;
            this.buttonLoadConfig.Text = "Load";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 268);
            this.Controls.Add(this.buttonLoadConfig);
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxBSecondHand);
            this.Controls.Add(this.textBoxBMinuteHand);
            this.Controls.Add(this.textBoxBHourHand);
            this.Controls.Add(this.textBoxBBackground);
            this.Controls.Add(this.textBoxGSecondHand);
            this.Controls.Add(this.textBoxGMinuteHand);
            this.Controls.Add(this.textBoxGHourHand);
            this.Controls.Add(this.textBoxGBackground);
            this.Controls.Add(this.textBoxRSecondHand);
            this.Controls.Add(this.textBoxRMinuteHand);
            this.Controls.Add(this.textBoxRHourHand);
            this.Controls.Add(this.textBoxRBackground);
            this.Controls.Add(this.textBoxASecondHand);
            this.Controls.Add(this.textBoxAMinuteHand);
            this.Controls.Add(this.textBoxAHourHand);
            this.Controls.Add(this.textBoxABackground);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelBackground);
            this.Name = "Form2";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxABackground;
        private System.Windows.Forms.TextBox textBoxAHourHand;
        private System.Windows.Forms.TextBox textBoxAMinuteHand;
        private System.Windows.Forms.TextBox textBoxASecondHand;
        private System.Windows.Forms.TextBox textBoxRSecondHand;
        private System.Windows.Forms.TextBox textBoxRMinuteHand;
        private System.Windows.Forms.TextBox textBoxRHourHand;
        private System.Windows.Forms.TextBox textBoxRBackground;
        private System.Windows.Forms.TextBox textBoxGSecondHand;
        private System.Windows.Forms.TextBox textBoxGMinuteHand;
        private System.Windows.Forms.TextBox textBoxGHourHand;
        private System.Windows.Forms.TextBox textBoxGBackground;
        private System.Windows.Forms.TextBox textBoxBSecondHand;
        private System.Windows.Forms.TextBox textBoxBMinuteHand;
        private System.Windows.Forms.TextBox textBoxBHourHand;
        private System.Windows.Forms.TextBox textBoxBBackground;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonLoadConfig;
    }
}