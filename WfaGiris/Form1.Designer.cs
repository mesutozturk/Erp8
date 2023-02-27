namespace WfaGiris
{
    partial class Form1
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
            btnGiris = new Button();
            cbFalan = new CheckBox();
            dtpDogumTarihi = new DateTimePicker();
            lstKisiler = new ListBox();
            pbProfilFoto = new PictureBox();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbProfilFoto).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.Blue;
            btnGiris.Location = new Point(12, 12);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(142, 93);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // cbFalan
            // 
            cbFalan.AutoSize = true;
            cbFalan.Location = new Point(12, 111);
            cbFalan.Name = "cbFalan";
            cbFalan.Size = new Size(54, 19);
            cbFalan.TabIndex = 3;
            cbFalan.Text = "Falan";
            cbFalan.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(12, 136);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(200, 23);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(12, 165);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(120, 94);
            lstKisiler.TabIndex = 1;
            // 
            // pbProfilFoto
            // 
            pbProfilFoto.Image = Properties.Resources.portrait_caucasian_woman_smiling_53876_24998;
            pbProfilFoto.Location = new Point(12, 265);
            pbProfilFoto.Name = "pbProfilFoto";
            pbProfilFoto.Size = new Size(177, 174);
            pbProfilFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfilFoto.TabIndex = 4;
            pbProfilFoto.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(160, 12);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(73, 15);
            lblKullaniciAdi.TabIndex = 5;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(239, 9);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 481);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(pbProfilFoto);
            Controls.Add(lstKisiler);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(cbFalan);
            Controls.Add(btnGiris);
            Name = "Form1";
            Text = "İlk Form Uygulamam";
            ((System.ComponentModel.ISupportInitialize)pbProfilFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private CheckBox cbFalan;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private PictureBox pbProfilFoto;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
    }
}