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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace NESNE_PROJE
{
    public partial class fr_film_ekleme : Form
    {
        public fr_film_ekleme()
        {
            InitializeComponent();
 
            comb_salon.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_yönetmen.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_seans.DropDownStyle = ComboBoxStyle.DropDownList;
            comb_tür.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        OleDbConnection bagla = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb");
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void listeleSalon()
        {
            try
            {
                bagla.Open();
                OleDbCommand listele = new OleDbCommand("SELECT * FROM Salonlar", bagla);
                OleDbDataReader reader = listele.ExecuteReader();

                while (reader.Read())
                {
                    comb_salon.Items.Add(reader[0].ToString());
                }

                bagla.Close();
            }
            catch (Exception)
            {

                //throw;
            }
        }
        private void listeleSeans()
        {
            try
            {
                bagla.Open();
                OleDbCommand listele = new OleDbCommand("SELECT * FROM Seanslar", bagla);
                OleDbDataReader reader = listele.ExecuteReader();

                while (reader.Read())
                {
                    comb_seans.Items.Add(reader[0].ToString());
                }

                bagla.Close();
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void listeleYonetmen()
        {
            try
            {
                bagla.Open();
                OleDbCommand listele = new OleDbCommand("SELECT Ad, Soyad FROM Yonetmen", bagla);
                OleDbDataReader reader = listele.ExecuteReader();

                comb_yönetmen.Items.Clear();
                while (reader.Read())
                {
                    string adSoyad = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                    comb_yönetmen.Items.Add(adSoyad);
                }

                bagla.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        
        }
        private void listeleTur()
        {
            try
            {
                bagla.Open();
                OleDbCommand listele = new OleDbCommand("SELECT * FROM Film_Turu", bagla);
                OleDbDataReader reader = listele.ExecuteReader();

                comb_tür.Items.Clear();
                while (reader.Read())
                {
                    comb_tür.Items.Add(reader["Ad"].ToString());
                }

                bagla.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listeleSalon();
            listeleSeans();
            listeleYonetmen();
            listeleTur();
        }

        private void txt_anamenu_Click(object sender, EventArgs e)
        {
            fr_main anasayfa = new fr_main();
            anasayfa.Show();
            this.Close();
            
        }

        private void txt_cıkıs_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txt_afis_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Dosya tipleri(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pc_afis.Image = new Bitmap(open.FileName);
            }
        }

        private void txt_film_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                bagla.Open();
                OleDbCommand ekle = new OleDbCommand("insert into Filmler(Ad,Tur,Yonetmen,Seans,Salon) values('" + txt_film_adi.Text + "','" + comb_tür.Text + "','" + comb_yönetmen.Text + "','" + comb_seans.Text + "','" + comb_salon.Text + "')", bagla);
                ekle.ExecuteNonQuery();

                bagla.Close();

                MessageBox.Show("Film Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
