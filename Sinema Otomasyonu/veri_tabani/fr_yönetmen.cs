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
    public partial class fr_yönetmen : Form
    {
        public fr_yönetmen()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private int selectedYonetmenId;
        private object dgv_seans;

        private void bt_tabloekleme_Click(object sender, EventArgs e)
        {
       
            //string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb";
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string createTableQuery = @"
            //            CREATE TABLE Yonetmen (
            //                ID AUTOINCREMENT PRIMARY KEY,
            //                Ad TEXT(50),
            //                Soyad TEXT(50)
            //            )";

            //        using (OleDbCommand command = new OleDbCommand(createTableQuery, connection))
            //        {
            //            command.ExecuteNonQuery();
            //            MessageBox.Show("Yonetmen tablosu başarıyla oluşturuldu.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Bir hata oluştu: " + ex.Message);
            //    }
            //} //tablo ekleme kodu
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb";
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Yonetmen (Ad, Soyad) VALUES (@Ad, @Soyad)";
                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Yönetmen başarıyla eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void fr_yönetmen_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Sinama.mdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Yonetmen";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgv_yönetmen.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void dgv_yönetmen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_yönetmen.Rows[e.RowIndex];
                selectedYonetmenId = row.Cells["ID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["ID"].Value) : 0;
                txt_ad.Text = row.Cells["Ad"].Value.ToString();
                txt_soyad.Text = row.Cells["Soyad"].Value.ToString();
                dgv_yönetmen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_yönetmen.MultiSelect = false;
                dgv_yönetmen.ReadOnly = true;
            }
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sinama.mdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Yonetmen";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_yönetmen.DataSource = dataTable;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void bt_güncelle_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sinama.mdb";
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE Yonetmen SET Ad = @Ad, Soyad = @Soyad WHERE ID = @ID";

                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@ID", selectedYonetmenId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Yönetmen başarıyla güncellendi.");
                        btnLoadData_Click(null, null); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void bt_sil_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Sinama.mdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Yonetmen WHERE ID = @ID";

                    using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", selectedYonetmenId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Yönetmen başarıyla silindi.");
                        btnLoadData_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}


