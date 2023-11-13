namespace BMI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            heightTB = new TextBox();
            massTB = new TextBox();
            bmiTB = new TextBox();
            calculateBtn = new Button();
            label4 = new Label();
            countTB = new TextBox();
            heightNUD = new NumericUpDown();
            massNUD = new NumericUpDown();
            bmi2TB = new TextBox();
            calculate2Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)heightNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)massNUD).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 31);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Height:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Mass:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 138);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "BMI:";
            // 
            // heightTB
            // 
            heightTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            heightTB.Location = new Point(134, 24);
            heightTB.Name = "heightTB";
            heightTB.Size = new Size(100, 32);
            heightTB.TabIndex = 3;
            // 
            // massTB
            // 
            massTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            massTB.Location = new Point(134, 81);
            massTB.Name = "massTB";
            massTB.Size = new Size(100, 32);
            massTB.TabIndex = 4;
            // 
            // bmiTB
            // 
            bmiTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bmiTB.Location = new Point(134, 138);
            bmiTB.Name = "bmiTB";
            bmiTB.Size = new Size(100, 32);
            bmiTB.TabIndex = 5;
            // 
            // calculateBtn
            // 
            calculateBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            calculateBtn.Location = new Point(138, 215);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(129, 49);
            calculateBtn.TabIndex = 6;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 292);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 7;
            label4.Text = "Count:";
            // 
            // countTB
            // 
            countTB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            countTB.Location = new Point(138, 289);
            countTB.Name = "countTB";
            countTB.Size = new Size(100, 32);
            countTB.TabIndex = 8;
            // 
            // heightNUD
            // 
            heightNUD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            heightNUD.Location = new Point(301, 24);
            heightNUD.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            heightNUD.Name = "heightNUD";
            heightNUD.Size = new Size(120, 32);
            heightNUD.TabIndex = 9;
            heightNUD.Value = new decimal(new int[] { 55, 0, 0, 0 });
            // 
            // massNUD
            // 
            massNUD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            massNUD.Location = new Point(301, 81);
            massNUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            massNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            massNUD.Name = "massNUD";
            massNUD.Size = new Size(120, 32);
            massNUD.TabIndex = 10;
            massNUD.Value = new decimal(new int[] { 55, 0, 0, 0 });
            // 
            // bmi2TB
            // 
            bmi2TB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bmi2TB.Location = new Point(301, 138);
            bmi2TB.Name = "bmi2TB";
            bmi2TB.Size = new Size(120, 32);
            bmi2TB.TabIndex = 11;
            // 
            // calculate2Btn
            // 
            calculate2Btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            calculate2Btn.Location = new Point(301, 215);
            calculate2Btn.Name = "calculate2Btn";
            calculate2Btn.Size = new Size(187, 49);
            calculate2Btn.TabIndex = 12;
            calculate2Btn.Text = "Improved Calculate";
            calculate2Btn.UseVisualStyleBackColor = true;
            calculate2Btn.Click += calculate2Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculate2Btn);
            Controls.Add(bmi2TB);
            Controls.Add(massNUD);
            Controls.Add(heightNUD);
            Controls.Add(countTB);
            Controls.Add(label4);
            Controls.Add(calculateBtn);
            Controls.Add(bmiTB);
            Controls.Add(massTB);
            Controls.Add(heightTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)heightNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)massNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox heightTB;
        private TextBox massTB;
        private TextBox bmiTB;
        private Button calculateBtn;
        private Label label4;
        private TextBox countTB;
        private NumericUpDown heightNUD;
        private NumericUpDown massNUD;
        private TextBox bmi2TB;
        private Button calculate2Btn;
    }
}