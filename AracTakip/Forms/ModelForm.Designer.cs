namespace AracTakip.Forms
{
    partial class ModelForm
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
            btnGuncelle = new Button();
            btnKaydet = new Button();
            lstListe = new ListBox();
            txtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbMarka = new ComboBox();
            cmbKasaTipi = new ComboBox();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(198, 145);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(88, 75);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(90, 145);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 75);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 20;
            lstListe.Location = new Point(301, 8);
            lstListe.Margin = new Padding(3, 4, 3, 4);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(267, 404);
            lstListe.TabIndex = 9;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(90, 53);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(195, 27);
            txtAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 5;
            label1.Text = "Model Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 12);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Kasa Tipi";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(90, 8);
            cmbMarka.Margin = new Padding(3, 4, 3, 4);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(195, 28);
            cmbMarka.TabIndex = 10;
            // 
            // cmbKasaTipi
            // 
            cmbKasaTipi.FormattingEnabled = true;
            cmbKasaTipi.Location = new Point(90, 107);
            cmbKasaTipi.Margin = new Padding(3, 4, 3, 4);
            cmbKasaTipi.Name = "cmbKasaTipi";
            cmbKasaTipi.Size = new Size(195, 28);
            cmbKasaTipi.TabIndex = 11;
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 432);
            Controls.Add(cmbKasaTipi);
            Controls.Add(cmbMarka);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModelForm";
            Text = "ModelForm";
            Load += ModelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnKaydet;
        private ListBox lstListe;
        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMarka;
        private ComboBox cmbKasaTipi;
    }
}