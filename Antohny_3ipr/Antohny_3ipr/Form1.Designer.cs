namespace Antohny_3ipr
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
            this.sourceFileButton_Click = new System.Windows.Forms.Button();
            this.signFileButton_Click = new System.Windows.Forms.Button();
            this.buttonEncrypt_Click = new System.Windows.Forms.Button();
            this.buttonDecipher_Click = new System.Windows.Forms.Button();
            this.sourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.signFilePathTextBox = new System.Windows.Forms.TextBox();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceFileButton_Click
            // 
            this.sourceFileButton_Click.Location = new System.Drawing.Point(517, 55);
            this.sourceFileButton_Click.Name = "sourceFileButton_Click";
            this.sourceFileButton_Click.Size = new System.Drawing.Size(122, 23);
            this.sourceFileButton_Click.TabIndex = 0;
            this.sourceFileButton_Click.Text = "Исходный файл";
            this.sourceFileButton_Click.UseVisualStyleBackColor = true;
            this.sourceFileButton_Click.Click += new System.EventHandler(this.sourceFileButton_Click_Click);
            // 
            // signFileButton_Click
            // 
            this.signFileButton_Click.Location = new System.Drawing.Point(517, 112);
            this.signFileButton_Click.Name = "signFileButton_Click";
            this.signFileButton_Click.Size = new System.Drawing.Size(122, 23);
            this.signFileButton_Click.TabIndex = 1;
            this.signFileButton_Click.Text = "Подписанный файл";
            this.signFileButton_Click.UseVisualStyleBackColor = true;
            this.signFileButton_Click.Click += new System.EventHandler(this.signFileButton_Click_Click);
            // 
            // buttonEncrypt_Click
            // 
            this.buttonEncrypt_Click.Location = new System.Drawing.Point(158, 384);
            this.buttonEncrypt_Click.Name = "buttonEncrypt_Click";
            this.buttonEncrypt_Click.Size = new System.Drawing.Size(130, 23);
            this.buttonEncrypt_Click.TabIndex = 2;
            this.buttonEncrypt_Click.Text = "Подписать файл";
            this.buttonEncrypt_Click.UseVisualStyleBackColor = true;
            this.buttonEncrypt_Click.Click += new System.EventHandler(this.buttonEncrypt_Click_Click);
            // 
            // buttonDecipher_Click
            // 
            this.buttonDecipher_Click.Location = new System.Drawing.Point(535, 384);
            this.buttonDecipher_Click.Name = "buttonDecipher_Click";
            this.buttonDecipher_Click.Size = new System.Drawing.Size(135, 23);
            this.buttonDecipher_Click.TabIndex = 3;
            this.buttonDecipher_Click.Text = "Проверить подпись";
            this.buttonDecipher_Click.UseVisualStyleBackColor = true;
            this.buttonDecipher_Click.Click += new System.EventHandler(this.buttonDecipher_Click_Click);
            // 
            // sourceFilePathTextBox
            // 
            this.sourceFilePathTextBox.Location = new System.Drawing.Point(44, 55);
            this.sourceFilePathTextBox.Name = "sourceFilePathTextBox";
            this.sourceFilePathTextBox.Size = new System.Drawing.Size(432, 20);
            this.sourceFilePathTextBox.TabIndex = 4;
            // 
            // signFilePathTextBox
            // 
            this.signFilePathTextBox.Location = new System.Drawing.Point(44, 112);
            this.signFilePathTextBox.Name = "signFilePathTextBox";
            this.signFilePathTextBox.Size = new System.Drawing.Size(432, 20);
            this.signFilePathTextBox.TabIndex = 5;
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(89, 339);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(100, 20);
            this.textBox_p.TabIndex = 6;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(252, 339);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(100, 20);
            this.textBox_q.TabIndex = 7;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(459, 339);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 20);
            this.textBox_d.TabIndex = 8;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(640, 339);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 20);
            this.textBox_n.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.signFilePathTextBox);
            this.Controls.Add(this.sourceFilePathTextBox);
            this.Controls.Add(this.buttonDecipher_Click);
            this.Controls.Add(this.buttonEncrypt_Click);
            this.Controls.Add(this.signFileButton_Click);
            this.Controls.Add(this.sourceFileButton_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceFileButton_Click;
        private System.Windows.Forms.Button signFileButton_Click;
        private System.Windows.Forms.Button buttonEncrypt_Click;
        private System.Windows.Forms.Button buttonDecipher_Click;
        private System.Windows.Forms.TextBox sourceFilePathTextBox;
        private System.Windows.Forms.TextBox signFilePathTextBox;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

