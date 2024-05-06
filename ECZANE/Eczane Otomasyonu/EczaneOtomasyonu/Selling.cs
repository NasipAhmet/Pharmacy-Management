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
using System.Xml.Serialization;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.AxHost;

namespace EczaneOtomasyonu
{
    public partial class Selling : Form
    {
        public Selling()
        {

            InitializeComponent();
            IlacGoster();
            GetCustomer();
            SatıcıLBL6.Text = Login.user;
            kolonisim();



        }



        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");
        private void aratma()
        {

        }
        private void GetCustomer() //İlaç  yönetim kısmındaki fırma comboboxuna otamatık fırma numarası çekiyor.
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CustNum FROM CustomerTBL", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();//SqlDataReader oluşturulur ve SqlCommand'in ExecuteReader metodu kullanılarak sorgu çalıştırılır.
            DataTable dt = new DataTable();
            dt.Columns.Add("CustNum", typeof(int));
            dt.Load(Rdr);
            CustNOCB.ValueMember = "CustNum"; //ValueMember özelliği "Manıd" sütununu göstermesi için ayarlanır
            CustNOCB.DataSource = dt;
            Con.Close();
        }
        private void GetCustName()//Seçılen musterinın no'sunun ısmını cagırır.
        {
            Con.Open();
            string Query = "Select * from CustomerTBL where CustNum=" + CustNOCB.SelectedValue.ToString() + "";// ComboBox'tan seçilen değeri kullanarak bir SQL sorgusu oluşturur
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTB.Text = dr["CustName"].ToString();
            }




            Con.Close();
        }
        private void MiktarıGüncelle()//SATIŞTAN SONRA STOK MİKTARINI GUNCELLEDİK.
        {
            try
            {
                int yenimiktar = Stock - Convert.ToInt32(MedQtyTB.Text);
                Con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Medicinetbl SET MedQty=@MQ WHERE MedNUM=@Mkey", Con);
                cmd.Parameters.AddWithValue("@MQ", yenimiktar);
                cmd.Parameters.AddWithValue("@MKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İlaç Başarıyla Güncellendi");
                Con.Close();
                IlacGoster();
                //Reset();

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        private void InsertBill()
        {
            if (CustNameTB.Text == "")
            {
                MessageBox.Show("Müşteri seçiniz!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO billtablo (SName, CustNum,CunstName,BName,BAmount,BDate) VALUES (@UN, @CN,@Cna,@BName,@BA,@BD)", Con);
                    cmd.Parameters.AddWithValue("@UN", SatıcıLBL6.Text);
                    cmd.Parameters.AddWithValue("@CN", CustNOCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("Cna", CustNameTB.Text);
                    cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@BA", GrdTotal);
                    cmd.Parameters.AddWithValue("@BName", MedNameTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fatura Kaydedildi");
                    Con.Close();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void IlacGoster()
        {
            Con.Open();//Bu satır, fonksiyonun geriye herhangi bir değer döndürmediğini belirtir
            string Query = "Select * from Medicinetbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con); //SQL sorgusu ile veritabanı bağlantısını kullanarak bir veri seti alır.
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();//Bu satır, bir DataSet nesnesi oluşturur. DataSet, veri tabanından alınan verilerin depolandığı bir veri yapısıdır
            sda.Fill(ds);
            MedicinesDGV.DataSource = ds.Tables[0];  // DataGridView'in veri kaynağı olarak, DataSet içindeki ilk tabloyu kullanır.
            Con.Close();
        }

        int n = 0, GrdTotal;

        private void button1_Click(object sender, EventArgs e)
        {
            InsertBill();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            TotalLBL.Text = "0₺";
        }
        string MedName;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ARTI ECZANESI", new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID İLAÇ   MİKTAR     FİYAT      TOPLAM", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                MedID = Convert.ToInt32(row.Cells["Column1"].Value);
                MedName = "" + row.Cells["Column2"].Value;
                Medprice = Convert.ToInt32(row.Cells["Column3"].Value);
                MedQty = Convert.ToInt32(row.Cells["Column4"].Value);
                MedTot = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + MedID, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + MedName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + Medprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + MedQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + MedTot, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos += 20;
            }

            e.Graphics.DrawString("TOPLAM FİYAT :" + GrdTotal + "", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("****************ARTI ECZANESI*****************" + GrdTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (MedQtyTB.Text == "" || Convert.ToInt32(MedQtyTB.Text) == 0 || Convert.ToInt32(MedQtyTB.Text) > Stock)
            {
                MessageBox.Show("Hatalı Adet Girdiniz");
            }
           
            else
            {
                int total = Convert.ToInt32(MedQtyTB.Text) * Convert.ToInt32(MedPriceTB.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = MedNameTB.Text;
                newRow.Cells[2].Value = MedQtyTB.Text;
                newRow.Cells[3].Value = MedPriceTB.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                GrdTotal += total;
                TotalLBL.Text = GrdTotal + "₺";
                n++;
                MiktarıGüncelle();//yeni miktara guncelledik.


            }
        }
        int Key = 0, Stock;
        int MedID, Medprice, MedQty, MedTot;
        int pos = 60;

        private void MedicinesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedNameTB.Text = MedicinesDGV.SelectedRows[0].Cells[1].Value.ToString();
            //MedTypeCb.SelectedItem = MedicinesDGV.SelectedRows[0].Cells[2].Value.ToString();  
            MedQtyTB.Text = MedicinesDGV.SelectedRows[0].Cells[3].Value.ToString();
            Stock = Convert.ToInt32(MedQtyTB.Text = MedicinesDGV.SelectedRows[0].Cells[3].Value.ToString());
            MedPriceTB.Text = MedicinesDGV.SelectedRows[0].Cells[4].Value.ToString();
            //MadManCb.SelectedValue = MedicinesDGV.SelectedRows[0].Cells[5].Value.ToString();
            //MadManCb.Text = MedicinesDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (Convert.ToInt32(MedQtyTB.Text) == 0)
            {
                MessageBox.Show("Stok Yetersiz");
            }

            if (MedNameTB.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(MedicinesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void kolonisim()
        {
            List<string> columnHeaders1 = new List<string> { "İşlem-NO", "İlaç", "Kategori", "Adet", "Fiyat", "Firma No", "Firma" };

            // DataGridView'e sütun başlıklarını ayarla
            for (int i = 0; i < columnHeaders1.Count; i++)
            {
                if (i < MedicinesDGV.Columns.Count) // Sütun başlıklarını kontrol etmek için
                {
                    MedicinesDGV.Columns[i].HeaderText = columnHeaders1[i];
                }
            }
        }


        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {


        }

        private void CustNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustNOCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustNOCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustName();
        }

        private void TransactionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selling_Load(object sender, EventArgs e)
        {

        }

        private void panel11_DoubleClick(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            obj.Show();
            this.Hide();
        }

        private void panel12_DoubleClick(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();

        }

        private void panel15_DoubleClick(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
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
            if (SatıcıLBL6.Text == "Admin")
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

        private void SaveBTN_MouseEnter(object sender, EventArgs e)
        {
            SaveBTN.BackColor = Color.LimeGreen;
        }

        private void SaveBTN_MouseLeave(object sender, EventArgs e)
        {
            SaveBTN.BackColor = Color.ForestGreen;
        }

        private void PRINTBTN_MouseEnter(object sender, EventArgs e)
        {
            PRINTBTN.BackColor = Color.LimeGreen;
        }

        private void PRINTBTN_MouseLeave(object sender, EventArgs e)
        {
            PRINTBTN.BackColor = Color.ForestGreen;
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

        }

        private void SıfırlaBTN_Click(object sender, EventArgs e)
        {
            //  Reset();


        }

        private void yenileBTN_Click(object sender, EventArgs e)
        {

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

