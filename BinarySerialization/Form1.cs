using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Kisi> _kisiler = new List<Kisi>();
        private Kisi? _seciliKisi;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_seciliKisi == null)
                try
                {
                    Kisi yeniKisi = new Kisi() //Object Initializer
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Tckn = txtTckn.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                    };

                    if (_memoryStream.Length > 0)
                    {
                        yeniKisi.Fotograf = _memoryStream.ToArray();
                    }

                    _memoryStream = new MemoryStream();


                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Oluþtu! {ex.Message}");
                }
            else
            {
                //Güncelleme iþlemi
                try
                {
                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.Tckn = txtTckn.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    _seciliKisi.Email = txtEmail.Text;
                    _seciliKisi.Telefon = txtTelefon.Text;
                    if (_memoryStream.Length > 0)
                    {
                        _seciliKisi.Fotograf = _memoryStream.ToArray();
                    }
                    FormuTemizle();
                    btnKaydet.Text = "Kaydet";
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Oluþtu! {ex.Message}");
                }
            }
        }

        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker dPicker)
                {
                    //(item as DateTimePicker).Value = DateTime.Now;
                    //((DateTimePicker)item).Value = DateTime.Now;
                    dPicker.Value = DateTime.Now;
                }
                else if (item is CheckBox cBox)
                    cBox.Checked = false;
                else if (item is ComboBox combo)
                    combo.SelectedIndex = -1;
                else if (item is ListBox listBox)
                {
                    listBox.SelectedIndex = -1;
                }
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                _seciliKisi = null;
                return;
            }

            _seciliKisi = lstKisiler.SelectedItem as Kisi;
            txtAd.Text = _seciliKisi.Ad;
            txtSoyad.Text = _seciliKisi.Soyad;
            txtTckn.Text = _seciliKisi.Tckn;
            txtTelefon.Text = _seciliKisi.Telefon;
            txtEmail.Text = _seciliKisi.Email;
            dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;
            pbAvatar.Image = _seciliKisi.Fotograf != null ? Image.FromStream(new MemoryStream(_seciliKisi.Fotograf)) : null;

            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            var seciliKisi = lstKisiler.SelectedItem as Kisi;

            DialogResult result = MessageBox.Show($"{seciliKisi.Ad} {seciliKisi.Soyad} kiþisini silmek istiyor musunuz?", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //lstKisiler.Items.Remove(seciliKisi);
                _kisiler.Remove(seciliKisi);
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
                FormuTemizle();
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string arama = txtAra.Text.ToLower();
            //if (arama.Length < 3) return;

            List<Kisi> sonuc = _kisiler
                .Where(item => item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) || item.Tckn.ToLower().StartsWith(arama))
                .ToList();

            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;
        }

        private MemoryStream _memoryStream = new MemoryStream();
        private int _bufferSize = 64;
        private byte[] _photoBytes = new byte[64];

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir fotoðraf dosyasý seçiniz";
            dosyaAc.Filter = "JPG Dosyalarý (*.jpg)|*.jpg|PNG Dosyalarý (*.png)|*.png";
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                _memoryStream = new MemoryStream();
                //FileStream fileStream = new FileStream(dosyaAc.FileName, FileMode.Open);
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(_photoBytes, 0, _bufferSize) != 0)
                {
                    _memoryStream.Write(_photoBytes, 0, _bufferSize);
                }
                fileStream.Close();
                fileStream.Dispose();

                //pbAvatar.Image = Image.FromStream(_memoryStream);
                pbAvatar.Image = new Bitmap(_memoryStream);

                //pbAvatar.ImageLocation = dosyaAc.FileName;
            }
        }

        private void dýþarýAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XML
            dosyaKaydet.Title = "Kiþileri XML olarak kaydet";
            dosyaKaydet.Filter = "XML Dosyalarý (*.xml)|*.xml";
            dosyaKaydet.FileName = "Kiþiler.xml";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, _kisiler);
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML dýþarý aktarma iþlemi baþarýlý: {dosyaKaydet.FileName}");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Kiþi XML dosyasýný seçiniz";
            dosyaAc.Filter = "XML Dosyalarý (*.xml)|*.xml";
            dosyaAc.FileName = "Kiþiler.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader textReader = new XmlTextReader(dosyaAc.FileName);
                if (serializer.CanDeserialize(textReader))
                {
                    _kisiler = serializer.Deserialize(textReader) as List<Kisi>;
                    MessageBox.Show($"{_kisiler.Count} kiþi sisteme baþarýyla eklendi");
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                else
                {
                    MessageBox.Show("Lütfen doðru xml dosyasýný seçin!");
                }
            }
        }

        private void dýþarýAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyasý seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyasý) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.json";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(_kisiler));
                writer.Close();
                writer.Dispose();
            }
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyasý seçiniz";
            dosyaAc.Filter = "(JSON Dosyasý) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.json";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(dosyaAc.FileName);
                StreamReader reader = new StreamReader(dosya);
                string dosyaIcerigi = reader.ReadToEnd();
                //_kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                _kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);

                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
            }
        }
    }
}