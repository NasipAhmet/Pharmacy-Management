namespace EczaneOtomasyonu
{
    partial class Selling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label11 = new Label();
            MedPriceTB = new TextBox();
            label9 = new Label();
            SaveBTN = new Button();
            label8 = new Label();
            CustNameTB = new TextBox();
            CustNOCB = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            MedQtyTB = new TextBox();
            label2 = new Label();
            label6 = new Label();
            pictureBox12 = new PictureBox();
            panel6 = new Panel();
            panel2 = new Panel();
            TotalLBL = new Label();
            label10 = new Label();
            PRINTBTN = new Button();
            MedicinesDGV = new DataGridView();
            label7 = new Label();
            label3 = new Label();
            MedNameTB = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            SatıcıLBL6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MedicinesDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BillDGV
            // 
            BillDGV.AllowUserToResizeColumns = false;
            BillDGV.AllowUserToResizeRows = false;
            BillDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillDGV.BackgroundColor = Color.Beige;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            BillDGV.DefaultCellStyle = dataGridViewCellStyle1;
            BillDGV.GridColor = Color.Silver;
            BillDGV.Location = new Point(18, 554);
            BillDGV.MultiSelect = false;
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersVisible = false;
            BillDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BillDGV.RowTemplate.Height = 25;
            BillDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillDGV.Size = new Size(1233, 349);
            BillDGV.TabIndex = 23;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "İLAÇ";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "MİKTAR";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "FİYAT";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "TOPLAM";
            Column5.Name = "Column5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(30, 167);
            label11.Name = "label11";
            label11.Size = new Size(60, 30);
            label11.TabIndex = 22;
            label11.Text = "Fiyat";
            // 
            // MedPriceTB
            // 
            MedPriceTB.Enabled = false;
            MedPriceTB.Location = new Point(195, 162);
            MedPriceTB.Multiline = true;
            MedPriceTB.Name = "MedPriceTB";
            MedPriceTB.Size = new Size(218, 35);
            MedPriceTB.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(793, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 30);
            label9.TabIndex = 19;
            label9.Text = "Stok Durumu";
            // 
            // SaveBTN
            // 
            SaveBTN.BackColor = Color.ForestGreen;
            SaveBTN.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBTN.ForeColor = SystemColors.ButtonHighlight;
            SaveBTN.Location = new Point(148, 339);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(185, 48);
            SaveBTN.TabIndex = 16;
            SaveBTN.Text = "Hesaba Ekle";
            SaveBTN.UseVisualStyleBackColor = false;
            SaveBTN.Click += SaveBTN_Click;
            SaveBTN.MouseEnter += SaveBTN_MouseEnter;
            SaveBTN.MouseLeave += SaveBTN_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(30, 105);
            label8.Name = "label8";
            label8.Size = new Size(128, 30);
            label8.TabIndex = 15;
            label8.Text = "Müşteri Adı";
            // 
            // CustNameTB
            // 
            CustNameTB.Enabled = false;
            CustNameTB.Location = new Point(195, 108);
            CustNameTB.Multiline = true;
            CustNameTB.Name = "CustNameTB";
            CustNameTB.Size = new Size(218, 35);
            CustNameTB.TabIndex = 14;
            CustNameTB.TextChanged += CustNameTB_TextChanged;
            // 
            // CustNOCB
            // 
            CustNOCB.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CustNOCB.FormattingEnabled = true;
            CustNOCB.Location = new Point(195, 53);
            CustNOCB.Name = "CustNOCB";
            CustNOCB.Size = new Size(218, 38);
            CustNOCB.TabIndex = 13;
            CustNOCB.SelectedIndexChanged += CustNOCB_SelectedIndexChanged;
            CustNOCB.SelectionChangeCommitted += CustNOCB_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(30, 56);
            label5.Name = "label5";
            label5.Size = new Size(127, 30);
            label5.TabIndex = 10;
            label5.Text = "Müşteri NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(30, 227);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 8;
            label4.Text = "Adet";
            // 
            // MedQtyTB
            // 
            MedQtyTB.Location = new Point(195, 222);
            MedQtyTB.Multiline = true;
            MedQtyTB.Name = "MedQtyTB";
            MedQtyTB.Size = new Size(218, 35);
            MedQtyTB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(951, -2);
            label2.Name = "label2";
            label2.Size = new Size(119, 50);
            label2.TabIndex = 20;
            label2.Text = "KASA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ebrima", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(358, 2);
            label6.Name = "label6";
            label6.Size = new Size(147, 45);
            label6.TabIndex = 4;
            label6.Text = "Kullanıcı";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(828, 2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(69, 45);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 19;
            pictureBox12.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(PRINTBTN);
            panel6.Controls.Add(MedicinesDGV);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(MedNameTB);
            panel6.Controls.Add(BillDGV);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(MedPriceTB);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(SaveBTN);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(CustNameTB);
            panel6.Controls.Add(CustNOCB);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(MedQtyTB);
            panel6.Location = new Point(358, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(1273, 985);
            panel6.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(TotalLBL);
            panel2.Location = new Point(18, 470);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 58);
            panel2.TabIndex = 33;
            // 
            // TotalLBL
            // 
            TotalLBL.AutoSize = true;
            TotalLBL.BackColor = Color.Transparent;
            TotalLBL.Font = new Font("Bahnschrift SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLBL.ForeColor = Color.WhiteSmoke;
            TotalLBL.Location = new Point(73, 7);
            TotalLBL.Name = "TotalLBL";
            TotalLBL.Size = new Size(59, 42);
            TotalLBL.TabIndex = 31;
            TotalLBL.Text = "0₺";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(81, 437);
            label10.Name = "label10";
            label10.Size = new Size(65, 30);
            label10.TabIndex = 32;
            label10.Text = "Tutar";
            // 
            // PRINTBTN
            // 
            PRINTBTN.BackColor = Color.Red;
            PRINTBTN.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PRINTBTN.ForeColor = SystemColors.ButtonHighlight;
            PRINTBTN.Location = new Point(228, 470);
            PRINTBTN.Name = "PRINTBTN";
            PRINTBTN.Size = new Size(185, 58);
            PRINTBTN.TabIndex = 29;
            PRINTBTN.Text = "İşlemi Kaydet";
            PRINTBTN.UseVisualStyleBackColor = false;
            PRINTBTN.Click += button1_Click;
            PRINTBTN.MouseEnter += PRINTBTN_MouseEnter;
            PRINTBTN.MouseLeave += PRINTBTN_MouseLeave;
            // 
            // MedicinesDGV
            // 
            MedicinesDGV.AllowUserToResizeColumns = false;
            MedicinesDGV.AllowUserToResizeRows = false;
            MedicinesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MedicinesDGV.BackgroundColor = Color.Beige;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MedicinesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MedicinesDGV.ColumnHeadersHeight = 30;
            MedicinesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MedicinesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            MedicinesDGV.GridColor = Color.Silver;
            MedicinesDGV.Location = new Point(439, 33);
            MedicinesDGV.MultiSelect = false;
            MedicinesDGV.Name = "MedicinesDGV";
            MedicinesDGV.RowHeadersVisible = false;
            MedicinesDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            MedicinesDGV.RowTemplate.Height = 25;
            MedicinesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MedicinesDGV.Size = new Size(812, 495);
            MedicinesDGV.TabIndex = 28;
            MedicinesDGV.CellContentClick += MedicinesDGV_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ebrima", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(597, 906);
            label7.Name = "label7";
            label7.Size = new Size(115, 45);
            label7.TabIndex = 26;
            label7.Text = "Fatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(30, 288);
            label3.Name = "label3";
            label3.Size = new Size(47, 30);
            label3.TabIndex = 25;
            label3.Text = "İlaç";
            // 
            // MedNameTB
            // 
            MedNameTB.Enabled = false;
            MedNameTB.Location = new Point(195, 283);
            MedNameTB.Multiline = true;
            MedNameTB.Name = "MedNameTB";
            MedNameTB.Size = new Size(218, 35);
            MedNameTB.TabIndex = 24;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 1023);
            panel1.TabIndex = 26;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 789);
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
            button8.Location = new Point(16, 774);
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
            button7.Location = new Point(15, 670);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 5);
            button7.Size = new Size(282, 83);
            button7.TabIndex = 40;
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
            button6.Location = new Point(15, 163);
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
            button3.Location = new Point(16, 899);
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
            button5.Location = new Point(14, 571);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 5);
            button5.Size = new Size(282, 83);
            button5.TabIndex = 37;
            button5.Text = "  Kasa";
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
            button1.Location = new Point(15, 263);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 5);
            button1.Size = new Size(282, 83);
            button1.TabIndex = 34;
            button1.Text = "    İlaçlar";
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
            button4.Location = new Point(15, 473);
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
            label1.Location = new Point(49, 115);
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
            button2.Location = new Point(16, 372);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 5);
            button2.Size = new Size(282, 83);
            button2.TabIndex = 35;
            button2.Text = "        Müşteriler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // SatıcıLBL6
            // 
            SatıcıLBL6.AutoSize = true;
            SatıcıLBL6.Font = new Font("Ebrima", 24F, FontStyle.Italic, GraphicsUnit.Point);
            SatıcıLBL6.ForeColor = Color.WhiteSmoke;
            SatıcıLBL6.Location = new Point(511, 2);
            SatıcıLBL6.Name = "SatıcıLBL6";
            SatıcıLBL6.Size = new Size(138, 45);
            SatıcıLBL6.TabIndex = 41;
            SatıcıLBL6.Text = "Kullanıcı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1588, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Selling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1637, 1018);
            Controls.Add(SatıcıLBL6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox12);
            Controls.Add(panel6);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Selling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selling";
            Load += Selling_Load;
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MedicinesDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView BillDGV;
        private Label label11;
        private TextBox MedPriceTB;
        private Label label9;
        private Button SaveBTN;
        private Label label8;
        private TextBox CustNameTB;
        private ComboBox CustNOCB;
        private Label label5;
        private Label label4;
        private TextBox MedQtyTB;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox12;
        private Panel panel6;
        private Label label7;
        private Label label3;
        private TextBox MedNameTB;
        private Button PRINTBTN;
        private DataGridView MedicinesDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label TotalLBL;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
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
        private Label SatıcıLBL6;
        private Panel panel2;
        private Label label10;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox3;
    }
}