
namespace EczaneOtomasyonu
{
    partial class SiparisGecmısı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisGecmısı));
            yenileBTN = new Button();
            AramaBTN = new Button();
            label13 = new Label();
            Musterigecmisara = new TextBox();
            label18 = new Label();
            TransactionDGV = new DataGridView();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TransactionDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // yenileBTN
            // 
            yenileBTN.BackColor = Color.ForestGreen;
            yenileBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            yenileBTN.ForeColor = SystemColors.ButtonHighlight;
            yenileBTN.Location = new Point(888, 29);
            yenileBTN.Name = "yenileBTN";
            yenileBTN.Size = new Size(128, 40);
            yenileBTN.TabIndex = 45;
            yenileBTN.Text = "yenile";
            yenileBTN.UseVisualStyleBackColor = false;
            yenileBTN.Click += yenileBTN_Click;
            // 
            // AramaBTN
            // 
            AramaBTN.BackColor = Color.ForestGreen;
            AramaBTN.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AramaBTN.ForeColor = SystemColors.ButtonHighlight;
            AramaBTN.Location = new Point(716, 29);
            AramaBTN.Name = "AramaBTN";
            AramaBTN.Size = new Size(138, 40);
            AramaBTN.TabIndex = 44;
            AramaBTN.Text = "Ara";
            AramaBTN.UseVisualStyleBackColor = false;
            AramaBTN.Click += AramaBTN_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.ForestGreen;
            label13.Location = new Point(310, 39);
            label13.Name = "label13";
            label13.Size = new Size(113, 30);
            label13.TabIndex = 43;
            label13.Text = "İŞLEM NO";
            // 
            // Musterigecmisara
            // 
            Musterigecmisara.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Musterigecmisara.Location = new Point(460, 39);
            Musterigecmisara.Multiline = true;
            Musterigecmisara.Name = "Musterigecmisara";
            Musterigecmisara.Size = new Size(232, 30);
            Musterigecmisara.TabIndex = 42;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Ebrima", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.ForestGreen;
            label18.Location = new Point(521, 645);
            label18.Name = "label18";
            label18.Size = new Size(219, 37);
            label18.TabIndex = 41;
            label18.Text = "Geçmiş İşlemler";
            // 
            // TransactionDGV
            // 
            TransactionDGV.AllowUserToResizeColumns = false;
            TransactionDGV.AllowUserToResizeRows = false;
            TransactionDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TransactionDGV.BackgroundColor = Color.Beige;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TransactionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TransactionDGV.ColumnHeadersHeight = 30;
            TransactionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TransactionDGV.DefaultCellStyle = dataGridViewCellStyle2;
            TransactionDGV.GridColor = Color.Silver;
            TransactionDGV.Location = new Point(12, 90);
            TransactionDGV.MultiSelect = false;
            TransactionDGV.Name = "TransactionDGV";
            TransactionDGV.RowHeadersVisible = false;
            TransactionDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TransactionDGV.RowTemplate.Height = 25;
            TransactionDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionDGV.Size = new Size(1298, 543);
            TransactionDGV.TabIndex = 40;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(1299, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 38);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 46;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // SiparisGecmısı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 700);
            ControlBox = false;
            Controls.Add(pictureBox9);
            Controls.Add(yenileBTN);
            Controls.Add(AramaBTN);
            Controls.Add(label13);
            Controls.Add(Musterigecmisara);
            Controls.Add(label18);
            Controls.Add(TransactionDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisGecmısı";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)TransactionDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button AramaBTN;
        private Label label13;
        private TextBox Musterigecmisara;
        private Label label18;
        private DataGridView TransactionDGV;
        private PictureBox pictureBox9;
        private Button yenileBTN;

    }
}