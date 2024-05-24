using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Arsenal
{
    public partial class FeetBack : Form
    {
        public FeetBack()
        {
            InitializeComponent();
        }

        private void SubjectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("arsenal_2024_da@mail.ru");

            if (SubjectcomboBox.Text == "")
            {
                MessageBox.Show("Тема сообщений не выбрана");
            }
            else
            {


                MailAddress to = new MailAddress("arsenal_2024_da@mail.ru");

                using (MailMessage message = new MailMessage(from, to))

                using (SmtpClient client = new SmtpClient())
                {
                    message.Subject = SubjectcomboBox.Text;
                    message.Body = BodytextBox.Text;
                    message.IsBodyHtml = true;

                    client.Host = "smtp.mail.ru";
                    client.Port = 25;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, "5tipGz4RwqPBD4UQ1Jyh");
                    client.Send(message);
                }

                MessageBox.Show("Сообщение отправленно");
                Close();
            }
        }
    }
}
