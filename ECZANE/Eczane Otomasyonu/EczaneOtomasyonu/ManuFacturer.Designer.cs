namespace EczaneOtomasyonu
{
    partial class ManuFacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManuFacturer));
            label2 = new Label();
            panel6 = new Panel();
            SıfırlaBTN = new Button();
            AramaBTN = new Button();
            label10 = new Label();
            firmaarama = new TextBox();
            ManDate = new DateTimePicker();
            ManafacturerDGV = new DataGridView();
            label9 = new Label();
            deletebtn = new Button();
            editbtn = new Button();
            Savebtn = new Button();
            label8 = new Label();
            ManPhonetb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ManAddrestb = new TextBox();
            label3 = new Label();
            ManNametb = new TextBox();
            pictureBox12 = new PictureBox();
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
            SatıcıLBL4 = new Label();
            pictureBox1 = new PictureBox();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManafacturerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(854, 12);
            label2.Name = "label2";
            label2.Size = new Size(325, 50);
            label2.TabIndex = 20;
            label2.Text = "Firma Düzenleme";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(SıfırlaBTN);
            panel6.Controls.Add(AramaBTN);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(firmaarama);
            panel6.Controls.Add(ManDate);
            panel6.Controls.Add(ManafacturerDGV);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(deletebtn);
            panel6.Controls.Add(editbtn);
            panel6.Controls.Add(Savebtn);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(ManPhonetb);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(ManAddrestb);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(ManNametb);
            panel6.Location = new Point(342, 104);
            panel6.Name = "panel6";
            panel6.Size = new Size(1267, 863);
            panel6.TabIndex = 18;
            // 
            // SıfırlaBTN
            // 
            SıfırlaBTN.BackColor = Color.ForestGreen;
            SıfırlaBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SıfırlaBTN.ForeColor = SystemColors.ButtonHighlight;
            SıfırlaBTN.Location = new Point(893, 336);
            SıfırlaBTN.Name = "SıfırlaBTN";
            SıfırlaBTN.Size = new Size(129, 40);
            SıfırlaBTN.TabIndex = 39;
            SıfırlaBTN.Text = "Sıfırla";
            SıfırlaBTN.UseVisualStyleBackColor = false;
            SıfırlaBTN.Click += SıfırlaBTN_Click;
            // 
            // AramaBTN
            // 
            AramaBTN.BackColor = Color.ForestGreen;
            AramaBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AramaBTN.ForeColor = SystemColors.ButtonHighlight;
            AramaBTN.Location = new Point(736, 336);
            AramaBTN.Name = "AramaBTN";
            AramaBTN.Size = new Size(129, 40);
            AramaBTN.TabIndex = 38;
            AramaBTN.Text = "Ara";
            AramaBTN.UseVisualStyleBackColor = false;
            AramaBTN.Click += AramaBTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(262, 340);
            label10.Name = "label10";
            label10.Size = new Size(201, 30);
            label10.TabIndex = 37;
            label10.Text = "Firma Arama (İsim)";
            // 
            // firmaarama
            // 
            firmaarama.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firmaarama.Location = new Point(482, 342);
            firmaarama.Multiline = true;
            firmaarama.Name = "firmaarama";
            firmaarama.Size = new Size(232, 30);
            firmaarama.TabIndex = 36;
            firmaarama.TextChanged += firmaarama_TextChanged;
            firmaarama.KeyPress += firmaarama_KeyPress;
            // 
            // ManDate
            // 
            ManDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ManDate.Location = new Point(262, 163);
            ManDate.Name = "ManDate";
            ManDate.Size = new Size(234, 27);
            ManDate.TabIndex = 21;
            // 
            // ManafacturerDGV
            // 
            ManafacturerDGV.AllowUserToResizeColumns = false;
            ManafacturerDGV.AllowUserToResizeRows = false;
            ManafacturerDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ManafacturerDGV.BackgroundColor = Color.Beige;
            ManafacturerDGV.ColumnHeadersHeight = 30;
            ManafacturerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ManafacturerDGV.DefaultCellStyle = dataGridViewCellStyle1;
            ManafacturerDGV.GridColor = Color.Silver;
            ManafacturerDGV.Location = new Point(50, 389);
            ManafacturerDGV.MultiSelect = false;
            ManafacturerDGV.Name = "ManafacturerDGV";
            ManafacturerDGV.RowHeadersVisible = false;
            ManafacturerDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ManafacturerDGV.RowTemplate.Height = 25;
            ManafacturerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ManafacturerDGV.Size = new Size(1173, 422);
            ManafacturerDGV.TabIndex = 20;
            ManafacturerDGV.CellContentClick += ManafacturerDGV_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(557, 814);
            label9.Name = "label9";
            label9.Size = new Size(204, 30);
            label9.TabIndex = 19;
            label9.Text = "Üretici Firma Listesi";
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.ForestGreen;
            deletebtn.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.ForeColor = SystemColors.ButtonHighlight;
            deletebtn.Location = new Point(792, 227);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(148, 49);
            deletebtn.TabIndex = 18;
            deletebtn.Text = "Sil";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            deletebtn.MouseEnter += deletebtn_MouseEnter;
            deletebtn.MouseLeave += deletebtn_MouseLeave;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.ForestGreen;
            editbtn.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.ForeColor = SystemColors.ButtonHighlight;
            editbtn.Location = new Point(613, 227);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(148, 49);
            editbtn.TabIndex = 17;
            editbtn.Text = "Düzenle";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            editbtn.MouseEnter += editbtn_MouseEnter;
            editbtn.MouseLeave += editbtn_MouseLeave;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.ForestGreen;
            Savebtn.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Savebtn.ForeColor = SystemColors.ButtonHighlight;
            Savebtn.Location = new Point(428, 227);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(148, 49);
            Savebtn.TabIndex = 16;
            Savebtn.Text = "Kaydet";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            Savebtn.MouseEnter += Savebtn_MouseEnter;
            Savebtn.MouseLeave += Savebtn_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(122, 98);
            label8.Name = "label8";
            label8.Size = new Size(81, 30);
            label8.TabIndex = 15;
            label8.Text = "Tel NO";
            // 
            // ManPhonetb
            // 
            ManPhonetb.Location = new Point(262, 98);
            ManPhonetb.Multiline = true;
            ManPhonetb.Name = "ManPhonetb";
            ManPhonetb.Size = new Size(234, 45);
            ManPhonetb.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(77, 163);
            label5.Name = "label5";
            label5.Size = new Size(145, 30);
            label5.TabIndex = 10;
            label5.Text = "Katılım Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(909, 179);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 8;
            label4.Text = "Adres";
            // 
            // ManAddrestb
            // 
            ManAddrestb.Location = new Point(655, 23);
            ManAddrestb.Multiline = true;
            ManAddrestb.Name = "ManAddrestb";
            ManAddrestb.Size = new Size(554, 141);
            ManAddrestb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(107, 40);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 6;
            label3.Text = "Firma İsmi";
            // 
            // ManNametb
            // 
            ManNametb.Location = new Point(262, 40);
            ManNametb.Multiline = true;
            ManNametb.Name = "ManNametb";
            ManNametb.Size = new Size(234, 43);
            ManNametb.TabIndex = 5;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(732, 12);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(95, 63);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 19;
            pictureBox12.TabStop = false;
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
            panel1.Location = new Point(1, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 1023);
            panel1.TabIndex = 26;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 835);
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
            button8.Location = new Point(15, 818);
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
            button7.Location = new Point(15, 708);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 5);
            button7.Size = new Size(282, 83);
            button7.TabIndex = 41;
            button7.Text = "  Firma";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(11, 217);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 5);
            button6.Size = new Size(282, 83);
            button6.TabIndex = 39;
            button6.Text = "         Anasayfa";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.ControlRemoved += button6_ControlRemoved;
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
            button3.Location = new Point(15, 907);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 5);
            button3.Size = new Size(282, 83);
            button3.TabIndex = 38;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.ForestGreen;
            button5.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(15, 606);
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
            button1.Location = new Point(11, 317);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 5);
            button1.Size = new Size(282, 83);
            button1.TabIndex = 34;
            button1.Text = "         İlaçlar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
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
            button4.Location = new Point(11, 517);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 5);
            button4.Size = new Size(286, 83);
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
            label1.Location = new Point(45, 148);
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
            button2.Location = new Point(11, 417);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 5);
            button2.Size = new Size(282, 83);
            button2.TabIndex = 35;
            button2.Text = "       Müşteriler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(253, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(342, 20);
            label6.Name = "label6";
            label6.Size = new Size(147, 45);
            label6.TabIndex = 32;
            label6.Text = "Kullanıcı";
            // 
            // SatıcıLBL4
            // 
            SatıcıLBL4.AutoSize = true;
            SatıcıLBL4.Font = new Font("Ebrima", 24F, FontStyle.Italic, GraphicsUnit.Point);
            SatıcıLBL4.ForeColor = Color.WhiteSmoke;
            SatıcıLBL4.Location = new Point(508, 20);
            SatıcıLBL4.Name = "SatıcıLBL4";
            SatıcıLBL4.Size = new Size(138, 45);
            SatıcıLBL4.TabIndex = 40;
            SatıcıLBL4.Text = "Kullanıcı";
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
            // ManuFacturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1621, 979);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(SatıcıLBL4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(pictureBox12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManuFacturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManuFacturer";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ManafacturerDGV).EndInit();
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

        private Label label2;
        private Panel panel6;
        private DataGridView ManafacturerDGV;
        private Label label9;
        private Button deletebtn;
        private Button editbtn;
        private Button Savebtn;
        private Label label8;
        private TextBox ManPhonetb;
        private Label label5;
        private Label label4;
        private TextBox ManAddrestb;
        private Label label3;
        private TextBox ManNametb;
        private PictureBox pictureBox12;
        private DateTimePicker ManDate;
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
        private Label SatıcıLBL4;
        private Label label6;
        private Button button7;
        private Button SıfırlaBTN;
        private Button AramaBTN;
        private Label label10;
        private TextBox firmaarama;
        private Button button8;
        private PictureBox pictureBox3;
    }
}