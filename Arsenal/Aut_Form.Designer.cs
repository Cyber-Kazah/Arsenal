﻿namespace Arsenal
{
    partial class Aut_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass_textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(465, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Login_textBox1
            // 
            this.Login_textBox1.Location = new System.Drawing.Point(33, 90);
            this.Login_textBox1.Name = "Login_textBox1";
            this.Login_textBox1.Size = new System.Drawing.Size(384, 30);
            this.Login_textBox1.TabIndex = 2;
            this.Login_textBox1.TextChanged += new System.EventHandler(this.Login_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // Pass_textBox2
            // 
            this.Pass_textBox2.Location = new System.Drawing.Point(33, 195);
            this.Pass_textBox2.Name = "Pass_textBox2";
            this.Pass_textBox2.Size = new System.Drawing.Size(381, 30);
            this.Pass_textBox2.TabIndex = 4;
            // 
            // Aut_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 336);
            this.Controls.Add(this.Pass_textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Aut_Form";
            this.Text = "Aut_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pass_textBox2;
    }
}