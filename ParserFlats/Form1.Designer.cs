namespace ParserFlats
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
            this.radioButton1_perm = new System.Windows.Forms.RadioButton();
            this.radioButton2_ekat = new System.Windows.Forms.RadioButton();
            this.radioButton3_nn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть сайт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1_perm
            // 
            this.radioButton1_perm.AutoSize = true;
            this.radioButton1_perm.Checked = true;
            this.radioButton1_perm.Location = new System.Drawing.Point(59, 64);
            this.radioButton1_perm.Name = "radioButton1_perm";
            this.radioButton1_perm.Size = new System.Drawing.Size(14, 13);
            this.radioButton1_perm.TabIndex = 2;
            this.radioButton1_perm.TabStop = true;
            this.radioButton1_perm.UseVisualStyleBackColor = true;
            // 
            // radioButton2_ekat
            // 
            this.radioButton2_ekat.AutoSize = true;
            this.radioButton2_ekat.Location = new System.Drawing.Point(154, 64);
            this.radioButton2_ekat.Name = "radioButton2_ekat";
            this.radioButton2_ekat.Size = new System.Drawing.Size(14, 13);
            this.radioButton2_ekat.TabIndex = 3;
            this.radioButton2_ekat.UseVisualStyleBackColor = true;
            // 
            // radioButton3_nn
            // 
            this.radioButton3_nn.AutoSize = true;
            this.radioButton3_nn.Location = new System.Drawing.Point(261, 64);
            this.radioButton3_nn.Name = "radioButton3_nn";
            this.radioButton3_nn.Size = new System.Drawing.Size(14, 13);
            this.radioButton3_nn.TabIndex = 4;
            this.radioButton3_nn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите город:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пермь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Екатеринбург";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Нижний Новгород";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-10",
            "11-20",
            "21-30",
            "31-40",
            "41-50",
            "51-60"});
            this.comboBox1.Location = new System.Drawing.Point(47, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Страницы:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Собрать данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 227);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Ссылки собранных объявлений:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 306);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3_nn);
            this.Controls.Add(this.radioButton2_ekat);
            this.Controls.Add(this.radioButton1_perm);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web scraper for CIAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1_perm;
        private System.Windows.Forms.RadioButton radioButton2_ekat;
        private System.Windows.Forms.RadioButton radioButton3_nn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

