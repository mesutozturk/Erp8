namespace AracTakip.Forms
{
    partial class AracForm
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
            cmbMarka = new ComboBox();
            cmbModel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            lstListe = new ListBox();
            txtPlaka = new TextBox();
            SuspendLayout();
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(68, 12);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(172, 23);
            cmbMarka.TabIndex = 0;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(68, 41);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(172, 23);
            cmbModel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 44);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 73);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "Plaka";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(163, 99);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(77, 56);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(69, 99);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(77, 56);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(246, 12);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(234, 469);
            lstListe.TabIndex = 5;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(68, 70);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(172, 23);
            txtPlaka.TabIndex = 2;
            // 
            // AracForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 492);
            Controls.Add(txtPlaka);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbModel);
            Controls.Add(cmbMarka);
            Name = "AracForm";
            Text = "AracForm";
            Load += AracForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuncelle;
        private Button btnKaydet;
        private ListBox lstListe;
        private TextBox txtPlaka;
    }
}