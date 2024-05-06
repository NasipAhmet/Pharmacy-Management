using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyonu
{
    public partial class Customers : Form
    {

        public Customers()
        {
            InitializeComponent();
            HastaGoster();
            SatıcıLBL2.Text = Login.user;
            kolonisim();


        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");
        private void HastaGoster()
        {
            Con.Open();//Bu satır, fonksiyonun geriye herhangi bir değer döndürmediğini belirtir
            string Query = "Select * from CustomerTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con); //SQL sorgusu ile veritabanı bağlantısını kullanarak bir veri seti alır.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();//Bu satır, bir DataSet nesnesi oluşturur. DataSet, veri tabanından alınan verilerin depolandığı bir veri yapısıdır
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];  // DataGridView'in veri kaynağı olarak, DataSet içindeki ilk tabloyu kullanır.
            Con.Close();
        }
        private void musteriarama()
        {
            Con.Open();
            string Query = "Select * from CustomerTBL where TC ='" + Musteriara.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Reset()
        {
            CustomerNameTb.Text = "";
            CustomerPhoneTb.Text = "";
            CustomerGenderCb.SelectedIndex = 0;
            CustomerAdressTb.Text = "";
            TC.Text = "";
            Musteriara.Text = "";
        }

        private void SAVECustomerBTN_Click(object sender, EventArgs e)
        {

            if (CustomerNameTb.Text == "" || TC.Text == "" || CustomerPhoneTb.Text == "" || CustomerPhoneTb.Text == "" || CustomerGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTBL (CustName,TC, CustPhone, Custadd, CustDOB, CustGen) VALUES (@CN,@TC, @CP, @CA, @CD, @CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", CustomerNameTb.Text);
                    cmd.Parameters.AddWithValue("@TC", TC.Text);
                    cmd.Parameters.AddWithValue("@CP", CustomerPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustomerAdressTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CustomerDT.Value.Date); // "CustDOB" sütununa tarih değeri atanıyor
                    cmd.Parameters.AddWithValue("@CG", CustomerGenderCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla Eklendi");

                    Con.Close();
                    HastaGoster();
                    Reset();


                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView'de seçilen satırın belirli hücrelerinden değerleri alarak bu değerleri belirli metin kutularına atamak için;


            if (CustomerDGV.SelectedRows.Count > 0)
            {
                CustomerNameTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
                TC.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
                CustomerPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
                CustomerDT.Text = CustomerDGV.SelectedRows[0].Cells[5].Value.ToString();
                CustomerAdressTb.Text = CustomerDGV.SelectedRows[0].Cells[4].Value.ToString();
                CustomerGenderCb.SelectedItem = CustomerDGV.SelectedRows[0].Cells[6].Value.ToString();

                if (CustomerNameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                // Eğer hiçbir satır seçilmemişse, istenilen işlemleri yapmak yerine uygun bir mesaj gösterebilirsiniz.
                MessageBox.Show("Lütfen bir satır seçin.");
            }

        }

        private void DELETECustomerBTN_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Müşteri Seçiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete From CustomerTBL where CustNum=@Ckey", Con);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla Silindi");
                    Con.Close();
                    HastaGoster();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EDITCustomerBTN_Click(object sender, EventArgs e)
        {

            if (CustomerNameTb.Text == "" || TC.Text == "" || CustomerPhoneTb.Text == "" || CustomerPhoneTb.Text == "" || CustomerGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE CustomerTBL set CustName=@CN,TC=@TC, CustPhone=@CP, CustAdd=@CA, CustDOB=@CD, CustGen=@CG WHERE CustNum=@Ckey", Con);
                    cmd.Parameters.AddWithValue("@CN", CustomerNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustomerPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CustomerAdressTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CustomerDT.Value.Date); // "CustDOB" sütununa tarih değeri atanıyor
                    cmd.Parameters.AddWithValue("@CG", CustomerGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TC", TC.Text);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla Güncellendi");

                    Con.Close();
                    HastaGoster();
                    Reset();


                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CustomerNameTb_TextChanged(object sender, EventArgs e)
        {

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

            if (SatıcıLBL2.Text == "Admin")
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
        private void kolonisim()
        {
            List<string> columnHeaders = new List<string> { "NO", "TC", "İsim-Soyisim", "Tel NO", "Adress", "Doğum Tarihi", "Cinsiyet" };

            // DataGridView'e sütun başlıklarını ayarla
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                if (i < CustomerDGV.Columns.Count) // Sütun başlıklarını kontrol etmek için
                {
                    CustomerDGV.Columns[i].HeaderText = columnHeaders[i];
                }
            }
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

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.ForestGreen;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

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

        private void button6_MouseEnter_1(object sender, EventArgs e)
        {
            button6.BackColor = Color.LimeGreen;
        }

        private void button6_MouseLeave_1(object sender, EventArgs e)
        {
            button6.BackColor = Color.ForestGreen;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.ForestGreen;
        }

        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.LimeGreen;
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.ForestGreen;
        }

        private void button4_MouseEnter_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.LimeGreen;
        }

        private void button4_MouseLeave_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.ForestGreen;
        }

        private void button5_MouseEnter_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.LimeGreen;
        }

        private void button5_MouseLeave_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.ForestGreen;
        }

        private void SAVECustomerBTN_MouseEnter(object sender, EventArgs e)
        {
            SAVECustomerBTN.BackColor = Color.LimeGreen;
        }

        private void SAVECustomerBTN_MouseLeave(object sender, EventArgs e)
        {
            SAVECustomerBTN.BackColor = Color.ForestGreen;
        }

        private void EDITCustomerBTN_MouseEnter(object sender, EventArgs e)
        {
            EDITCustomerBTN.BackColor = Color.LimeGreen;
        }

        private void EDITCustomerBTN_MouseLeave(object sender, EventArgs e)
        {
            EDITCustomerBTN.BackColor = Color.ForestGreen;
        }

        private void DELETECustomerBTN_MouseEnter(object sender, EventArgs e)
        {
            DELETECustomerBTN.BackColor = Color.LimeGreen;
        }

        private void DELETECustomerBTN_MouseLeave(object sender, EventArgs e)
        {
            DELETECustomerBTN.BackColor = Color.ForestGreen;
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

        private void TC_TextChanged(object sender, EventArgs e)
        {
            if (TC.Text.Length > 11)
            {
                MessageBox.Show("Maksimum 11 karakter girebilirsiniz!");
                TC.Text = TC.Text.Substring(0, 11);
                TC.Select(TC.Text.Length, 0);
            }
        }

        private void AramaBTN_Click(object sender, EventArgs e)
        {
            musteriarama();
        }

        private void SıfırlaBTN_Click(object sender, EventArgs e)
        {
            Reset();
            HastaGoster();

        }

        private void TC_KeyPress(object sender, KeyPressEventArgs e)
        {   // Girilen tuşu kontrol et
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //e.KeyChar sayı olup olmadığını kontrol eder.
                //char.IsDigit metodu, bir karakterin bir rakam olup olmadığını belirler.
                //! operatörü, bu ifadenin tersini alır, yani karakter bir rakam değilse bu ifade true olur.

                //!char.IsControl(e.KeyChar) ifadesi, e.KeyChar değişkeninde bulunan karakterin bir kontrol karakteri olup olmadığını kontrol eder.
                //! operatörü, bu ifadenin tersini alır, yani karakter bir kontrol karakteri değilse bu ifade true olur.

                e.Handled = true;  // Girilen tuş bir sayı değilse ve kontrol tuşlarından biri de değilse, olayı işlemeye devam eder.


            }
        }

        private void Musteriara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Girilen tuş bir sayı değilse ve kontrol tuşlarından biri de değilse, olayı işlemeye devam eder.

                /*Girilen karakter text ise 
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }*/
            }
        }

        private void Musteriara_TextChanged(object sender, EventArgs e)
        {
            // TextBox'un içeriği 11 hane uzunluğunda değilse, içeriği temizle
            if (Musteriara.Text.Length > 11)
            {
                MessageBox.Show("Maksimum 11 karakter girebilirsiniz!");
                Musteriara.Text = Musteriara.Text.Substring(0, 11);
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
