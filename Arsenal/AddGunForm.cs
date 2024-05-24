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
    public partial class AddGunForm : Form
    {
        public AddGunForm()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            int a;

            if(NametextBox.Text == "" || KalibrcomboBox.Text == "" || StrelbacomboBox.Text == "" || PricetextBox.Text == "" || CountrycomboBox.Text == "" || VidcomboBox.Text == "" || StatcomboBox.Text == "")
            {
                MessageBox.Show("Вам необходимо заполнить все поля с *");
                return;
            }

            if(!Int32.TryParse(PricetextBox.Text, out a))
            {
                MessageBox.Show("Цена должна быть указана в цифрах");
                return;
            }

            System.IO.File.AppendAllText("Arsenal.txt", 
                                        Environment.NewLine + 
                                        NametextBox.Text + ", " +
                                        KalibrcomboBox.Text + ", " +
                                        StrelbacomboBox.Text + ", " +
                                        PricetextBox.Text + ", " +
                                        CountrycomboBox.Text + ", " +
                                        VidcomboBox.Text + ", " +
                                        StatcomboBox.Text + ", " +
                                        WebtextBox.Text);
            System.IO.File.AppendAllText("../../Pic/" + NametextBox.Text + ".txt", InfotextBox.Text);

            if(FileName != "")
            {
                System.IO.File.Copy(FileName, "../../Pic/" + NametextBox.Text + ".png");
            }

            MessageBox.Show("Сохранено");
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        string FileName = "";

        #region добавить картинку
        private void Picbutton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                GunpictureBox.Load(FileName);
            }
        }
        #endregion

        private void AddGunForm_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
