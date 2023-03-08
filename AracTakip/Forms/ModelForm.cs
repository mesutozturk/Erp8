using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracTakip.Models;

namespace AracTakip.Forms
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        public List<Marka> Markalar { get; set; } = new();
        public List<Model> Liste { get; set; } = new();

        private void ModelForm_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Enum.GetNames(typeof(KasaTipleri));
            cmbMarka.DataSource = Markalar;
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

                Liste.Add(model);
                lstListe.DataSource = null;
                lstListe.DataSource = Liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
