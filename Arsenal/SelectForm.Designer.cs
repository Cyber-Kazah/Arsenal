namespace Arsenal
{
    partial class SelectForm
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
            this.Syspanel = new System.Windows.Forms.Panel();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.infopanel = new System.Windows.Forms.Panel();
            this.TotalPricelabel = new System.Windows.Forms.Label();
            this.Syspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Syspanel
            // 
            this.Syspanel.BackColor = System.Drawing.Color.DarkGray;
            this.Syspanel.Controls.Add(this.TotalPricelabel);
            this.Syspanel.Controls.Add(this.Sendbutton);
            this.Syspanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Syspanel.Location = new System.Drawing.Point(0, 0);
            this.Syspanel.Name = "Syspanel";
            this.Syspanel.Size = new System.Drawing.Size(1240, 97);
            this.Syspanel.TabIndex = 0;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(12, 22);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(349, 55);
            this.Sendbutton.TabIndex = 0;
            this.Sendbutton.Text = "Отправить список";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // infopanel
            // 
            this.infopanel.AutoScroll = true;
            this.infopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infopanel.Location = new System.Drawing.Point(0, 97);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(1240, 606);
            this.infopanel.TabIndex = 1;
            // 
            // TotalPricelabel
            // 
            this.TotalPricelabel.AutoSize = true;
            this.TotalPricelabel.Location = new System.Drawing.Point(367, 37);
            this.TotalPricelabel.Name = "TotalPricelabel";
            this.TotalPricelabel.Size = new System.Drawing.Size(45, 25);
            this.TotalPricelabel.TabIndex = 1;
            this.TotalPricelabel.Text = "666";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 703);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.Syspanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectForm";
            this.Text = "избраное";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.Syspanel.ResumeLayout(false);
            this.Syspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Syspanel;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Label TotalPricelabel;
    }
}