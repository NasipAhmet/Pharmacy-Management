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

namespace EczaneOtomasyonu
{
    public partial class Medicines : Form
    {
        public Medicines()
        {
            InitializeComponent();
            IlacGoster();
            FirmaNOCagır();
            SatıcıLBL.Text = Login.user;
            kolonisim();

        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete From Medicinetbl where MedNum=@Mkey", Con);
                    cmd.Parameters.AddWithValue("@MKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İlaç Başarıyla Silindi");
                    Con.Close();
                    IlacGoster();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");
        private void IlacGoster()
        {
            Con.Open();//Bu satır, fonksiyonun geriye herhangi bir değer döndürmediğini belirtir
            string Query = "Select * from medicinetbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con); //SQL sorgusu ile veritabanı bağlantısını kullanarak bir veri seti alır.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();//Bu satır, bir DataSet nesnesi oluşturur. DataSet, veri tabanından alınan verilerin depolandığı bir veri yapısıdır
            sda.Fill(ds);
            MedicinesDGV.DataSource = ds.Tables[0];  // DataGridView'in veri kaynağı olarak, DataSet içindeki ilk tabloyu kullanır.
            Con.Close();
        }

        private void Reset()
        {
            MadManTB.Text = "";
            MedNameTB.Text = "";
            MedPriceTB.Text = "";
            MedQtyTB.Text = "";
            MedTypeCb.SelectedIndex = 0;

        }

        private void FirmaNOCagır() //İlaç  yönetim kısmındaki fırma comboboxuna otamatık fırma numarası çekiyor.
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Manıd FROM Manufacturertbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();//SqlDataReader oluşturulur ve SqlCommand'in ExecuteReader metodu kullanılarak sorgu çalıştırılır.
            DataTable dt = new DataTable();
            dt.Columns.Add("Manıd", typeof(int));
            dt.Load(Rdr);
            MadManCb.ValueMember = "Manıd"; //ValueMember özelliği "Manıd" sütununu göstermesi için ayarlanır
            MadManCb.DataSource = dt;
            Con.Close();
        }
        private void Firmaismicagır()//Seçılen fırmaNO'sunun ısmını cagırır.
        {
            Con.Open();
            string Query = "Select * from Manufacturertbl where Manıd=" + MadManCb.SelectedValue.ToString() + "";// ComboBox'tan seçilen değeri kullanarak bir SQL sorgusu oluşturur
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MadManTB.Text = dr["ManName"].ToString();
            }




            Con.Close();
        }





        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (MedNameTB.Text == "" || MedPriceTB.Text == "" || MedQtyTB.Text == "" || MedTypeCb.SelectedIndex == -1 || MadManTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Medicinetbl (MedName,MedType,MedQty,MedPrice,MedManid,MedManufact) VALUES (@MN, @MT,@MQ, @MP, @MMI,@MM)", Con);
                    cmd.Parameters.AddWithValue("@MN", MedNameTB.Text);
                    cmd.Parameters.AddWithValue("@MT", MedTypeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", MedQtyTB.Text);
                    cmd.Parameters.AddWithValue("@MP", MedPriceTB.Text);
                    cmd.Parameters.AddWithValue("@MMI", MadManCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MM", MadManTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İlaç Başarıyla Eklendi");
                    Con.Close();
                    IlacGoster();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MadManCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MadManCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Firmaismicagır();
        }
        int key = 0;
        private void MedicinesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedNameTB.Text = MedicinesDGV.SelectedRows[0].Cells[1].Value.ToString();
            MedTypeCb.SelectedItem = MedicinesDGV.SelectedRows[0].Cells[2].Value.ToString();
            MedQtyTB.Text = MedicinesDGV.SelectedRows[0].Cells[3].Value.ToString();
            MedPriceTB.Text = MedicinesDGV.SelectedRows[0].Cells[4].Value.ToString();
            MadManCb.SelectedValue = MedicinesDGV.SelectedRows[0].Cells[5].Value.ToString();
            MadManCb.Text = MedicinesDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (MedNameTB.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(MedicinesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (MedNameTB.Text == "" || MedPriceTB.Text == "" || MedQtyTB.Text == "" || MedTypeCb.SelectedIndex == -1 || MadManTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Medicinetbl Set MedName=@MN, MedType=@MT,MedQty=@MQ, MedPrice=@MP, MedManid=@MMI, MedManufact=@MM WHERE MedNUM=@Mkey", Con);
                    cmd.Parameters.AddWithValue("@MN", MedNameTB.Text);
                    cmd.Parameters.AddWithValue("@MT", MedTypeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", MedQtyTB.Text);
                    cmd.Parameters.AddWithValue("@MP", MedPriceTB.Text);
                    cmd.Parameters.AddWithValue("@MMI", MadManCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MM", MadManTB.Text);
                    cmd.Parameters.AddWithValue("@MKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İlaç Başarıyla Güncellendi");
                    Con.Close();
                    IlacGoster();
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
            List<string> columnHeaders = new List<string> { "NO", "İlaç", "Kategori", "Adet", "Fiyat ", "Firma NO", "Firma" };

            // DataGridView'e sütun başlıklarını ayarla
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                if (i < MedicinesDGV.Columns.Count) // Sütun başlıklarını kontrol etmek için
                {
                    MedicinesDGV.Columns[i].HeaderText = columnHeaders[i];
                }
            }
        }

        private void MedNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_DoubleClick(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            obj.Show();
            this.Hide();

        }

        private void panel14_DoubleClick(object sender, EventArgs e)
        {
            Selling obj = new Selling();
            obj.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SatıcıLBL.Text == "Admin")
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

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button6_MouseHover(object sender, EventArgs e)
        {

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.LimeGreen;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.ForestGreen;
        }

        private void editBTN_MouseEnter(object sender, EventArgs e)
        {
            editBTN.BackColor = Color.LimeGreen;
        }

        private void editBTN_MouseLeave(object sender, EventArgs e)
        {
            editBTN.BackColor = Color.ForestGreen;
        }

        private void eleteBTN_MouseEnter(object sender, EventArgs e)
        {
            eleteBTN.BackColor = Color.LimeGreen;
        }

        private void eleteBTN_MouseLeave(object sender, EventArgs e)
        {
            eleteBTN.BackColor = Color.ForestGreen;
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
            button4.BackColor = Color.LimeGreen;
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

        private void SaveBTN_MouseEnter(object sender, EventArgs e)
        {
            SaveBTN.BackColor = Color.LimeGreen;
        }

        private void SaveBTN_MouseLeave(object sender, EventArgs e)
        {
            SaveBTN.BackColor = Color.ForestGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManuFacturer obj = new ManuFacturer();
            obj.Show();
            this.Hide();
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.LimeGreen;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.ForestGreen;
        }

        private void AramaBTN_Click(object sender, EventArgs e)
        {
            ılacarama();
        }
        private void ılacarama()
        {
            Con.Open();
            string Query = "Select * from Medicinetbl where MedName = '" + Ilacarama.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MedicinesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SıfırlaBTN_Click(object sender, EventArgs e)
        {
            IlacGoster();
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
