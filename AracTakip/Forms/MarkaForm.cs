﻿using AracTakip.Data;
using AracTakip.Helpers;
using AracTakip.Models;

namespace AracTakip.Forms
{
    public partial class MarkaForm : Form
    {
        public MarkaForm()
        {
            InitializeComponent();
        }

        public EnvanterContext DataContext { get; set; }
        //public List<Marka> Liste { get; set; } = new();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Marka marka = new Marka()
                {
                    Ad = txtAd.Text
                };
                if (pbResim.Image != null)
                {
                    marka.Logo = (byte[])(new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[])));
                }
                else
                    marka.Logo = null;

                DataContext.Markalar.Add(marka);
                lstListe.DataSource = null;
                lstListe.DataSource = DataContext.Markalar;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Resim Seçiniz";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            dosyaAc.Filter = "Resim Dosyası |*.jpg;*.png;*.jpeg;";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(dosyaAc.FileName);
            }

        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                return;
            }
            Marka seciliMarka = (Marka)lstListe.SelectedItem;
            txtAd.Text = seciliMarka.Ad;
            if (seciliMarka.Logo != null)
            {
                pbResim.Image = (Image)(new ImageConverter().ConvertFrom(seciliMarka.Logo));
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                return;
            }
            Marka seciliMarka = (Marka)lstListe.SelectedItem;
            try
            {
                seciliMarka.Ad = txtAd.Text;
                if (pbResim.Image != null)
                {
                    seciliMarka.Logo = (byte[])(new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[])));
                }
                lstListe.DataSource = null;
                lstListe.DataSource = DataContext.Markalar;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void MarkaForm_Load(object sender, EventArgs e)
        {
            lstListe.DataSource = DataContext.Markalar;
        }
    }
}
