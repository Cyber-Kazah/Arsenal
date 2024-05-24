namespace Arsenal
{
    partial class DelForm
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
            this.Delbutton = new System.Windows.Forms.Button();
            this.DelcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Delbutton
            // 
            this.Delbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delbutton.Location = new System.Drawing.Point(0, 218);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(445, 84);
            this.Delbutton.TabIndex = 0;
            this.Delbutton.Text = "Удалить";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // DelcomboBox
            // 
            this.DelcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelcomboBox.FormattingEnabled = true;
            this.DelcomboBox.Location = new System.Drawing.Point(48, 54);
            this.DelcomboBox.Name = "DelcomboBox";
            this.DelcomboBox.Size = new System.Drawing.Size(360, 33);
            this.DelcomboBox.TabIndex = 1;
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 302);
            this.Controls.Add(this.DelcomboBox);
            this.Controls.Add(this.Delbutton);
            this.Name = "DelForm";
            this.Text = "DelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.ComboBox DelcomboBox;
    }
}