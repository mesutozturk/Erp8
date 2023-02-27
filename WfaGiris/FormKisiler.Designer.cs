namespace WfaGiris
{
    partial class FormKisiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTckn = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            btnKaydet = new Button();
            lstKisiler = new ListBox();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 12);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 64);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 90);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "TCKN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 116);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 142);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 0;
            label6.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(89, 6);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(154, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(89, 32);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(154, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(89, 84);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(154, 23);
            txtTckn.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(89, 136);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(154, 23);
            txtTelefon.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(151, 165);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(92, 52);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(249, 6);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(154, 214);
            lstKisiler.TabIndex = 7;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(89, 58);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(154, 23);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // FormKisiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 232);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(lstKisiler);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtTckn);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormKisiler";
            Text = "FormKisiler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTckn;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private Button btnKaydet;
        private ListBox lstKisiler;
        private DateTimePicker dtpDogumTarihi;
    }
}