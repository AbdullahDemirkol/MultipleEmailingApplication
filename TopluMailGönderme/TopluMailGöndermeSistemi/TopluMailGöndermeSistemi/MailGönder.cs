using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TopluMailGöndermeSistemi.Extensions;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace TopluMailGöndermeSistemi
{
    public partial class MailGönder : Form
    {
        List<string> _mails=new List<string>();
        List<string> _filePaths = new List<string>();
        string[] _fileArray = new string[5];
        string _email = string.Empty;
        string _password = string.Empty;
        Label _deleteFilePath;
        int _sayaç = 0;

        public MailGönder(string email,string password)
        {
            _email = email;
            _password = password;
            InitializeComponent();
            EmailLbl.Text = _email;
            EmailLbl.Location = new Point(EmailLbl.Location.X - EmailLbl.Width, EmailLbl.Location.Y);
            ChangeEmailBtn.Location = new Point(EmailLbl.Location.X - 97, ChangeEmailBtn.Location.Y);
        }
        private void AddMailBtn_Click(object sender, EventArgs e)
        {
            string mail = MailTextBox.Text;
            if (mail.IsValidEmail())
            {
                if (!_mails.Where(p => p == mail).Any())
                {
                    _mails.Add(MailTextBox.Text);
                    ListMailDataGrid.Rows.Add(mail);
                }
                else
                {
                    MessageBox.Show("Aynı Email Adresi Bulunmaktadır.");
                }
            }
            else
            {
                MessageBox.Show("Girilen Email Hatalı.");
            }

            MailTextBox.Text = string.Empty;
        }

        private void RemoveMailBtn_Click(object sender, EventArgs e)
        {
            if (ListMailDataGrid.CurrentCell.Selected)
            {
                int selectedIndex = ListMailDataGrid.CurrentCell.RowIndex;
                var selectedRow = ListMailDataGrid.CurrentCell.Value.ToString();
                _mails.Remove(selectedRow);
                DataGridViewRow deletedRow = ListMailDataGrid.Rows[selectedIndex];
                ListMailDataGrid.Rows.Remove(deletedRow);
            }
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileDialog.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            fileDialog.RestoreDirectory = true;
            fileDialog.CheckFileExists = true;
            fileDialog.Title = "Excel Dosyası Seçiniz..";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;

                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    IExcelDataReader excelReader;
                    if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                    {
                        //'97-2003 format; .xls
                        excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else
                    {
                        //2007 format;.xlsx
                        excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    excelReader.GetExcelInformation(ListMailDataGrid, _mails);
                    excelReader.Close();
                }

                string fileName = fileDialog.SafeFileName;
                SelectFileLbl.Text = fileName;
                FileNameLbl.Visible = true;
                SelectFileBtn.Visible = false;
            }
            else
            {
                SelectFileLbl.Text = "Dosya Hatalı.";
            }
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            var sendMailBool= SendMails();
            if (sendMailBool)
            {
                MessageBox.Show("Mesaj Başarılı Bir Şekilde Yollanıldı.");
            }
        }

        private bool SendMails()
        {

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(_email, _password);
            var kontrol = true;
            if (_mails.Count()==0)
            {
                MessageBox.Show("Gönderilicek email adresleri girilmedi!!!", "Gönderilicek Email Adresleri Bulunamadı Hatası");
                kontrol = false;
            }
            else
            {
                foreach (var mail in _mails)
                {
                    MailMessage email = new MailMessage();
                    email.From = new MailAddress(_email);
                    email.To.Add(mail);
                    email.Subject = MailSubjectTextBox.Text;
                    email.IsBodyHtml = true;
                    email.Body = MailContentTextBox.Text;
                    foreach (var filePath in _filePaths)
                    {
                        email.Attachments.Add(new Attachment(filePath));
                    }
                    Thread.Sleep(100);
                    try
                    {
                        smtp.Send(email);
                    }
                    catch (SmtpException ex)
                    {
                        kontrol = false;
                        MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                    }
                }
            }
            return kontrol;
        }

        private void AddMailFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.RestoreDirectory = true;
            fileDialog.CheckFileExists = true;
            fileDialog.Title = "Gönderilicek Dosyayı Seçiniz..";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileName = fileDialog.SafeFileName;
                if (_filePaths.Contains(filePath))
                {
                    SelectFileErrorMessageLbl.Text="Bu dosya bulunmaktadır.";
                    SelectFileErrorMessageLbl.Visible = true;
                }
                else
                {

                    _filePaths.Add(filePath);

                    Label selectFile = new Label();
                    selectFile.Text = fileName.GetLine(13);
                    selectFile.Location = new Point(AddMailFileBtn.Location.X - 12, AddMailFileBtn.Location.Y);
                    selectFile.Visible = true;
                    selectFile.ForeColor = Color.Black;
                    selectFile.BorderStyle = BorderStyle.FixedSingle;
                    selectFile.Name = filePath;
                    selectFile.Click += new EventHandler(selectFile_Click);
                    groupBox1.Controls.Add(selectFile);

                    _fileArray[_sayaç] = filePath;
                    _sayaç += 1;


                    if (_filePaths.Count < 5)
                    {
                        AddMailFileBtn.Location = new Point(AddMailFileBtn.Location.X + 103, AddMailFileBtn.Location.Y);
                    }
                    else
                    {
                        AddMailFileBtn.Visible = false;
                    }
                    SelectFileErrorMessageLbl.Visible = false;
                }
            }
            else
            {
                SelectFileLbl.Text = "Dosya Hatalı.";
            }
        }

        private void ChangeEmailBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
        
        private void selectFile_Click(object sender, EventArgs e)
        {
            DeleteFileBtn.Visible = true;
            _deleteFilePath = (Label)sender;
            string[] splitFilePaths = _deleteFilePath.Name.Split('\\');
            DeleteFileBtn.Text = '"' + splitFilePaths[splitFilePaths.Length-1] + '"' + " isimli dosyayı sil";
        }
        private void DeleteFileBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Remove(_deleteFilePath);
            int index = Array.IndexOf(_fileArray, _deleteFilePath.Name);
            foreach (var item in _fileArray)
            {
                var itemIndex= Array.IndexOf(_fileArray, item);
                if (index< itemIndex&&_fileArray[itemIndex] !=null)
                {
                    Label selectFileLabel = (Label)groupBox1.Controls.Find(item, false)[0];
                    selectFileLabel.Location = new Point(selectFileLabel.Location.X - 103, selectFileLabel.Location.Y);
                    _fileArray[itemIndex - 1] = _fileArray[itemIndex];
                    _fileArray[itemIndex]=null;
                }
            }
            if (_filePaths.Count()==5)
            {
                AddMailFileBtn.Visible = true;
            }
            else
            {
                AddMailFileBtn.Location = new Point(AddMailFileBtn.Location.X - 103, AddMailFileBtn.Location.Y);
            }
            _filePaths.Remove(_deleteFilePath.Name);
            DeleteFileBtn.Visible = false;
            _sayaç -= 1;
        }
    }
}
