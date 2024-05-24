namespace Arsenal
{
    partial class InfaForm
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
            this.InfotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InfotextBox
            // 
            this.InfotextBox.Enabled = false;
            this.InfotextBox.Location = new System.Drawing.Point(15, 17);
            this.InfotextBox.Multiline = true;
            this.InfotextBox.Name = "InfotextBox";
            this.InfotextBox.ReadOnly = true;
            this.InfotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfotextBox.Size = new System.Drawing.Size(964, 660);
            this.InfotextBox.TabIndex = 0;
            this.InfotextBox.TextChanged += new System.EventHandler(this.InfotextBox_TextChanged);
            // 
            // InfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 689);
            this.Controls.Add(this.InfotextBox);
            this.Name = "InfaForm";
            this.Text = "InfaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfotextBox;
    }
}