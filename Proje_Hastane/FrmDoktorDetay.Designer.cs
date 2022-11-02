namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchrandevudetay = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnduyurular = new System.Windows.Forms.Button();
            this.btnbilgiduzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.LblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // LblAdsoyad
            // 
            this.LblAdsoyad.AutoSize = true;
            this.LblAdsoyad.Location = new System.Drawing.Point(163, 125);
            this.LblAdsoyad.Name = "LblAdsoyad";
            this.LblAdsoyad.Size = new System.Drawing.Size(82, 24);
            this.LblAdsoyad.TabIndex = 7;
            this.LblAdsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad-Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(163, 80);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(120, 24);
            this.lblTc.TabIndex = 5;
            this.lblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.rchrandevudetay);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchrandevudetay
            // 
            this.rchrandevudetay.Location = new System.Drawing.Point(11, 34);
            this.rchrandevudetay.Name = "rchrandevudetay";
            this.rchrandevudetay.Size = new System.Drawing.Size(339, 191);
            this.rchrandevudetay.TabIndex = 0;
            this.rchrandevudetay.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(380, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 568);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 537);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btncıkıs);
            this.groupBox4.Controls.Add(this.btnduyurular);
            this.groupBox4.Controls.Add(this.btnbilgiduzenle);
            this.groupBox4.Location = new System.Drawing.Point(12, 469);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 111);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Araçlar";
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.Azure;
            this.btncıkıs.Location = new System.Drawing.Point(6, 69);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(339, 32);
            this.btncıkıs.TabIndex = 3;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnduyurular
            // 
            this.btnduyurular.BackColor = System.Drawing.Color.Azure;
            this.btnduyurular.Location = new System.Drawing.Point(186, 31);
            this.btnduyurular.Name = "btnduyurular";
            this.btnduyurular.Size = new System.Drawing.Size(159, 32);
            this.btnduyurular.TabIndex = 1;
            this.btnduyurular.Text = "Duyurular";
            this.btnduyurular.UseVisualStyleBackColor = false;
            this.btnduyurular.Click += new System.EventHandler(this.btnduyurular_Click);
            // 
            // btnbilgiduzenle
            // 
            this.btnbilgiduzenle.BackColor = System.Drawing.Color.Azure;
            this.btnbilgiduzenle.Location = new System.Drawing.Point(6, 31);
            this.btnbilgiduzenle.Name = "btnbilgiduzenle";
            this.btnbilgiduzenle.Size = new System.Drawing.Size(159, 32);
            this.btnbilgiduzenle.TabIndex = 0;
            this.btnbilgiduzenle.Text = "Bilgi Düzenle";
            this.btnbilgiduzenle.UseVisualStyleBackColor = false;
            this.btnbilgiduzenle.Click += new System.EventHandler(this.btnbilgiduzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1040, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LblAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchrandevudetay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnduyurular;
        private System.Windows.Forms.Button btnbilgiduzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}