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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            FormFilmEkle formFilmEkle = new FormFilmEkle();
            formFilmEkle.ShowDialog();
        }

        private void btnFilmListele_Click(object sender, EventArgs e)
        {
            FormFilmListele formFilmListele = new FormFilmListele();
            formFilmListele.ShowDialog();
        }
    }
}
