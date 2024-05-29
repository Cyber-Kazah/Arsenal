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
    public partial class SelectForm : Form
    {
        public static Dictionary <Gun, int> GunList = new Dictionary <Gun, int> ();

        public static int TotalPrice = 0;


        public SelectForm()
        {
            InitializeComponent();
            Draw();
        }

        void Calc()
        {
            TotalPrice = 0;
            foreach (KeyValuePair<Gun, int> my_gun in GunList)
            {
                TotalPrice += my_gun.Value * my_gun.Key.price;
            }
        }

        void Draw()
        {
            infopanel.Controls.Clear ();

            int x = 30;
            int y = 30;
            foreach (KeyValuePair<Gun, int> my_gun in GunList)
            {
                Gun gun = my_gun.Key;

                #region Занесение в избраное (картинка)
                PictureBox pb = new PictureBox();
                pb.Image = gun.pic.Image;
                pb.Location = new Point(x, y + 50);
                pb.Size = new Size(270, 178);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                infopanel.Controls.Add(pb);
                #endregion

                #region Занесение в избраное (название)
                Label lbl1 = new Label();
                lbl1.Text = "Название- " + gun.name;
                lbl1.Location = new Point(338, y + 70);
                lbl1.Size = new Size(200, 30);
                infopanel.Controls.Add(lbl1);
                #endregion

                #region Занесение в избраное (Калибр)
                Label lbl2 = new Label();
                lbl2.Text = "Калибр- " + gun.kalibr;
                lbl2.Location = new Point(553, y + 5);
                lbl2.Size = new Size(200, 30);
                infopanel.Controls.Add(lbl2);
                #endregion

                #region Занесение в избраное (Тип стрельбы)
                Label lbl3 = new Label();
                lbl3.Text = "Тип стрельбы- " + gun.strelba;
                lbl3.Location = new Point(553, y + 70);
                lbl3.Size = new Size(200, 30);
                infopanel.Controls.Add(lbl3);
                #endregion

                #region Занесение в избраное (Страна)
                Label lbl4 = new Label();
                lbl4.Text = "Страна- " + gun.country;
                lbl4.Location = new Point(553, y + 140);
                lbl4.Size = new Size(200, 30);
                infopanel.Controls.Add(lbl4);
                #endregion

                #region Занесение в избраное (Цена)
                Label lbl5 = new Label();
                lbl5.Text = "Цена- " + gun.price;
                lbl5.Location = new Point(793, y + 70);
                lbl5.Size = new Size(150, 30);
                infopanel.Controls.Add(lbl5);
                #endregion

                #region Занесение в избраное (итого)
                Label lbl_5 = new Label();
                lbl_5.Text = "Итого: " + (gun.price * my_gun.Value).ToString() + " Руб.";
                lbl_5.Location = new Point(793, y + 100);
                lbl_5.Size = new Size(150, 30);
                infopanel.Controls.Add(lbl_5);
                #endregion

                #region Занесение в избраное (Количество)
                Label lbl6 = new Label();
                lbl6.Location = new Point(793, y + 150);
                lbl6.Size = new Size(200, 30);
                lbl6.Text = "Кол., шт.:";
                infopanel.Controls.Add(lbl6);

                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Location = new Point(793, y + 180);
                numericUpDown1.Size = new Size(200, 30);
                numericUpDown1.Value = new decimal(my_gun.Value);
                numericUpDown1.ValueChanged += new EventHandler(CountChanged);
                infopanel.Controls.Add(numericUpDown1);
                #endregion

                #region Кнопка удаления из избраного
                Button btn1 = new Button();
                btn1.Location = new Point(950, y + 70);
                btn1.Size = new Size(200, 30);
                btn1.Text = "Удалить";
                btn1.Click += new EventHandler(DeleteClick);
                infopanel.Controls.Add(btn1);
                #endregion

                #region Кнопка информации
                Button btn = new Button();
                btn.Location = new Point(338, y + 100);
                btn.Size = new Size(200, 30);
                btn.Text = gun.name;
                btn.Click += new EventHandler(Form1.gunClick);
                infopanel.Controls.Add(btn);
                #endregion

                y += 250;
            }
            Calc();
            TotalPricelabel.Text = "Итоговая стоимость, руб.: " + TotalPrice.ToString();
        }

        private void CountChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            for(int i=0; i<GunList.Count; i++)
            {
                if(nud.Location == new Point(793, 210 + 250 * i + infopanel.AutoScrollPosition.Y))
                {
                    int price = 0;
                    Image image = null;

                    foreach(Control ctrl in infopanel.Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Location == new Point(30, 80 + 250 * i + infopanel.AutoScrollPosition.Y))
                        {
                            image = ((PictureBox)ctrl).Image;
                        }
                    }
                    foreach(Gun gun in Form1.gun_list)
                    {
                        if(gun.pic.Image == image)
                        {
                            GunList[gun] = Convert.ToInt32(nud.Value);
                        }
                    }
                    foreach(Control ctrl in infopanel.Controls)
                    {
                        if(ctrl is Label && ctrl.Location == new Point(793, 100 + 250 * i + infopanel.AutoScrollPosition.Y))
                        {
                            price = Convert.ToInt32(ctrl.Text.Replace("Цена- ", ""));
                        }
                    }
                    foreach (Control ctrl in infopanel.Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(793, 130 + 250 * i + infopanel.AutoScrollPosition.Y))
                        {
                            ctrl.Text = "Итого: " + (price * nud.Value).ToString();
                        }

                    }
                    Calc();
                    TotalPricelabel.Text = "Итоговая стоимость, руб.: " + TotalPrice.ToString();
                }
            }
        }

        void DeleteClick(object sender, EventArgs e)
        {
            int i = 0;
            Button btn = (Button)sender;
            Dictionary<Gun, int> my_guns = new Dictionary<Gun, int>();
            foreach(KeyValuePair<Gun, int> my_gun in GunList)
            {
                Gun gun = my_gun.Key;
                if (btn.Location == new Point(950, 30+70+250*i))
                {

                }
                else
                {
                    my_guns[my_gun.Key] = my_gun.Value;
                }
                i++;

            }

            GunList = my_guns;
            Draw();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            SendForm send = new SendForm();
            send.Show();
        }
    }
}
