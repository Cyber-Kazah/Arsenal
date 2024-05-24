namespace Arsenal
{
    partial class FeetBack
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BodytextBox = new System.Windows.Forms.TextBox();
            this.SubjectcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sendbutton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BodytextBox);
            this.groupBox1.Controls.Add(this.SubjectcomboBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Форма обратной связи";
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(502, 0);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(147, 42);
            this.Sendbutton.TabIndex = 4;
            this.Sendbutton.Text = "Отправить";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сообщение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тема:";
            // 
            // BodytextBox
            // 
            this.BodytextBox.Location = new System.Drawing.Point(15, 122);
            this.BodytextBox.Multiline = true;
            this.BodytextBox.Name = "BodytextBox";
            this.BodytextBox.Size = new System.Drawing.Size(634, 316);
            this.BodytextBox.TabIndex = 1;
            // 
            // SubjectcomboBox
            // 
            this.SubjectcomboBox.FormattingEnabled = true;
            this.SubjectcomboBox.Items.AddRange(new object[] {
            "Благодарность",
            "Жалобы",
            "В тех. поддержку",
            "Предложения",
            "Сообщения сотрудников",
            "Пожелания",
            "Просьбы",
            "Информация"});
            this.SubjectcomboBox.Location = new System.Drawing.Point(14, 54);
            this.SubjectcomboBox.Name = "SubjectcomboBox";
            this.SubjectcomboBox.Size = new System.Drawing.Size(635, 33);
            this.SubjectcomboBox.TabIndex = 0;
            this.SubjectcomboBox.SelectedIndexChanged += new System.EventHandler(this.SubjectcomboBox_SelectedIndexChanged);
            // 
            // FeetBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 462);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FeetBack";
            this.Text = "FeetBack";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BodytextBox;
        private System.Windows.Forms.ComboBox SubjectcomboBox;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}