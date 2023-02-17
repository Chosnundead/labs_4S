namespace WindowsFormsApp2
{
    partial class Form1
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
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AimBox = new System.Windows.Forms.ComboBox();
            this.Button = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(64, 33);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(227, 20);
            this.WeightBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пол:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вес(кг):";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(72, 59);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(219, 20);
            this.HeightBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Рост(см):";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(93, 85);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(198, 20);
            this.AgeBox.TabIndex = 7;
            this.AgeBox.TextChanged += new System.EventHandler(this.AgeBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Возраст(лет):";
            // 
            // SexBox
            // 
            this.SexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.SexBox.Location = new System.Drawing.Point(48, 6);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(243, 21);
            this.SexBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цель:";
            // 
            // AimBox
            // 
            this.AimBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AimBox.FormattingEnabled = true;
            this.AimBox.Items.AddRange(new object[] {
            "Минимум\\отсутствие физической нагрузки",
            "3 раза в неделю",
            "5 раз в неделю",
            "5 раз в неделю(интенсивно)",
            "Каждый день",
            "Каждый день интенсивно или два раза в день",
            "Ежедневная физическая нагрузка + физическая работа"});
            this.AimBox.Location = new System.Drawing.Point(54, 111);
            this.AimBox.Name = "AimBox";
            this.AimBox.Size = new System.Drawing.Size(237, 21);
            this.AimBox.TabIndex = 11;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(15, 138);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(276, 67);
            this.Button.TabIndex = 12;
            this.Button.Text = "Расчитать";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.MyClick);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.ForeColor = System.Drawing.Color.Red;
            this.ResultLabel.Location = new System.Drawing.Point(12, 208);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(62, 13);
            this.ResultLabel.TabIndex = 13;
            this.ResultLabel.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 227);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.AimBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeightBox);
            this.Name = "Form1";
            this.Text = "Калькулятор калорий ver.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AimBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label ResultLabel;
    }
}

