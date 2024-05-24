namespace Arsenal
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
            this.components = new System.ComponentModel.Container();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infobutton = new System.Windows.Forms.Button();
            this.FeetBackbutton = new System.Windows.Forms.Button();
            this.SelectFormbtn = new System.Windows.Forms.Button();
            this.Reg_Button = new System.Windows.Forms.Button();
            this.Hello_label = new System.Windows.Forms.Label();
            this.Aut_Button = new System.Windows.Forms.Button();
            this.Filtrpanel = new System.Windows.Forms.Panel();
            this.vid_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Clbr_comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Type_comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cntr_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьОружиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОружиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stat_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Filtrpanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 167);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1278, 404);
            this.ViewPanel.TabIndex = 8;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint);
            this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.infobutton);
            this.panel1.Controls.Add(this.FeetBackbutton);
            this.panel1.Controls.Add(this.SelectFormbtn);
            this.panel1.Controls.Add(this.Reg_Button);
            this.panel1.Controls.Add(this.Hello_label);
            this.panel1.Controls.Add(this.Aut_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 73);
            this.panel1.TabIndex = 9;
            // 
            // infobutton
            // 
            this.infobutton.Location = new System.Drawing.Point(1207, 20);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(42, 35);
            this.infobutton.TabIndex = 5;
            this.infobutton.Text = "!";
            this.infobutton.UseVisualStyleBackColor = true;
            this.infobutton.Click += new System.EventHandler(this.infobutton_Click);
            // 
            // FeetBackbutton
            // 
            this.FeetBackbutton.Location = new System.Drawing.Point(967, 20);
            this.FeetBackbutton.Name = "FeetBackbutton";
            this.FeetBackbutton.Size = new System.Drawing.Size(179, 39);
            this.FeetBackbutton.TabIndex = 4;
            this.FeetBackbutton.Text = "Обратная связь";
            this.FeetBackbutton.UseVisualStyleBackColor = true;
            this.FeetBackbutton.Click += new System.EventHandler(this.FeetBackbutton_Click);
            // 
            // SelectFormbtn
            // 
            this.SelectFormbtn.Location = new System.Drawing.Point(746, 23);
            this.SelectFormbtn.Name = "SelectFormbtn";
            this.SelectFormbtn.Size = new System.Drawing.Size(192, 33);
            this.SelectFormbtn.TabIndex = 3;
            this.SelectFormbtn.Text = "избраное";
            this.SelectFormbtn.UseVisualStyleBackColor = true;
            this.SelectFormbtn.Click += new System.EventHandler(this.SelectFormbtn_Click);
            // 
            // Reg_Button
            // 
            this.Reg_Button.Location = new System.Drawing.Point(966, 23);
            this.Reg_Button.Name = "Reg_Button";
            this.Reg_Button.Size = new System.Drawing.Size(192, 33);
            this.Reg_Button.TabIndex = 2;
            this.Reg_Button.Text = "Регистрация";
            this.Reg_Button.UseVisualStyleBackColor = true;
            this.Reg_Button.Click += new System.EventHandler(this.Reg_Button_Click);
            // 
            // Hello_label
            // 
            this.Hello_label.AutoSize = true;
            this.Hello_label.Location = new System.Drawing.Point(213, 27);
            this.Hello_label.Name = "Hello_label";
            this.Hello_label.Size = new System.Drawing.Size(64, 25);
            this.Hello_label.TabIndex = 1;
            this.Hello_label.Text = "label1";
            // 
            // Aut_Button
            // 
            this.Aut_Button.Location = new System.Drawing.Point(23, 20);
            this.Aut_Button.Name = "Aut_Button";
            this.Aut_Button.Size = new System.Drawing.Size(159, 39);
            this.Aut_Button.TabIndex = 0;
            this.Aut_Button.Text = "Вход";
            this.Aut_Button.UseVisualStyleBackColor = true;
            this.Aut_Button.Click += new System.EventHandler(this.Aut_Button_Click);
            // 
            // Filtrpanel
            // 
            this.Filtrpanel.BackColor = System.Drawing.Color.Gray;
            this.Filtrpanel.Controls.Add(this.stat_comboBox1);
            this.Filtrpanel.Controls.Add(this.label5);
            this.Filtrpanel.Controls.Add(this.vid_comboBox1);
            this.Filtrpanel.Controls.Add(this.label4);
            this.Filtrpanel.Controls.Add(this.button1);
            this.Filtrpanel.Controls.Add(this.Clbr_comboBox3);
            this.Filtrpanel.Controls.Add(this.label3);
            this.Filtrpanel.Controls.Add(this.Type_comboBox2);
            this.Filtrpanel.Controls.Add(this.label2);
            this.Filtrpanel.Controls.Add(this.Cntr_comboBox1);
            this.Filtrpanel.Controls.Add(this.label1);
            this.Filtrpanel.Controls.Add(this.FiltrButton);
            this.Filtrpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filtrpanel.Location = new System.Drawing.Point(0, 73);
            this.Filtrpanel.Name = "Filtrpanel";
            this.Filtrpanel.Size = new System.Drawing.Size(1278, 94);
            this.Filtrpanel.TabIndex = 10;
            // 
            // vid_comboBox1
            // 
            this.vid_comboBox1.FormattingEnabled = true;
            this.vid_comboBox1.Items.AddRange(new object[] {
            "",
            "автоматический",
            "одиночный",
            "полу-автоматический"});
            this.vid_comboBox1.Location = new System.Drawing.Point(547, 47);
            this.vid_comboBox1.Name = "vid_comboBox1";
            this.vid_comboBox1.Size = new System.Drawing.Size(121, 33);
            this.vid_comboBox1.TabIndex = 9;
            this.vid_comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип стрельбы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1049, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 76);
            this.button1.TabIndex = 7;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Clbr_comboBox3
            // 
            this.Clbr_comboBox3.FormattingEnabled = true;
            this.Clbr_comboBox3.Items.AddRange(new object[] {
            "",
            "9.18",
            "9.19",
            "9.39",
            "5.45",
            "5.56",
            "7.62",
            ".12",
            ".50",
            "гранаты"});
            this.Clbr_comboBox3.Location = new System.Drawing.Point(261, 47);
            this.Clbr_comboBox3.Name = "Clbr_comboBox3";
            this.Clbr_comboBox3.Size = new System.Drawing.Size(121, 33);
            this.Clbr_comboBox3.TabIndex = 6;
            this.Clbr_comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Калибр";
            // 
            // Type_comboBox2
            // 
            this.Type_comboBox2.FormattingEnabled = true;
            this.Type_comboBox2.Items.AddRange(new object[] {
            "",
            "пистолет",
            "пп",
            "автомат",
            "винтовка",
            "дробовик",
            "пулемёт",
            "гранатомёт"});
            this.Type_comboBox2.Location = new System.Drawing.Point(547, 8);
            this.Type_comboBox2.Name = "Type_comboBox2";
            this.Type_comboBox2.Size = new System.Drawing.Size(121, 33);
            this.Type_comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вид оружия";
            // 
            // Cntr_comboBox1
            // 
            this.Cntr_comboBox1.FormattingEnabled = true;
            this.Cntr_comboBox1.Items.AddRange(new object[] {
            "",
            "СНГ",
            "Запад",
            "Европа",
            "Восток"});
            this.Cntr_comboBox1.Location = new System.Drawing.Point(261, 8);
            this.Cntr_comboBox1.Name = "Cntr_comboBox1";
            this.Cntr_comboBox1.Size = new System.Drawing.Size(121, 33);
            this.Cntr_comboBox1.TabIndex = 2;
            this.Cntr_comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cntr_comboBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Страна";
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(161, 31);
            this.FiltrButton.TabIndex = 0;
            this.FiltrButton.Text = "Фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОружиеToolStripMenuItem,
            this.удалитьОружиеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 52);
            // 
            // добавитьОружиеToolStripMenuItem
            // 
            this.добавитьОружиеToolStripMenuItem.Name = "добавитьОружиеToolStripMenuItem";
            this.добавитьОружиеToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.добавитьОружиеToolStripMenuItem.Text = "Добавить оружие";
            this.добавитьОружиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьОружиеToolStripMenuItem_Click);
            // 
            // удалитьОружиеToolStripMenuItem
            // 
            this.удалитьОружиеToolStripMenuItem.Name = "удалитьОружиеToolStripMenuItem";
            this.удалитьОружиеToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.удалитьОружиеToolStripMenuItem.Text = "Удалить оружие";
            this.удалитьОружиеToolStripMenuItem.Click += new System.EventHandler(this.удалитьОружиеToolStripMenuItem_Click);
            // 
            // stat_comboBox1
            // 
            this.stat_comboBox1.FormattingEnabled = true;
            this.stat_comboBox1.Items.AddRange(new object[] {
            "",
            "в эксплуатации",
            "не в эксплуатации"});
            this.stat_comboBox1.Location = new System.Drawing.Point(773, 9);
            this.stat_comboBox1.Name = "stat_comboBox1";
            this.stat_comboBox1.Size = new System.Drawing.Size(186, 33);
            this.stat_comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Статус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 571);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.Filtrpanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Filtrpanel.ResumeLayout(false);
            this.Filtrpanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Filtrpanel;
        private System.Windows.Forms.Button Aut_Button;
        private System.Windows.Forms.Button Reg_Button;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type_comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cntr_comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Clbr_comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Hello_label;
        private System.Windows.Forms.Button SelectFormbtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьОружиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьОружиеToolStripMenuItem;
        private System.Windows.Forms.Button FeetBackbutton;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.ComboBox vid_comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stat_comboBox1;
        private System.Windows.Forms.Label label5;
    }
}

