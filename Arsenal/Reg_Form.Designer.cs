namespace Arsenal
{
    partial class Reg_Form
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
            this.Regbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rePassTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Regbutton1
            // 
            this.Regbutton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Regbutton1.Location = new System.Drawing.Point(0, 398);
            this.Regbutton1.Name = "Regbutton1";
            this.Regbutton1.Size = new System.Drawing.Size(434, 75);
            this.Regbutton1.TabIndex = 0;
            this.Regbutton1.Text = "Зарегестрироваться";
            this.Regbutton1.UseVisualStyleBackColor = true;
            this.Regbutton1.Click += new System.EventHandler(this.Regbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(41, 76);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(352, 30);
            this.NameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(45, 208);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(347, 30);
            this.PassTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rePassTB
            // 
            this.rePassTB.Location = new System.Drawing.Point(42, 327);
            this.rePassTB.Name = "rePassTB";
            this.rePassTB.Size = new System.Drawing.Size(350, 30);
            this.rePassTB.TabIndex = 6;
            // 
            // Reg_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 473);
            this.Controls.Add(this.rePassTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Regbutton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reg_Form";
            this.Text = "Reg_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rePassTB;
    }
}