using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Film_uygulamasi
{
    public partial class FormFilmEkle : Form
    {
        public FormFilmEkle()
        {
            InitializeComponent();
        }
        string baglanti = "Server=localhost;Database=sinema_veritabani;Uid=root;Pwd=''";

        private void FormFilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();

            dosya.Filter = "Resim Dosyası|*.jpg;*.nef;*.png|Video|*.avi|Tüm Dosyalar|* .*";

            dosya.Title = "Resim Dosyası";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string kaynakDosya = dosya.FileName;

                string hedefDosya = Path.Combine("resimler", Guid.NewGuid() + ".jpg");


                if (!Directory.Exists("resimler"))
                {
                    Directory.CreateDirectory("resimler");
                }

                File.Copy(kaynakDosya, hedefDosya);

                pbPoster.ImageLocation = hedefDosya;

                pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "INSERT INTO filmler (filmad,tur,yıl,imdb_puan,film_posteri,ozet) VALUES (@filmad,@tur,@yil,@imdb_puan,@film_posteri,@ozet)";

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@filmad", txtFilmAd.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@imdb_puan", txtPuan.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@ozet", pbPoster.Text);
                cmd.Parameters.AddWithValue("@film_posteri", txtOzet.Text);



               

                DialogResult result = MessageBox.Show(" Film eklensin mi?", " Film Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();


                    txtFilmAd.Clear();
                    txtOzet.Clear();
                    txtPuan.Clear();
                    txtYil.Clear();
                    cmbTur.SelectedIndex = -1;

                }
            }
        }

       
    }
}

