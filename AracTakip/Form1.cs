using AracTakip.Data;
using AracTakip.Forms;
using AracTakip.Models;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private EnvanterContext _dataContext;
        private MarkaForm _markaForm;
        private ModelForm _modelForm;
        private void Form1_Load(object sender, EventArgs e)
        {
            _dataContext = new ();//TODO: Data katmanýndan sonra JSON dan okuyacaðýz.


        }
        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_markaForm == null || _markaForm.IsDisposed)
            {
                _markaForm = new MarkaForm();
                _markaForm.MdiParent = this;
                _markaForm.Text = "Marka Formu";
                _markaForm.Liste = _dataContext.Markalar;
                _markaForm.Show();
            }
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_modelForm == null || _modelForm.IsDisposed)
            {
                _modelForm = new ModelForm();
                _modelForm.MdiParent = this;
                _modelForm.Text = "Model Formu";
                _modelForm.Markalar = _dataContext.Markalar;
                _modelForm.Liste = _dataContext.Modeller;
                _modelForm.Show();
            }
        }

        
    }
}