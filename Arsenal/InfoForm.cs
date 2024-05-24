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
    public partial class InfoForm : Form
    {
        Gun gun;
        public InfoForm(Gun _gun)
        {
            

            InitializeComponent();

            gun = _gun;

            Text = gun.name;
            label1.Text = gun.name;
            try
            {
                pictureBox1.Load("../../Pic/" + gun.name + ".png");
            }
            catch (Exception) { }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                info_textBox1.Text = System.IO.File.ReadAllText("../../Pic/" + gun.name + ".txt");
            }
            catch (Exception) { }

            Cntr_label.Text = gun.country;
            Clbr_label.Text = gun.kalibr;
            Type_label.Text = gun.strelba;
            Vid_label.Text = gun.vid;
            Stat_label.Text = gun.stat;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddSelectbtn_Click(object sender, EventArgs e)
        {
            if(SelectForm.GunList.ContainsKey(gun))
            {
                SelectForm.GunList[gun]++;
            }
            else
            {
                SelectForm.GunList.Add(gun, 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(gun.web);
            }
            catch (Exception) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void info_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
