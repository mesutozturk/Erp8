namespace BinarySerialization
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
            components = new System.ComponentModel.Container();
            txtAra = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            lstKisiler = new ListBox();
            cmsSil = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            btnKaydet = new Button();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtTckn = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbAvatar = new PictureBox();
            label7 = new Label();
            dosyaAc = new OpenFileDialog();
            cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.ForeColor = Color.Tomato;
            txtAra.Location = new Point(252, 13);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Ara";
            txtAra.Size = new Size(154, 23);
            txtAra.TabIndex = 23;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(92, 64);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(154, 23);
            dtpDogumTarihi.TabIndex = 17;
            // 
            // lstKisiler
            // 
            lstKisiler.ContextMenuStrip = cmsSil;
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(252, 42);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(154, 289);
            lstKisiler.TabIndex = 22;
            lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
            // 
            // cmsSil
            // 
            cmsSil.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(117, 26);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(116, 22);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(86, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(92, 279);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(154, 52);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(92, 142);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(154, 23);
            txtTelefon.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(92, 90);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(154, 23);
            txtTckn.TabIndex = 18;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(92, 38);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(154, 23);
            txtSoyad.TabIndex = 16;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(92, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(154, 23);
            txtAd.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 148);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 122);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 70);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 12;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 96);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 13;
            label4.Text = "TCKN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 44);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 14;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 18);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 15;
            label1.Text = "Ad";
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(92, 171);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(154, 102);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 24;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 258);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 10;
            label7.Text = "Fotoğraf";
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosya";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 355);
            Controls.Add(pbAvatar);
            Controls.Add(txtAra);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(lstKisiler);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtTckn);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private Button btnKaydet;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtTckn;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pbAvatar;
        private Label label7;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private OpenFileDialog dosyaAc;
    }
}