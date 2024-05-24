using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal
{
    public partial class Reg_Form : Form
    {
        public Reg_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Regbutton1_Click(object sender, EventArgs e)
        {

            if (PassTB.Text == rePassTB.Text)
            {
                File.AppendAllText("users.txt", NameTB.Text + ", " + PassTB.Text + ", " + "0" + Environment.NewLine);
                MessageBox.Show("Вы зарегестрировались");
                Close();
            }
            else MessageBox.Show("Ошибка");
            
        }
    }
}
