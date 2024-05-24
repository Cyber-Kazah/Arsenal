using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal
{

    #region структура объекта справочника 
    public struct Gun
    {
        public string name;
        public string kalibr;
        public string strelba;
        public int price;
        public string country;
        public string vid;
        public string stat;
        public string web;

        public Button btn;
        public PictureBox pic;

        public Gun(string _name, string _kalibr, string _strelba, int _price, string _country, string _vid, string _stat, string _web)
        {
            name = _name;
            kalibr = _kalibr;
            strelba = _strelba;
            price = _price;
            country = _country;
            vid = _vid;
            stat = _stat;
            web = _web;
            pic = new PictureBox();
            btn = new Button();

            btn.Font = new Font("Microsoft Sans Serin", 12F );
            btn.Text = name;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            try
            { 
                pic.Load("../../Pic/" + name + ".png"); 
            }
            catch (Exception) { }
            

        }
    }
    #endregion


    public partial class Form1 : Form
    {

        public static List<Gun> gun_list = new List<Gun>();
        System.Media.SoundPlayer player_loh = new System.Media.SoundPlayer(@"../../Sound/omg.wav");

        public Form1()
        {
            InitializeComponent();

            Text = "Арсенал";
            Hello_label.Visible = false;
            SelectFormbtn.Visible = false;
            FeetBackbutton.Visible = false;

            
        }

        public static void carClick(object sender, EventArgs e)
        {
            for(int i = 0; i < gun_list.Count; i++)
            {
                if(((Button)sender).Text == gun_list[i].btn.Text)
                {
                    InfoForm info = new InfoForm(gun_list[i]);
                    info.ShowDialog();
                }
            }
            
        }

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            gun_list.Clear();
            ViewPanel.Controls.Clear();
            string[] strs = System.IO.File.ReadAllLines("Arsenal.txt");
            #region На части
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                gun_list.Add(new Gun(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]), parts[4], parts[5], parts[6], parts[7]));
            }
            #endregion

            #region рисование
            int x = 30;
            int y = 30;
            for (int i = 0; i < gun_list.Count; i++)
            {
                gun_list[i].btn.Location = new Point(x, y);
                gun_list[i].btn.Size = new Size(270, 62);
                gun_list[i].btn.Click += new EventHandler(carClick);
                ViewPanel.Controls.Add(gun_list[i].btn);

                gun_list[i].pic.Location = new Point(x, y + 70);
                gun_list[i].pic.Size = new Size(270, 158);
                gun_list[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(gun_list[i].pic);

                x += 290;
                if (x > this.Size.Width - 250)
                {
                    y += 250;
                    x = 30;
                }
            }
            #endregion
        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            button1_Click_1(null, null);
        }

        private void Aut_Button_Click(object sender, EventArgs e)
        {
            if (Aut_Form.Login == "")
            {
                Aut_Form authForm = new Aut_Form();
                authForm.ShowDialog();

            }

            else
            {
                Aut_Form.Login = "";
                Aut_Form.isAdmin = false;
            }


            if (Aut_Form.Login == "")
            {
                Aut_Button.Text = "Вход";
                Hello_label.Visible = false;
                SelectFormbtn.Visible = false;
                FeetBackbutton.Visible = false;
                Reg_Button.Visible = true;
            }
            if (Aut_Form.Login != "")
            {
                Aut_Button.Text = "Выйти";
                Hello_label.Visible = true;
                Hello_label.Text = "Добро пожаловать, " + Aut_Form.Login;
                SelectFormbtn.Visible = true;
                Reg_Button.Visible = false;
                FeetBackbutton.Visible = true;
            }
        }

        private void Reg_Button_Click(object sender, EventArgs e)
        {
            Reg_Form reg = new Reg_Form();
            reg.ShowDialog();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if(Filtrpanel.Height > FiltrButton.Height)
            {
                Filtrpanel.Height = FiltrButton.Height;
            }
            else
            {
                Filtrpanel.Height = 94;
            }
        }

        #region Фильтрация по признакам
        public void button1_Click_1(object sender, EventArgs e)
        {

            int x = 30;
            int y = 30;
            for (int i = 0; i < gun_list.Count; i++)
            {
                gun_list[i].btn.Visible = true;
                gun_list[i].pic.Visible = true;
                //страна
                if(Cntr_comboBox1.Text != "" && Cntr_comboBox1.Text != gun_list[i].country)
                {
                    gun_list[i].btn.Visible = false;
                    gun_list[i].pic.Visible = false;
                }


                //калибр
                if (Clbr_comboBox3.Text != "" && Clbr_comboBox3.Text != gun_list[i].kalibr)
                {
                    gun_list[i].btn.Visible = false;
                    gun_list[i].pic.Visible = false;
                }

                //тип
                if (Type_comboBox2.Text != "" && Type_comboBox2.Text != gun_list[i].strelba)
                {
                    gun_list[i].btn.Visible = false;
                    gun_list[i].pic.Visible = false;
                }

                //вид
                if (vid_comboBox1.Text != "" && vid_comboBox1.Text != gun_list[i].vid)
                {
                    gun_list[i].btn.Visible = false;
                    gun_list[i].pic.Visible = false;
                }

                //Статус
                if (stat_comboBox1.Text != "" && stat_comboBox1.Text != gun_list[i].stat)
                {
                    gun_list[i].btn.Visible = false;
                    gun_list[i].pic.Visible = false;
                }

                if (gun_list[i].btn.Visible)
                {
                    gun_list[i].btn.Location = new Point(x, y);
                    gun_list[i].pic.Location = new Point(x, y + 70);

                    x += 310;
                    if (x > this.Size.Width - 150)
                    {
                        y += 250;
                        x = 30;
                    }
                }
            }
        }
        #endregion

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cntr_comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        #region Избраное
        private void SelectFormbtn_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.ShowDialog();
        }
        #endregion

        private void добавитьОружиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Aut_Form.isAdmin)
            {
                AddGunForm addGun = new AddGunForm();
                addGun.ShowDialog();
            }
            else
            {
                player_loh.Play();
                MessageBox.Show("У вас нет прав");
                return;
            }

            Form1_Load(null, null);
        }


        private void удалитьОружиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Aut_Form.isAdmin)
            {
                DelForm delGun = new DelForm();
                delGun.ShowDialog();
            }
            else
            {
                player_loh.Play();
                MessageBox.Show("Nuh uh");
                return;
            }

            Form1_Load(null, null);
        }

        private void FeetBackbutton_Click(object sender, EventArgs e)
        {
            FeetBack feedBackForm = new FeetBack();
            feedBackForm.ShowDialog();
        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            InfaForm infaform = new InfaForm();
            infaform.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
