using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopluMailGöndermeSistemi.Extensions;

namespace TopluMailGöndermeSistemi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (EmailText.Text.IsValidEmail() && ApplicationCodeText.Text.CheckApplicationCode())
            {
                MailGönder mailGönderPage = new MailGönder(EmailText.Text, ApplicationCodeText.Text);
                mailGönderPage.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Verilen Bilgiler Hatalı.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ApplicationPicture applicationPicture = new ApplicationPicture();
            applicationPicture.Name = "applicationPicture";
            Form appPicture = Application.OpenForms["applicationPicture"];
            if (appPicture == null)
            {
                applicationPicture.Show();
            }
            else
            {
                appPicture.Close();
                applicationPicture.Show();
            }
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                ApplicationCodeText.PasswordChar= '\0';
            }
            else
            {
                ApplicationCodeText.PasswordChar= '*';
            }
        }

    }
}
