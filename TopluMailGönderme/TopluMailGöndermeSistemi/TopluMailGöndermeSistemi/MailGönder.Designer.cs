
namespace TopluMailGöndermeSistemi
{
    partial class MailGönder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListMailDataGrid = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileLbl = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.AddMailBtn = new System.Windows.Forms.Button();
            this.RemoveMailBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteFileBtn = new System.Windows.Forms.Button();
            this.AddMailFileBtn = new System.Windows.Forms.Button();
            this.MailContentTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.SendMail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileNameLbl = new System.Windows.Forms.Label();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.ChangeEmailBtn = new System.Windows.Forms.Button();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.SelectFileErrorMessageLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListMailDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListMailDataGrid
            // 
            this.ListMailDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListMailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListMailDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email});
            this.ListMailDataGrid.Location = new System.Drawing.Point(12, 50);
            this.ListMailDataGrid.MultiSelect = false;
            this.ListMailDataGrid.Name = "ListMailDataGrid";
            this.ListMailDataGrid.RowTemplate.Height = 25;
            this.ListMailDataGrid.Size = new System.Drawing.Size(363, 376);
            this.ListMailDataGrid.TabIndex = 0;
            this.ListMailDataGrid.TabStop = false;
            // 
            // email
            // 
            this.email.HeaderText = "Gönderilicek Email Adresleri";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFileLbl
            // 
            this.SelectFileLbl.AutoSize = true;
            this.SelectFileLbl.Location = new System.Drawing.Point(85, 16);
            this.SelectFileLbl.Name = "SelectFileLbl";
            this.SelectFileLbl.Size = new System.Drawing.Size(0, 15);
            this.SelectFileLbl.TabIndex = 3;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(55, 432);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(320, 23);
            this.MailTextBox.TabIndex = 2;
            // 
            // AddMailBtn
            // 
            this.AddMailBtn.Location = new System.Drawing.Point(55, 461);
            this.AddMailBtn.Name = "AddMailBtn";
            this.AddMailBtn.Size = new System.Drawing.Size(159, 31);
            this.AddMailBtn.TabIndex = 3;
            this.AddMailBtn.Text = "Ekle";
            this.AddMailBtn.UseVisualStyleBackColor = true;
            this.AddMailBtn.Click += new System.EventHandler(this.AddMailBtn_Click);
            // 
            // RemoveMailBtn
            // 
            this.RemoveMailBtn.Location = new System.Drawing.Point(220, 461);
            this.RemoveMailBtn.Name = "RemoveMailBtn";
            this.RemoveMailBtn.Size = new System.Drawing.Size(155, 31);
            this.RemoveMailBtn.TabIndex = 4;
            this.RemoveMailBtn.Text = "Kaldır";
            this.RemoveMailBtn.UseVisualStyleBackColor = true;
            this.RemoveMailBtn.Click += new System.EventHandler(this.RemoveMailBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectFileErrorMessageLbl);
            this.groupBox1.Controls.Add(this.DeleteFileBtn);
            this.groupBox1.Controls.Add(this.AddMailFileBtn);
            this.groupBox1.Controls.Add(this.MailContentTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MailSubjectTextBox);
            this.groupBox1.Location = new System.Drawing.Point(394, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 376);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönderilicek Email";
            // 
            // DeleteFileBtn
            // 
            this.DeleteFileBtn.Location = new System.Drawing.Point(21, 340);
            this.DeleteFileBtn.Name = "DeleteFileBtn";
            this.DeleteFileBtn.Size = new System.Drawing.Size(487, 23);
            this.DeleteFileBtn.TabIndex = 8;
            this.DeleteFileBtn.Text = "Dosya Sil";
            this.DeleteFileBtn.UseVisualStyleBackColor = true;
            this.DeleteFileBtn.Visible = false;
            this.DeleteFileBtn.Click += new System.EventHandler(this.DeleteFileBtn_Click);
            // 
            // AddMailFileBtn
            // 
            this.AddMailFileBtn.Location = new System.Drawing.Point(21, 313);
            this.AddMailFileBtn.Name = "AddMailFileBtn";
            this.AddMailFileBtn.Size = new System.Drawing.Size(75, 23);
            this.AddMailFileBtn.TabIndex = 7;
            this.AddMailFileBtn.Text = "Dosya Ekle";
            this.AddMailFileBtn.UseVisualStyleBackColor = true;
            this.AddMailFileBtn.Click += new System.EventHandler(this.AddMailFileBtn_Click);
            // 
            // MailContentTextBox
            // 
            this.MailContentTextBox.Location = new System.Drawing.Point(76, 51);
            this.MailContentTextBox.Name = "MailContentTextBox";
            this.MailContentTextBox.Size = new System.Drawing.Size(432, 245);
            this.MailContentTextBox.TabIndex = 6;
            this.MailContentTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konu :";
            // 
            // MailSubjectTextBox
            // 
            this.MailSubjectTextBox.Location = new System.Drawing.Point(76, 22);
            this.MailSubjectTextBox.Name = "MailSubjectTextBox";
            this.MailSubjectTextBox.Size = new System.Drawing.Size(432, 23);
            this.MailSubjectTextBox.TabIndex = 5;
            // 
            // SendMail
            // 
            this.SendMail.BackColor = System.Drawing.Color.Lime;
            this.SendMail.Location = new System.Drawing.Point(749, 436);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(176, 56);
            this.SendMail.TabIndex = 8;
            this.SendMail.Text = "Toplu Email Gönder";
            this.SendMail.UseVisualStyleBackColor = false;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email :";
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.ForeColor = System.Drawing.Color.Red;
            this.FileNameLbl.Location = new System.Drawing.Point(13, 16);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(66, 15);
            this.FileNameLbl.TabIndex = 9;
            this.FileNameLbl.Text = "Dosya Adı :";
            this.FileNameLbl.Visible = false;
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(13, 12);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectFileBtn.TabIndex = 1;
            this.SelectFileBtn.Text = "Dosya Seç";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // ChangeEmailBtn
            // 
            this.ChangeEmailBtn.Location = new System.Drawing.Point(830, 16);
            this.ChangeEmailBtn.Name = "ChangeEmailBtn";
            this.ChangeEmailBtn.Size = new System.Drawing.Size(89, 23);
            this.ChangeEmailBtn.TabIndex = 13;
            this.ChangeEmailBtn.Text = "Email Değiştir";
            this.ChangeEmailBtn.UseVisualStyleBackColor = true;
            this.ChangeEmailBtn.Click += new System.EventHandler(this.ChangeEmailBtn_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(925, 20);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailLbl.Size = new System.Drawing.Size(0, 15);
            this.EmailLbl.TabIndex = 12;
            // 
            // SelectFileErrorMessageLbl
            // 
            this.SelectFileErrorMessageLbl.AutoSize = true;
            this.SelectFileErrorMessageLbl.Location = new System.Drawing.Point(240, 344);
            this.SelectFileErrorMessageLbl.Name = "SelectFileErrorMessageLbl";
            this.SelectFileErrorMessageLbl.Size = new System.Drawing.Size(0, 15);
            this.SelectFileErrorMessageLbl.TabIndex = 14;
            this.SelectFileErrorMessageLbl.Visible = false;
            // 
            // MailGönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 505);
            this.Controls.Add(this.ChangeEmailBtn);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.FileNameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemoveMailBtn);
            this.Controls.Add(this.AddMailBtn);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.SelectFileLbl);
            this.Controls.Add(this.ListMailDataGrid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MailGönder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.ControlText;
            ((System.ComponentModel.ISupportInitialize)(this.ListMailDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListMailDataGrid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label SelectFileLbl;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Button AddMailBtn;
        private System.Windows.Forms.Button RemoveMailBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox MailContentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MailSubjectTextBox;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FileNameLbl;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.Button AddMailFileBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button ChangeEmailBtn;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Button DeleteFileBtn;
        private System.Windows.Forms.Label SelectFileErrorMessageLbl;
    }
}

