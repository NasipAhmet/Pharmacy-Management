namespace EczaneOtomasyonu
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginBTN = new Button();
            label8 = new Label();
            PasswordTB = new TextBox();
            label3 = new Label();
            UserNameTB = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = Color.ForestGreen;
            LoginBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBTN.ForeColor = SystemColors.ButtonHighlight;
            LoginBTN.Location = new Point(122, 335);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(220, 56);
            LoginBTN.TabIndex = 21;
            LoginBTN.Text = "Giriş";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += Savebtn_Click;
            LoginBTN.MouseEnter += LoginBTN_MouseEnter;
            LoginBTN.MouseLeave += LoginBTN_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(94, 284);
            label8.Name = "label8";
            label8.Size = new Size(58, 30);
            label8.TabIndex = 20;
            label8.Text = "Şifre";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTB.Location = new Point(219, 284);
            PasswordTB.Multiline = true;
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(203, 31);
            PasswordTB.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(46, 235);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 18;
            label3.Text = "Kullanıcı Adı";
            // 
            // UserNameTB
            // 
            UserNameTB.Font = new Font("Ebrima", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTB.Location = new Point(219, 232);
            UserNameTB.Multiline = true;
            UserNameTB.Name = "UserNameTB";
            UserNameTB.Size = new Size(203, 31);
            UserNameTB.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(183, 422);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 22;
            label2.Text = "Yönetici";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(426, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Location = new Point(32, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 3);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 130);
            label1.Name = "label1";
            label1.Size = new Size(204, 39);
            label1.TabIndex = 28;
            label1.Text = "Artı Eczanesi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(483, 486);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(LoginBTN);
            Controls.Add(label8);
            Controls.Add(PasswordTB);
            Controls.Add(label3);
            Controls.Add(UserNameTB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginBTN;
        private Label label8;
        private TextBox PasswordTB;
        private Label label3;
        private TextBox UserNameTB;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}