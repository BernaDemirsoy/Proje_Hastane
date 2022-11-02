namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkbilgileridüzenle = new System.Windows.Forms.LinkLabel();
            this.btnrandevual = new System.Windows.Forms.Button();
            this.rchsikayet = new System.Windows.Forms.RichTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.LblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgiler";
            // 
            // LblAdsoyad
            // 
            this.LblAdsoyad.AutoSize = true;
            this.LblAdsoyad.Location = new System.Drawing.Point(149, 126);
            this.LblAdsoyad.Name = "LblAdsoyad";
            this.LblAdsoyad.Size = new System.Drawing.Size(82, 24);
            this.LblAdsoyad.TabIndex = 3;
            this.LblAdsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad-Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(149, 81);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(120, 24);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lnkbilgileridüzenle);
            this.groupBox2.Controls.Add(this.btnrandevual);
            this.groupBox2.Controls.Add(this.rchsikayet);
            this.groupBox2.Controls.Add(this.cmbdoktor);
            this.groupBox2.Controls.Add(this.cmbbrans);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 414);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(124, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(195, 32);
            this.txtId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // lnkbilgileridüzenle
            // 
            this.lnkbilgileridüzenle.AutoSize = true;
            this.lnkbilgileridüzenle.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkbilgileridüzenle.Location = new System.Drawing.Point(6, 381);
            this.lnkbilgileridüzenle.Name = "lnkbilgileridüzenle";
            this.lnkbilgileridüzenle.Size = new System.Drawing.Size(169, 24);
            this.lnkbilgileridüzenle.TabIndex = 11;
            this.lnkbilgileridüzenle.TabStop = true;
            this.lnkbilgileridüzenle.Text = "Bilgilerimi Düzenle";
            this.lnkbilgileridüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbilgileridüzenle_LinkClicked);
            // 
            // btnrandevual
            // 
            this.btnrandevual.BackColor = System.Drawing.Color.Ivory;
            this.btnrandevual.Location = new System.Drawing.Point(124, 347);
            this.btnrandevual.Name = "btnrandevual";
            this.btnrandevual.Size = new System.Drawing.Size(195, 36);
            this.btnrandevual.TabIndex = 10;
            this.btnrandevual.Text = "Randevu Al";
            this.btnrandevual.UseVisualStyleBackColor = false;
            this.btnrandevual.Click += new System.EventHandler(this.btnrandevual_Click);
            // 
            // rchsikayet
            // 
            this.rchsikayet.Location = new System.Drawing.Point(124, 151);
            this.rchsikayet.Name = "rchsikayet";
            this.rchsikayet.Size = new System.Drawing.Size(195, 182);
            this.rchsikayet.TabIndex = 9;
            this.rchsikayet.Text = "";
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(124, 114);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(195, 32);
            this.cmbdoktor.TabIndex = 8;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(124, 76);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(195, 32);
            this.cmbbrans.TabIndex = 7;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şikayetler:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(387, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 304);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(387, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(632, 323);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(626, 292);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1031, 651);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkbilgileridüzenle;
        private System.Windows.Forms.Button btnrandevual;
        private System.Windows.Forms.RichTextBox rchsikayet;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}