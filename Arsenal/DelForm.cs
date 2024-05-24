using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arsenal
{
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.gun_list.Count; i++) 
            {
                DelcomboBox.Items.Add(Form1.gun_list[i].name);
            }
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            var result = DialogResult.No;

            if (DelcomboBox.Text != "")
            {
                result = MessageBox.Show("Вы действительно хотите удалить объект?",
                                            "Удаление объекта",
                                            MessageBoxButtons.YesNo);

            }
            else
            {
                MessageBox.Show("Вы должны выбрать объект");
                return;
            }

            if (result == DialogResult.Yes && DelcomboBox.Text != "")
            {
                File.Delete("Arsenal.txt");
                for (int i = 0; i < Form1.gun_list.Count; i++)
                {
                    if (DelcomboBox.Text == Form1.gun_list[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("Arsenal.txt",
                                                        Form1.gun_list[i].name + ", " +
                                                        Form1.gun_list[i].kalibr + ", " +
                                                        Form1.gun_list[i].strelba + ", " +
                                                        Form1.gun_list[i].price + ", " +
                                                        Form1.gun_list[i].country + ", " +
                                                        Form1.gun_list[i].web +
                                                        Environment.NewLine);
                    }
                }

                MessageBox.Show("Объект успешно удалён");
                Close();
            }
            
        }
    }
}
