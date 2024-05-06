using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EczaneOtomasyonu
{
    public partial class SiparisGecmısı : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection Con = new SqlConnection();

        public SiparisGecmısı()
        {         
                InitializeComponent(); 
                Con.ConnectionString = connectionString; 
                FaturaGoster();
                 kolonisim2();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MusteriArama()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM billtablo WHERE Bnum = @Bnum";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Bnum", Musterigecmisara.Text);
                var ds = new DataSet();
                sda.Fill(ds);
                TransactionDGV.DataSource = ds.Tables[0];
            }
        }

        private void FaturaGoster() //  form acıldıgı an listeyi gösterir.
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string Query = "SELECT * FROM billtablo"; 
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                var ds = new DataSet();
                sda.Fill(ds);
                TransactionDGV.DataSource = ds.Tables[0];
            }

        }

        private void AramaBTN_Click(object sender, EventArgs e)
        {
            MusteriArama();
        }


        private void yenileBTN_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM billtablo";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                var ds = new DataSet();
                sda.Fill(ds);
                TransactionDGV.DataSource = ds.Tables[0];
            }
        }

        private void kolonisim2()
        {
            List<string> columnHeaders = new List<string> { "İşlem-NO", "Eleman", "Müşteri-NO", "Müşteri","Ürün", "Fiyat","Tarih" };

            // DataGridView'e sütun başlıklarını ayarla
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                if (i < TransactionDGV.Columns.Count) // Sütun başlıklarını kontrol etmek için
                {
                    TransactionDGV.Columns[i].HeaderText = columnHeaders[i];
                }
            }
        }

    }

}
