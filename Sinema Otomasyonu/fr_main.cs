using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NESNE_PROJE
{
    public partial class fr_main : Form
    {
        public fr_main()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_film_Click(object sender, EventArgs e)
        {
            fr_film_ekleme film = new fr_film_ekleme();

            this.Hide();
            film.Show();
        }

        private void bt_seans_Click(object sender, EventArgs e)
        {
            fr_seans_ekle Seans = new fr_seans_ekle();

            this.Hide();
            Seans.Show();
        }

        private void bt_salon_Click(object sender, EventArgs e)
        {
            fr_salon_ekle Salonlar = new fr_salon_ekle();

            this.Hide();
            Salonlar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_seanslara_bak_Click(object sender, EventArgs e)
        {
            fr_seans_secme bak = new fr_seans_secme();

            this.Hide();
            bak.Show();
        }

        private void bt_yönetmen_Click(object sender, EventArgs e)
        {
            fr_yönetmen f = new fr_yönetmen();
            this.Hide();
            f.Show(); 
        }

        private void bt_film_turu_Click(object sender, EventArgs e)
        {
            fr_film_türü tür = new fr_film_türü();
            this.Hide();
            tür.Show(); 
        }
    }
}
