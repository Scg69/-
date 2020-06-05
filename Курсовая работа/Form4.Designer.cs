namespace Курсовая_работа
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Логин = new System.Windows.Forms.Label();
            this.Пароль = new System.Windows.Forms.Label();
            this.Добро = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(57, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(57, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 26);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(106, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Логин
            // 
            this.Логин.AutoSize = true;
            this.Логин.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Логин.Location = new System.Drawing.Point(57, 81);
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(47, 17);
            this.Логин.TabIndex = 3;
            this.Логин.Text = "Логин";
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Пароль.Location = new System.Drawing.Point(57, 138);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(57, 17);
            this.Пароль.TabIndex = 4;
            this.Пароль.Text = "Пароль";
            this.Пароль.Click += new System.EventHandler(this.label2_Click);
            // 
            // Добро
            // 
            this.Добро.AutoSize = true;
            this.Добро.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Добро.Location = new System.Drawing.Point(52, 23);
            this.Добро.Name = "Добро";
            this.Добро.Size = new System.Drawing.Size(207, 26);
            this.Добро.TabIndex = 5;
            this.Добро.Text = "Добро пожаловать";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Добро);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.Логин);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Логин;
        private System.Windows.Forms.Label Пароль;
        private System.Windows.Forms.Label Добро;
        private System.Windows.Forms.Button button2;
    }
}