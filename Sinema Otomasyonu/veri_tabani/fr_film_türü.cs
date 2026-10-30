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
    public partial class fr_film_türü : Form
    {
        public fr_film_türü()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            LoadData();
        }
        OleDbConnection bagla = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sinama.mdb");
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //// Veritabanı dosyasının yolunu belirtin
            //string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb";

            //// Access veritabanına bağlantıyı oluşturun
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //    try
            //    {
            //        // Bağlantıyı açın
            //        connection.Open();

            //        // Tabloyu oluşturmak için SQL sorgusu
            //        string createTableQuery = @"
            //CREATE TABLE Film_Turu (
            //    ID AUTOINCREMENT PRIMARY KEY,
            //    Ad TEXT(50)
            //)";

            //        // SQL sorgusunu çalıştırmak için OleDbCommand kullanın
            //        using (OleDbCommand command = new OleDbCommand(createTableQuery, connection))
            //        {
            //            command.ExecuteNonQuery();
            //            MessageBox.Show("Film_Turu tablosu başarıyla oluşturuldu.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Bir hata oluştu: " + ex.Message);
            //    }
            //}
        }//önemsiz

        private void LoadData()
        {
            try
            {
                bagla.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Film_Turu", bagla);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_tür.DataSource = dt;
                bagla.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bagla.Open();
                string query = "INSERT INTO Film_Turu (Ad) VALUES (@Ad)";
                OleDbCommand cmd = new OleDbCommand(query, bagla);
                cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
                cmd.ExecuteNonQuery();
                bagla.Close();

                MessageBox.Show("Film Türü Eklendi");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_tür.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgv_tür.SelectedRows[0].Cells["ID"].Value);
                    bagla.Open();
                    string query = "UPDATE Film_Turu SET Ad = @Ad WHERE ID = @ID";
                    OleDbCommand cmd = new OleDbCommand(query, bagla);
                    cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    bagla.Close();

                    MessageBox.Show("Film Türü Güncellendi");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek kaydı seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgv_tür.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgv_tür.SelectedRows[0].Cells["ID"].Value);
                    bagla.Open();
                    string query = "DELETE FROM Film_Turu WHERE ID = @ID";
                    OleDbCommand cmd = new OleDbCommand(query, bagla);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    bagla.Close();

                    MessageBox.Show("Film Türü Silindi");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Silinecek kaydı seçin.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_tür.Rows[e.RowIndex];
                txt_ad.Text = row.Cells["Ad"].Value.ToString();
            }
        }
    }
}
