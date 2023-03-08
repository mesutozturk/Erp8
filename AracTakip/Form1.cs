using AracTakip.Forms;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaForm markaForm = new MarkaForm();
            markaForm.Show();
        }
    }
}