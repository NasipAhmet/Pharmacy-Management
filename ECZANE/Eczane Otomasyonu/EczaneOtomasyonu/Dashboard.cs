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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            IlacSayısı();
            SatısSayısı();
            musterısayısı();
            SumAmt();
            GetSeller();
            GetBestSeller();
            GetBestCustomer();
            SatıcıLBL3.Text = Login.user;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");

        private void IlacSayısı()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*)from Medicinetbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Con.Close();


        }
        private void SatısSayısı()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*)from SellerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Con.Close();


        }
        private void musterısayısı()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*)from CustomerTBL", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Con.Close();


        }

        private void SumAmt()
        {
            /*Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BAmount) from billtablo where BDate", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SellAMTLBL.Text = dt.Rows[0][0].ToString() + " " + "TL";
            Con.Close();*/
        }

        private void SumAmtBySeller()
        {
            /*Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BAmount) from billtablo where SName='" + SellerCb.SelectedValue.ToString() + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            Con.Close();*/
        }
        private void GetBestSeller()
        {
            try
            {
                Con.Open();
                string InnerQuery = "Select Max(BAmount) from billtablo";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "Select SName from billtablo where BAmount='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Con.Close();
            }
            catch (Exception ex)
            {

                Con.Close();
            }
        }

        private void GetBestCustomer()
        {
            try
            {
                Con.Open();
                string InnerQuery = "Select Max(BAmount) from billtablo";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "Select CunstName from billtablo where BAmount='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Con.Close();
            }
            catch (Exception ex)
            {

                Con.Close();
            }
        }
        private void GetSeller()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SName FROM sellerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(String));
            dt.Load(Rdr);


            Con.Close();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void SellerCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumAmtBySeller();
        }

        private void SellAMTLBL_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
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
            if (SatıcıLBL3.Text == "Admin")
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

        private void pictureBox9_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            SiparisGecmısı obj = new SiparisGecmısı();
            obj.Show();

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.LimeGreen;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.ForestGreen;
        }
    }
}