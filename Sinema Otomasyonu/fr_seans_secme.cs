using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace NESNE_PROJE
{
    public partial class fr_seans_secme : Form
    {
        private string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb";

        public fr_seans_secme()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }
        private OleDbConnection bagla = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sinama.mdb");
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoadData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Seanslar";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgv_seans.DataSource = dataTable;
                    dgv_seans.DataSource = dataTable;
                    dgv_seans.ReadOnly = true;
                    dgv_seans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv_seans.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            ListeleSeanslar();
        }

        private void ListeleSeanslar()
        {
            try
            {
                bagla.Open();
                string query = @"
            SELECT f.Ad AS FilmAdi, f.Tur, f.Yonetmen, f.Salon, f.Seans, s.Tarih, s.Saat, f.Durum
            FROM Filmler f
            INNER JOIN Seanslar s ON f.Seans = s.Ad";

                OleDbDataAdapter da = new OleDbDataAdapter(query, bagla);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgv_seans.DataSource = dt;
                bagla.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void dgv_seans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_seans.Rows[e.RowIndex];
                txt_ad.Text = row.Cells["FilmAdi"].Value.ToString();
                txt_tur.Text = row.Cells["Tur"].Value.ToString();
                txt_salon.Text = row.Cells["Salon"].Value.ToString();
                txt_seans.Text = row.Cells["Seans"].Value.ToString();
                txt_tarih.Text = row.Cells["Tarih"].Value.ToString();
                txt_saat.Text = row.Cells["Saat"].Value.ToString();
                txt_yonetmen.Text = row.Cells["Yonetmen"].Value.ToString();
            }
        }

        private void bt_seans_sec_Click_1(object sender, EventArgs e)
        {
            try
            {
                string durum = "Alındı";
                string updateQuery = "UPDATE Filmler SET Durum = @Durum WHERE Ad = @FilmAdi";
                using (OleDbCommand command = new OleDbCommand(updateQuery, bagla))
                {
                    command.Parameters.AddWithValue("@Durum", durum);
                    command.Parameters.AddWithValue("@FilmAdi", txt_ad.Text);
                    bagla.Open();
                    command.ExecuteNonQuery();
                    bagla.Close();
                }
                    MessageBox.Show("Seans seçildi ve durum güncellendi: Alındı");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void bt_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_seans.SelectedRows.Count > 0)
            {
                try
                {
                    string durum = "Alındı"; // Varsayılan olarak "Alındı" olarak işaretleyelim

                    // Seçilen satırın film adını alalım
                    string filmAdi = dgv_seans.SelectedRows[0].Cells["FilmAdi"].Value.ToString();

                    // Durumu güncelleyelim
                    bagla.Open();
                    string updateQuery = "UPDATE Filmler SET Durum = @Durum WHERE Ad = @FilmAdi";
                    using (OleDbCommand command = new OleDbCommand(updateQuery, bagla))
                    {
                        command.Parameters.AddWithValue("@Durum", durum);
                        command.Parameters.AddWithValue("@FilmAdi", filmAdi);
                        command.ExecuteNonQuery();
                    }
                    bagla.Close();

                    // DataGridView'i yeniden güncelleyelim
                    ListeleSeanslar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir film seçin.");
            }
        }
    }
}   

