using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arsenal
 {
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            string filename = "Избраное_" + Aut_Form.Login + ".csv";


            MailAddress from = new MailAddress("arsenal_2024_da@mail.ru");

            if (AdrestextBox.Text == "")
            {
                MessageBox.Show("Введите адрес электронной почты");
            }
            else
            {


                MailAddress to = new MailAddress(AdrestextBox.Text);

                using (MailMessage message = new MailMessage(from, to))

                using (SmtpClient client = new SmtpClient())
                {
                    message.Subject = "Список избраного";
                    message.Body = "Здравствуйте. " + Environment.NewLine + "Вот мой список";
                    message.IsBodyHtml = true;

                    File.AppendAllText(filename, "Наименование;Количество;Цена;Стоимость");


                    foreach (KeyValuePair<Gun, int> my_gun in SelectForm.GunList)
                    {
                        Gun gun = my_gun.Key;
                        File.AppendAllText(filename, Environment.NewLine + gun.name + ";"
                            + my_gun.Value + ";"
                            + gun.price + ";" 
                            + gun.price * my_gun.Value);
                    }

                    File.AppendAllText(filename, Environment.NewLine + "Итого: " + ";;;" + SelectForm.TotalPrice);

                    message.Attachments.Add(new Attachment(filename));

                    client.Host = "smtp.mail.ru";
                    client.Port = 25;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, "5tipGz4RwqPBD4UQ1Jyh");
                    client.Send(message);
                }

                MessageBox.Show("Список отправленно");
                Close();
                File.Delete(filename);
            }

            
        }
        public void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }
