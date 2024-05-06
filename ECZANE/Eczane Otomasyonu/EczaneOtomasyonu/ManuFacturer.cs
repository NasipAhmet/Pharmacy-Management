using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyonu
{

    public partial class ManuFacturer : Form
    {

        public ManuFacturer()
        {
            InitializeComponent();
            FirmaGoster();
            SatıcıLBL4.Text = Login.user;
            kolonisim();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");
        private void FirmaGoster()
        {
            Con.Open();//Bu satır, fonksiyonun geriye herhangi bir değer döndürmediğini belirtir
            string Query = "Select * from Manufacturertbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con); //SQL sorgusu ile veritabanı bağlantısını kullanarak bir veri seti alır.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();//Bu satır, bir DataSet nesnesi oluşturur. DataSet, veri tabanından alınan verilerin depolandığı bir veri yapısıdır
            sda.Fill(ds);
            ManafacturerDGV.DataSource = ds.Tables[0];  // DataGridView'in veri kaynağı olarak, DataSet içindeki ilk tabloyu kullanır.
            Con.Close();
        }//Fırmaları tabloda gösterir.

        private void Savebtn_Click(object sender, EventArgs e) //girilen firmayı tabloya ekler.
        {
            if (ManAddrestb.Text == "" || ManNametb.Text == "" || ManPhonetb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Manufacturertbl (ManName, ManAdd, ManPhone, ManDate) VALUES (@MN, @MA, @MP, @MD)", Con);
                    cmd.Parameters.AddWithValue("@MN", ManNametb.Text);
                    cmd.Parameters.AddWithValue("@MA", ManAddrestb.Text);
                    cmd.Parameters.AddWithValue("@MP", ManPhonetb.Text);
                    cmd.Parameters.AddWithValue("@MD", ManDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Firma Eklendi");
                    Con.Close();
                    FirmaGoster();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }



        }
        int key = 0;
        private void ManafacturerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //DataGridView'de seçilen satırın belirli hücrelerinden değerleri alarak bu değerleri belirli metin kutularına atamak için;


            if (ManafacturerDGV.SelectedRows.Count > 0)
            {
                ManNametb.Text = ManafacturerDGV.SelectedRows[0].Cells[1].Value.ToString();
                ManAddrestb.Text = ManafacturerDGV.SelectedRows[0].Cells[2].Value.ToString();
                ManPhonetb.Text = ManafacturerDGV.SelectedRows[0].Cells[3].Value.ToString();
                ManDate.Text = ManafacturerDGV.SelectedRows[0].Cells[4].Value.ToString();

                if (ManNametb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(ManafacturerDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                // Eğer hiçbir satır seçilmemişse, istenilen işlemleri yapmak yerine uygun bir mesaj gösterebilirsiniz.
                MessageBox.Show("Lütfen bir satır seçin.");
            }


        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Firma Seçiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete From Manufacturertbl where Manıd=@Mkey", Con);
                    cmd.Parameters.AddWithValue("@MKey", key);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    FirmaGoster();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Reset()
        {
            ManNametb.Text = "";
            ManAddrestb.Text = "";
            ManPhonetb.Text = "";
            key = 0;
        }
        private void editbtn_Click(object sender, EventArgs e)
        {
            if (ManAddrestb.Text == "" || ManNametb.Text == "" || ManPhonetb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Manufacturertbl Set ManName=@MN, ManAdd=@MA, ManPhone=@MP, ManDate=@MD WHERE Manıd=@Mkey", Con);
                    cmd.Parameters.AddWithValue("@MN", ManNametb.Text);
                    cmd.Parameters.AddWithValue("@MA", ManAddrestb.Text);
                    cmd.Parameters.AddWithValue("@MP", ManPhonetb.Text);
                    cmd.Parameters.AddWithValue("@MD", ManDate.Value.Date);
                    cmd.Parameters.AddWithValue("@MKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Firma Güncellendi");
                    Con.Close();
                    FirmaGoster();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void kolonisim()
        {
            List<string> columnHeaders = new List<string> { "NO", "Firma İsim", "Adres", "Numara", "Katılım Tarihi" };

            // DataGridView'e sütun başlıklarını ayarla
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                if (i < ManafacturerDGV.Columns.Count) // Sütun başlıklarını kontrol etmek için
                {
                    ManafacturerDGV.Columns[i].HeaderText = columnHeaders[i];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            obj.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SatıcıLBL4.Text == "Admin")
            {
                Sellers obj = new Sellers();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu alana erişim yetkiniz yoktur!");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Selling obj = new Selling();
            obj.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // MessageBox ile kullanıcıya soru sorma
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Uygulama Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kullanıcının seçimine göre işlem yapma
            if (result == DialogResult.Yes)
            {
                // Kullanıcı Evet'i seçtiğinde uygulamayı kapat
                Application.Exit();
            }
            // Hayır seçilirse herhangi bir işlem yapma, uygulama devam eder
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.LimeGreen;
        }

        private void button6_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.ForestGreen;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.ForestGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LimeGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.ForestGreen;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.ForestGreen;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.ForestGreen;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.LimeGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.ForestGreen;
        }

        private void Savebtn_MouseEnter(object sender, EventArgs e)
        {
            Savebtn.BackColor = Color.LimeGreen;
        }

        private void Savebtn_MouseLeave(object sender, EventArgs e)
        {
            Savebtn.BackColor = Color.ForestGreen;
        }

        private void editbtn_MouseEnter(object sender, EventArgs e)
        {
            editbtn.BackColor = Color.LimeGreen;
        }

        private void editbtn_MouseLeave(object sender, EventArgs e)
        {
            editbtn.BackColor = Color.ForestGreen;
        }

        private void deletebtn_MouseEnter(object sender, EventArgs e)
        {
            deletebtn.BackColor = Color.LimeGreen;
        }

        private void deletebtn_MouseLeave(object sender, EventArgs e)
        {
            deletebtn.BackColor = Color.ForestGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManuFacturer obj = new ManuFacturer();
            obj.Show();
            this.Hide();
        }

        private void AramaBTN_Click(object sender, EventArgs e)
        {
            firmarama();

        }

        private void firmarama()
        {
            Con.Open();
            string Query = "Select * from Manufacturertbl where ManName ='" + firmaarama.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ManafacturerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void SıfırlaBTN_Click(object sender, EventArgs e)
        {
            FirmaGoster();
        }

        private void firmaarama_TextChanged(object sender, EventArgs e)
        {

        }

        private void firmaarama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && firmaarama.Text != "")
            {
                e.Handled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            SiparisGecmısı obj = new SiparisGecmısı();
            obj.Show();

        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.LimeGreen;

        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.ForestGreen;
        }
    }
}
