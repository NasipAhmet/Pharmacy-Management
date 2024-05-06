namespace EczaneOtomasyonu
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox2 = new PictureBox();
            label3 = new Label();
            AdminPassTB = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Savebtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(419, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(46, 235);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 28;
            label3.Text = "Yetkili Şİfre";
            // 
            // AdminPassTB
            // 
            AdminPassTB.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AdminPassTB.Location = new Point(219, 232);
            AdminPassTB.Multiline = true;
            AdminPassTB.Name = "AdminPassTB";
            AdminPassTB.PasswordChar = '*';
            AdminPassTB.Size = new Size(203, 31);
            AdminPassTB.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Location = new Point(32, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 3);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 130);
            label1.Name = "label1";
            label1.Size = new Size(204, 39);
            label1.TabIndex = 25;
            label1.Text = "Artı Eczanesi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.ForestGreen;
            Savebtn.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Savebtn.ForeColor = SystemColors.ButtonHighlight;
            Savebtn.Location = new Point(125, 306);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(220, 56);
            Savebtn.TabIndex = 30;
            Savebtn.Text = "Giriş";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            Savebtn.MouseEnter += Savebtn_MouseEnter;
            Savebtn.MouseLeave += Savebtn_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(203, 389);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 31;
            label2.Text = "Geri";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(483, 486);
            Controls.Add(label2);
            Controls.Add(Savebtn);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(AdminPassTB);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label3;
        private TextBox AdminPassTB;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Savebtn;
        private Label label2;
    }
}