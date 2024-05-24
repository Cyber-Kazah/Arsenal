namespace Arsenal
{
    partial class InfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.info_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cntr_label = new System.Windows.Forms.Label();
            this.Clbr_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Type_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Vid_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddSelectbtn = new System.Windows.Forms.Button();
            this.Stat_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 126);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // info_textBox1
            // 
            this.info_textBox1.Location = new System.Drawing.Point(546, 103);
            this.info_textBox1.Multiline = true;
            this.info_textBox1.Name = "info_textBox1";
            this.info_textBox1.ReadOnly = true;
            this.info_textBox1.Size = new System.Drawing.Size(459, 423);
            this.info_textBox1.TabIndex = 2;
            this.info_textBox1.TextChanged += new System.EventHandler(this.info_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страна";
            // 
            // Cntr_label
            // 
            this.Cntr_label.AutoSize = true;
            this.Cntr_label.Location = new System.Drawing.Point(213, 3);
            this.Cntr_label.Name = "Cntr_label";
            this.Cntr_label.Size = new System.Drawing.Size(64, 25);
            this.Cntr_label.TabIndex = 5;
            this.Cntr_label.Text = "label4";
            // 
            // Clbr_label
            // 
            this.Clbr_label.AutoSize = true;
            this.Clbr_label.Location = new System.Drawing.Point(213, 49);
            this.Clbr_label.Name = "Clbr_label";
            this.Clbr_label.Size = new System.Drawing.Size(64, 25);
            this.Clbr_label.TabIndex = 7;
            this.Clbr_label.Text = "label4";
            this.Clbr_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Калибр";
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(213, 95);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(64, 25);
            this.Type_label.TabIndex = 9;
            this.Type_label.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Тип";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Stat_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Vid_label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Clbr_label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Type_label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cntr_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(98, 246);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 236);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Vid_label
            // 
            this.Vid_label.AutoSize = true;
            this.Vid_label.Location = new System.Drawing.Point(213, 141);
            this.Vid_label.Name = "Vid_label";
            this.Vid_label.Size = new System.Drawing.Size(64, 25);
            this.Vid_label.TabIndex = 12;
            this.Vid_label.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Вид";
            // 
            // AddSelectbtn
            // 
            this.AddSelectbtn.BackColor = System.Drawing.Color.Chocolate;
            this.AddSelectbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddSelectbtn.Location = new System.Drawing.Point(240, 31);
            this.AddSelectbtn.Name = "AddSelectbtn";
            this.AddSelectbtn.Size = new System.Drawing.Size(178, 43);
            this.AddSelectbtn.TabIndex = 11;
            this.AddSelectbtn.Text = "В избраное";
            this.AddSelectbtn.UseVisualStyleBackColor = false;
            this.AddSelectbtn.Click += new System.EventHandler(this.AddSelectbtn_Click);
            // 
            // Stat_label
            // 
            this.Stat_label.AutoSize = true;
            this.Stat_label.Location = new System.Drawing.Point(213, 187);
            this.Stat_label.Name = "Stat_label";
            this.Stat_label.Size = new System.Drawing.Size(64, 25);
            this.Stat_label.TabIndex = 13;
            this.Stat_label.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Статус";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 573);
            this.Controls.Add(this.AddSelectbtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info_textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox info_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cntr_label;
        private System.Windows.Forms.Label Clbr_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddSelectbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Vid_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Stat_label;
    }
}