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

        public List<Marka> Markalar { get; set; }
        private void ModelForm_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Enum.GetNames(typeof(KasaTipleri));
        }
    }
}
