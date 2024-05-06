using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            if (AdminPassTB.Text == "")
            {

            }
            else if (AdminPassTB.Text == "eczane")
            {
                Login.user = "Admin";
                Dashboard obj = new Dashboard();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
                AdminPassTB.Text = "";
            }


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

        private void Savebtn_MouseEnter(object sender, EventArgs e)
        {
            Savebtn.BackColor = Color.LimeGreen;
        }

        private void Savebtn_MouseLeave(object sender, EventArgs e)
        {
           
            Savebtn.BackColor = Color.ForestGreen;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
