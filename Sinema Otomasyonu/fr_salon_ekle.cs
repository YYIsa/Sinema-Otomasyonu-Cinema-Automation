using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace NESNE_PROJE
{
    public partial class fr_salon_ekle : Form
    {
        public fr_salon_ekle()
        {
            InitializeComponent();
         
        }
        OleDbConnection bagla = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb");
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void bt_salon_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                bagla.Open();
                OleDbCommand ekle = new OleDbCommand("insert into Salonlar(Ad) values('" + txt_salon_adi.Text + "')", bagla);
                ekle.ExecuteNonQuery();

                bagla.Close();

                MessageBox.Show("Salon Eklendi");
            }
            catch (Exception)
            {

              //  throw;
            }
        }

        private void bt_anamenu_Click(object sender, EventArgs e)
        {
            fr_main anasayfa = new fr_main();
            this.Close();
            anasayfa.Show();
        }

        private void bt_cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
