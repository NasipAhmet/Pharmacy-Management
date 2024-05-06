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

namespace EczaneOtomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Desktop\Documents\PharmacyDT.mdf;Integrated Security=True;Connect Timeout=30");

        public static string user;


        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "" || PasswordTB.Text == "") //Veritabanıdaki kullanıcı kontrol işlemi.

            {
                MessageBox.Show("Bilgileri Eksik Girdiniz");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)FROM Sellertbl Where SName='" + UserNameTB.Text + "'and SPass='" + PasswordTB.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    user = UserNameTB.Text;
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
                }
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void LoginBTN_MouseEnter(object sender, EventArgs e)
        {
            LoginBTN.BackColor = Color.LimeGreen;
        }

        private void LoginBTN_MouseLeave(object sender, EventArgs e)
        {
            LoginBTN.BackColor = Color.ForestGreen;
        }
    }
}
    

