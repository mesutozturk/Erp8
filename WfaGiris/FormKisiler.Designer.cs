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
            label1.Location = new Point(57, 12);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 64);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 90);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "TCKN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 116);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 142);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 0;
            label6.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(85, 6);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(154, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(85, 32);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(154, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(85, 84);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(154, 23);
            txtTckn.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(85, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(85, 136);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(154, 23);
            txtTelefon.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(147, 165);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(92, 52);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(245, 6);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(154, 214);
            lstKisiler.TabIndex = 3;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(85, 58);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(154, 23);
            dtpDogumTarihi.TabIndex = 4;
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