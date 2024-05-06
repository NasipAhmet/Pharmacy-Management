namespace EczaneOtomasyonu
{
    partial class Medicines
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicines));
            panel6 = new Panel();
            SıfırlaBTN = new Button();
            AramaBTN = new Button();
            label10 = new Label();
            Ilacarama = new TextBox();
            MedicinesDGV = new DataGridView();
            label11 = new Label();
            MedPriceTB = new TextBox();
            label9 = new Label();
            eleteBTN = new Button();
            editBTN = new Button();
            SaveBTN = new Button();
            label8 = new Label();
            MadManTB = new TextBox();
            MadManCb = new ComboBox();
            label7 = new Label();
            MedTypeCb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            MedQtyTB = new TextBox();
            label3 = new Label();
            MedNameTB = new TextBox();
            pictureBox12 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            label1 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            SatıcıLBL = new Label();
            pictureBox1 = new PictureBox();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MedicinesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(SıfırlaBTN);
            panel6.Controls.Add(AramaBTN);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(Ilacarama);
            panel6.Controls.Add(MedicinesDGV);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(MedPriceTB);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(eleteBTN);
            panel6.Controls.Add(editBTN);
            panel6.Controls.Add(SaveBTN);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(MadManTB);
            panel6.Controls.Add(MadManCb);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(MedTypeCb);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(MedQtyTB);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(MedNameTB);
            panel6.Location = new Point(358, 127);
            panel6.Name = "panel6";
            panel6.Size = new Size(1267, 895);
            panel6.TabIndex = 11;
            panel6.Paint += panel6_Paint;
            // 
            // SıfırlaBTN
            // 
            SıfırlaBTN.BackColor = Color.ForestGreen;
            SıfırlaBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SıfırlaBTN.ForeColor = SystemColors.ButtonHighlight;
            SıfırlaBTN.Location = new Point(860, 266);
            SıfırlaBTN.Name = "SıfırlaBTN";
            SıfırlaBTN.Size = new Size(129, 40);
            SıfırlaBTN.TabIndex = 35;
            SıfırlaBTN.Text = "Sıfırla";
            SıfırlaBTN.UseVisualStyleBackColor = false;
            SıfırlaBTN.Click += SıfırlaBTN_Click;
            // 
            // AramaBTN
            // 
            AramaBTN.BackColor = Color.ForestGreen;
            AramaBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AramaBTN.ForeColor = SystemColors.ButtonHighlight;
            AramaBTN.Location = new Point(703, 266);
            AramaBTN.Name = "AramaBTN";
            AramaBTN.Size = new Size(129, 40);
            AramaBTN.TabIndex = 34;
            AramaBTN.Text = "Ara";
            AramaBTN.UseVisualStyleBackColor = false;
            AramaBTN.Click += AramaBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(227, 272);
            label10.Name = "label10";
            label10.Size = new Size(186, 30);
            label10.TabIndex = 33;
            label10.Text = " Ilaç Arama (İsim)";
            // 
            // Ilacarama
            // 
            Ilacarama.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ilacarama.Location = new Point(449, 272);
            Ilacarama.Multiline = true;
            Ilacarama.Name = "Ilacarama";
            Ilacarama.Size = new Size(232, 30);
            Ilacarama.TabIndex = 32;
            // 
            // MedicinesDGV
            // 
            MedicinesDGV.AllowUserToResizeColumns = false;
            MedicinesDGV.AllowUserToResizeRows = false;
            MedicinesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MedicinesDGV.BackgroundColor = Color.Beige;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MedicinesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MedicinesDGV.ColumnHeadersHeight = 30;
            MedicinesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MedicinesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            MedicinesDGV.GridColor = Color.Silver;
            MedicinesDGV.Location = new Point(32, 335);
            MedicinesDGV.MultiSelect = false;
            MedicinesDGV.Name = "MedicinesDGV";
            MedicinesDGV.RowHeadersVisible = false;
            MedicinesDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MedicinesDGV.RowTemplate.Height = 25;
            MedicinesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MedicinesDGV.Size = new Size(1173, 469);
            MedicinesDGV.TabIndex = 23;
            MedicinesDGV.CellContentClick += MedicinesDGV_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(837, 52);
            label11.Name = "label11";
            label11.Size = new Size(60, 30);
            label11.TabIndex = 22;
            label11.Text = "Fiyat";
            // 
            // MedPriceTB
            // 
            MedPriceTB.Location = new Point(936, 41);
            MedPriceTB.Multiline = true;
            MedPriceTB.Name = "MedPriceTB";
            MedPriceTB.Size = new Size(220, 35);
            MedPriceTB.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(578, 830);
            label9.Name = "label9";
            label9.Size = new Size(172, 31);
            label9.TabIndex = 19;
            label9.Text = "Stok Sayısı";
            // 
            // eleteBTN
            // 
            eleteBTN.BackColor = Color.ForestGreen;
            eleteBTN.ForeColor = SystemColors.ButtonHighlight;
            eleteBTN.Location = new Point(735, 185);
            eleteBTN.Name = "eleteBTN";
            eleteBTN.Size = new Size(148, 49);
            eleteBTN.TabIndex = 18;
            eleteBTN.Text = "Sil";
            eleteBTN.UseVisualStyleBackColor = false;
            eleteBTN.Click += button3_Click;
            eleteBTN.MouseEnter += eleteBTN_MouseEnter;
            eleteBTN.MouseLeave += eleteBTN_MouseLeave;
            // 
            // editBTN
            // 
            editBTN.BackColor = Color.ForestGreen;
            editBTN.ForeColor = SystemColors.ButtonHighlight;
            editBTN.Location = new Point(555, 185);
            editBTN.Name = "editBTN";
            editBTN.Size = new Size(148, 49);
            editBTN.TabIndex = 17;
            editBTN.Text = "Düzenle";
            editBTN.UseVisualStyleBackColor = false;
            editBTN.Click += editBTN_Click;
            editBTN.MouseEnter += editBTN_MouseEnter;
            editBTN.MouseLeave += editBTN_MouseLeave;
            // 
            // SaveBTN
            // 
            SaveBTN.BackColor = Color.ForestGreen;
            SaveBTN.ForeColor = SystemColors.ButtonHighlight;
            SaveBTN.Location = new Point(378, 185);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(148, 49);
            SaveBTN.TabIndex = 16;
            SaveBTN.Text = "Kaydet";
            SaveBTN.UseVisualStyleBackColor = false;
            SaveBTN.Click += SaveBTN_Click;
            SaveBTN.MouseEnter += SaveBTN_MouseEnter;
            SaveBTN.MouseLeave += SaveBTN_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(378, 111);
            label8.Name = "label8";
            label8.Size = new Size(117, 30);
            label8.TabIndex = 15;
            label8.Text = "Üretici Adı";
            // 
            // MadManTB
            // 
            MadManTB.Enabled = false;
            MadManTB.Location = new Point(546, 101);
            MadManTB.Multiline = true;
            MadManTB.Name = "MadManTB";
            MadManTB.Size = new Size(220, 35);
            MadManTB.TabIndex = 14;
            // 
            // MadManCb
            // 
            MadManCb.FormattingEnabled = true;
            MadManCb.Location = new Point(546, 46);
            MadManCb.Name = "MadManCb";
            MadManCb.Size = new Size(220, 36);
            MadManCb.TabIndex = 13;
            MadManCb.SelectionChangeCommitted += MadManCb_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(14, 111);
            label7.Name = "label7";
            label7.Size = new Size(90, 30);
            label7.TabIndex = 12;
            label7.Text = "İlaç Tipi";
            // 
            // MedTypeCb
            // 
            MedTypeCb.FormattingEnabled = true;
            MedTypeCb.Items.AddRange(new object[] { "Antibiyotik", "Ağrı Kesici", "Soğuk Algınlığı", "Ateş Düşürücü", "Şurup", "Krem", "Mide asidi azaltıcı", "Tiroid ilacı", "Anksiyete ilacı", "Astım ilacı", "Kolesterol ilacı", "Antidepresan ", "Diğer" });
            MedTypeCb.Location = new Point(130, 106);
            MedTypeCb.Name = "MedTypeCb";
            MedTypeCb.Size = new Size(215, 36);
            MedTypeCb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(378, 52);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 10;
            label5.Text = "Üretici";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(837, 111);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 8;
            label4.Text = "Adet";
            // 
            // MedQtyTB
            // 
            MedQtyTB.Location = new Point(936, 101);
            MedQtyTB.Multiline = true;
            MedQtyTB.Name = "MedQtyTB";
            MedQtyTB.Size = new Size(220, 35);
            MedQtyTB.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(55, 51);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 6;
            label3.Text = "İsim";
            // 
            // MedNameTB
            // 
            MedNameTB.Location = new Point(130, 52);
            MedNameTB.Multiline = true;
            MedNameTB.Name = "MedNameTB";
            MedNameTB.Size = new Size(215, 35);
            MedNameTB.TabIndex = 5;
            MedNameTB.TextChanged += MedNameTB_TextChanged;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(742, 12);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(120, 79);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 15;
            pictureBox12.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(889, 30);
            label2.Name = "label2";
            label2.Size = new Size(325, 50);
            label2.TabIndex = 16;
            label2.Text = "Stok Düzenleme";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 1023);
            panel1.TabIndex = 26;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 846);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.ForestGreen;
            button8.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(15, 831);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 5);
            button8.Size = new Size(282, 83);
            button8.TabIndex = 43;
            button8.Text = "    İşlem Geçmişi";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            button8.MouseEnter += button8_MouseEnter;
            button8.MouseLeave += button8_MouseLeave;
            // 
            // button7
            // 
            button7.BackColor = Color.ForestGreen;
            button7.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(15, 742);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 5);
            button7.Size = new Size(282, 83);
            button7.TabIndex = 41;
            button7.Text = "  Firma";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            button7.MouseEnter += button7_MouseEnter;
            button7.MouseLeave += button7_MouseLeave;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(15, 248);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 5);
            button6.Size = new Size(282, 83);
            button6.TabIndex = 39;
            button6.Text = "         Anasayfa";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.MouseEnter += button6_MouseEnter;
            button6.MouseLeave += button6_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.OliveDrab;
            button3.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(15, 925);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 5);
            button3.Size = new Size(282, 83);
            button3.TabIndex = 38;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.ForestGreen;
            button5.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(15, 653);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 5);
            button5.Size = new Size(282, 83);
            button5.TabIndex = 37;
            button5.Text = "   Kasa";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseEnter += button5_MouseEnter;
            button5.MouseLeave += button5_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(15, 348);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 5);
            button1.Size = new Size(282, 83);
            button1.TabIndex = 34;
            button1.Text = "         İlaçlar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(15, 551);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 5);
            button4.Size = new Size(282, 83);
            button4.TabIndex = 36;
            button4.Text = "    Eleman";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 176);
            label1.Name = "label1";
            label1.Size = new Size(219, 45);
            label1.TabIndex = 33;
            label1.Text = "Artı Eczane";
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(15, 448);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 5);
            button2.Size = new Size(282, 83);
            button2.TabIndex = 35;
            button2.Text = "       Müşteriler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(343, 61);
            label6.Name = "label6";
            label6.Size = new Size(147, 45);
            label6.TabIndex = 40;
            label6.Text = "Kullanıcı";
            // 
            // SatıcıLBL
            // 
            SatıcıLBL.AutoSize = true;
            SatıcıLBL.Font = new Font("Ebrima", 24F, FontStyle.Italic, GraphicsUnit.Point);
            SatıcıLBL.ForeColor = Color.WhiteSmoke;
            SatıcıLBL.Location = new Point(506, 61);
            SatıcıLBL.Name = "SatıcıLBL";
            SatıcıLBL.Size = new Size(138, 45);
            SatıcıLBL.TabIndex = 24;
            SatıcıLBL.Text = "Kullanıcı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1566, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Medicines
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1637, 1018);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(SatıcıLBL);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(pictureBox12);
            Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Medicines";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicines";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MedicinesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel6;
        private PictureBox pictureBox12;
        private TextBox MedNameTB;
        private Label label2;
        private ComboBox MedTypeCb;
        private Label label5;
        private Label label4;
        private TextBox MedQtyTB;
        private Label label3;
        private Label label7;
        private Button SaveBTN;
        private Label label8;
        private TextBox MadManTB;
        private ComboBox MadManCb;
        private Label label9;
        private Button eleteBTN;
        private Button editBTN;
        private Label label11;
        private TextBox MedPriceTB;
        private DataGridView MedicinesDGV;
        private Panel panel1;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button4;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button6;
        private Label SatıcıLBL;
        private Label label6;
        private Button button7;
        private Button SıfırlaBTN;
        private Button AramaBTN;
        private Label label10;
        private TextBox Ilacarama;
        private Button button8;
        private PictureBox pictureBox3;
    }
}