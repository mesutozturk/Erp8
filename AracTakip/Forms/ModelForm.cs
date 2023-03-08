using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracTakip.Data;
using AracTakip.Helpers;
using AracTakip.Models;

namespace AracTakip.Forms
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        public EnvanterContext DataContext { get; set; }
        //public List<Marka> Markalar { get; set; } = new();
        //public List<Model> Liste { get; set; } = new();

        private void ModelForm_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Enum.GetNames(typeof(KasaTipleri));
            cmbMarka.DataSource = DataContext.Markalar;
            lstListe.DataSource = DataContext.Modeller;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Model model = new()
                {
                    Ad = txtAd.Text,
                    KasaTipi = (KasaTipleri)Enum.Parse(typeof(KasaTipleri), cmbKasaTipi.SelectedItem.ToString()),
                    Marka = (Marka)cmbMarka.SelectedItem
                };

                DataContext.Modeller.Add(model);
                lstListe.DataSource = null;
                lstListe.DataSource = DataContext.Modeller;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            Model model = (Model)lstListe.SelectedItem;
            txtAd.Text = model.Ad;
            cmbKasaTipi.SelectedItem = Enum.GetName(typeof(KasaTipleri), model.KasaTipi);
            cmbMarka.SelectedItem = model.Marka;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null) return;
            Model model = (Model)lstListe.SelectedItem;
            model.Ad = txtAd.Text;
            model.KasaTipi = (KasaTipleri)Enum.Parse(typeof(KasaTipleri), cmbKasaTipi.SelectedItem.ToString());
            model.Marka = (Marka)cmbMarka.SelectedItem;
            lstListe.DataSource = null;
            lstListe.DataSource = DataContext.Modeller;
            DataHelper.Save(DataContext);
        }
    }
}
