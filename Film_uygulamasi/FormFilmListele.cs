using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Film_uygulamasi
{
    public partial class FormFilmListele : Form
    {
        public FormFilmListele()
        {
            InitializeComponent();
        }

        string baglanti = "Server=localhost;Database=sinema_veritabani;Uid=root;Pwd=''";

        private void FormFilmListele_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        void VeriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT *FROM filmler";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblFilmAd.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            lblTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            lblImdbPuan.Text = dgvListe.CurrentRow.Cells["imdb_puan"].Value.ToString();
            lblYil.Text = dgvListe.CurrentRow.Cells["yil"].Value.ToString();
            txtOzet.Text = dgvListe.CurrentRow.Cells["ozet"].Value.ToString();
            pbPoster.ImageLocation = dgvListe.CurrentRow.Cells["film_posteri"].Value.ToString();

        }


    }
}


