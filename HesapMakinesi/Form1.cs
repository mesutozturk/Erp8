namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn0.Click += BtnNumeric_Click;
            btn1.Click += BtnNumeric_Click;
            btn2.Click += BtnNumeric_Click;
            btn3.Click += BtnNumeric_Click;
            btn4.Click += BtnNumeric_Click;
            btn5.Click += BtnNumeric_Click;
            btn6.Click += BtnNumeric_Click;
            btn7.Click += BtnNumeric_Click;
            btn8.Click += BtnNumeric_Click;
            btn9.Click += BtnNumeric_Click;
        }

        private double _sonuc = 0;
        private void BtnNumeric_Click(object? sender, EventArgs e)
        {
            Button basilanButon = (Button)sender;
            string ekran = basilanButon.Text;
            txtEkran.Text += ekran;
        }

        private void BtnOperator_Click(object? sender, EventArgs e)
        {

        }
    }
}