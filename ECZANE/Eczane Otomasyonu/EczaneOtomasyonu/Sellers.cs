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
    public partial class Sellers : Form
    {

        public Sellers()
        {
            InitializeComponent();
            ShowSeller();
            SatıcıLBL5.Text = Login.user;
            kolonisim();



        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowSeller()
        {
            Con.Open();//Bu satır, fonksiyonun geriye herhangi bir değer döndürmediğini belirtir
            string Query = "Select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con); //SQL sorgusu ile veritabanı bağlantısını kullanarak bir veri seti alır.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();//Bu satır, bir DataSet nesnesi oluşturur. DataSet, veri tabanından alınan verilerin depolandığı bir veri yapısıdır
            sda.Fill(ds);
            SellersDGV.DataSource = ds.Tables[0];  // DataGridView'in veri kaynağı olarak, DataSet içindeki ilk tabloyu kullanır.
            Con.Close();
        }

        private void Reset()
        {
            SnameTB.Text = "";
            SPhoneTB.Text = "";
            SadressTB.Text = "";
            SpassTB.Text = "";
            SGenderCB.Text = "";
            Key = 0;
        }





        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (SnameTB.Text == "" || SPhoneTB.Text == "" || SpassTB.Text == "" || SGenderCB.SelectedIndex == -1 || SadressTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {

                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO SellerTbl (SName,STC,SDOB,SPhone,SAdd,SGen,SPass,SSalary) VALUES (@SN,@STC, @SD,@SP, @SA, @SG,@SPA,@SS)", Con);
                    cmd.Parameters.AddWithValue("@SN", SnameTB.Text);
                    cmd.Parameters.AddWithValue("@SD", SDate.Value.Date);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@SA", SadressTB.Text);
                    cmd.Parameters.AddWithValue("@SG", SGenderCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SPA", SpassTB.Text);
                    cmd.Parameters.AddWithValue("@SS", SSallaryTB.Text);
                    cmd.Parameters.AddWithValue("@STC", STC.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Eklendi");
                    Con.Close();
                    ShowSeller();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

        }
        int Key = 0;
        private void SellersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SnameTB.Text = SellersDGV.SelectedRows[0].Cells[1].Value.ToString();
            STC.Text = SellersDGV.SelectedRows[0].Cells[2].Value.ToString();
            SDate.Text = SellersDGV.SelectedRows[0].Cells[3].Value.ToString();
            SPhoneTB.Text = SellersDGV.SelectedRows[0].Cells[4].Value.ToString();
            SadressTB.Text = SellersDGV.SelectedRows[0].Cells[5].Value.ToString();
            SGenderCB.SelectedItem = SellersDGV.SelectedRows[0].Cells[6].Value.ToString();
            SpassTB.Text = SellersDGV.SelectedRows[0].Cells[7].Value.ToString();
            SSallaryTB.Text = SellersDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (SnameTB.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(SellersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Çalışan Seçiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM SellerTbl WHERE SNum=@SKey", Con);
                    cmd.Parameters.AddWithValue("@Skey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Baraşıyla Kaldırıldı");
                    Con.Close();
                    ShowSeller();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EdıtBTN_Click(object sender, EventArgs e)
        {
            if (SnameTB.Text == "" || STC.Text == "" || SPhoneTB.Text == "" || SpassTB.Text == "" || SGenderCB.SelectedIndex == -1 || SadressTB.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE  SellerTbl SET SName=@SN,STC=@STC,SDOB=@SD,SPhone=@SP,SAdd=@SA,SGen=@SG,SPass=@SPA,SSalary=@SS WHERE SNum=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SN", SnameTB.Text);
                    cmd.Parameters.AddWithValue("@SD", SDate.Value.Date);
                    cmd.Parameters.AddWithValue("@SP", SPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@SA", SadressTB.Text);
                    cmd.Parameters.AddWithValue("@SG", SGenderCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SPA", SpassTB.Text);
                    cmd.Parameters.AddWithValue("@SS", SSallaryTB.Text);
                    cmd.Parameters.AddWithValue("SKey", Key);
                    cmd.Parameters.AddWithValue("@STC", STC.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Çalışan Başarıyla Güncellendi");
                    Con.Close();
                    ShowSeller();
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
            List<string> columnHeaders = new List<string> { "NO", "İsim-Soyisim", "TC", "Doğum Tarihi", "Tel NO", "Adres", "Cinsiyet", "Şifre", "Maaş" };

            // DataGridView'e sütun başlıklarını ayarla
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                if (i < SellersDGV.Columns.Count) // Sütun başlıklarını kontrol etmek için
                {
                    SellersDGV.Columns[i].HeaderText = columnHeaders[i];
                }
            }
        }

        private void Sellers_Load(object sender, EventArgs e)
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
            if (SatıcıLBL5.Text == "Admin")
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

        private void SaveBTN_MouseHover(object sender, EventArgs e)
        {

        }

        private void SaveBTN_MouseEnter(object sender, EventArgs e)
        {
            SaveBTN.BackColor = Color.LimeGreen;
        }

        private void SaveBTN_MouseLeave(object sender, EventArgs e)
        {
            SaveBTN.BackColor = Color.ForestGreen;
        }

        private void EdıtBTN_MouseEnter(object sender, EventArgs e)
        {
            EdıtBTN.BackColor = Color.LimeGreen;
        }

        private void EdıtBTN_MouseLeave(object sender, EventArgs e)
        {
            EdıtBTN.BackColor = Color.ForestGreen;
        }

        private void DeleteBTN_MouseEnter(object sender, EventArgs e)
        {
            DeleteBTN.BackColor = Color.LimeGreen;
        }

        private void DeleteBTN_MouseLeave(object sender, EventArgs e)
        {
            DeleteBTN.BackColor = Color.ForestGreen;
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
            calısanarama();
        }
        private void calısanarama()
        {
            Con.Open();
            string Query = "Select * from SellerTbl where SPhone ='" + Calısanara.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellersDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void SıfırlaBTN_Click(object sender, EventArgs e)
        {
            Reset();
            ShowSeller();

        }

        private void Calısanara_TextChanged(object sender, EventArgs e)
        {
            if (STC.Text.Length > 11) //11den fazla hane girmesine izin vermez.
            {
                MessageBox.Show("Maksimum 11 karakter girebilirsiniz!");
                STC.Text = STC.Text.Substring(0, 11);
            }
        }

        private void STC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakter bir rakam değilse ve backspace (geri alma) tuşu değilse, işlemi iptal et
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            /*Girilen karakter bir harf değilse ve backspace (geri alma) tuşu değilse, işlemi iptal et
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }*/
        }

        private void STC_TextChanged(object sender, EventArgs e)
        {
            if (STC.Text.Length > 11) //11den fazla hane girmesine izin vermez.
            {
                MessageBox.Show("Maksimum 11 karakter girebilirsiniz!");
                STC.Text = STC.Text.Substring(0, 11);
            }
        }

        private void Calısanara_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakter bir rakam değilse ve backspace (geri alma) tuşu değilse, işlemi iptal et
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
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
