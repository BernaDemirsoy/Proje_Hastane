namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.mskdTc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnekle = new System.Windows.Forms.Button();
            this.bttnsil = new System.Windows.Forms.Button();
            this.btttnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(98, 48);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(169, 32);
            this.txtad.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(98, 86);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(169, 32);
            this.txtsoyad.TabIndex = 6;
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(98, 124);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(169, 32);
            this.cmbbrans.TabIndex = 7;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // mskdTc
            // 
            this.mskdTc.Location = new System.Drawing.Point(98, 162);
            this.mskdTc.Mask = "00000000000";
            this.mskdTc.Name = "mskdTc";
            this.mskdTc.Size = new System.Drawing.Size(169, 32);
            this.mskdTc.TabIndex = 8;
            this.mskdTc.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(98, 200);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(169, 32);
            this.txtsifre.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 335);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bttnekle
            // 
            this.bttnekle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bttnekle.Location = new System.Drawing.Point(98, 256);
            this.bttnekle.Name = "bttnekle";
            this.bttnekle.Size = new System.Drawing.Size(75, 53);
            this.bttnekle.TabIndex = 11;
            this.bttnekle.Text = "Ekle";
            this.bttnekle.UseVisualStyleBackColor = false;
            this.bttnekle.Click += new System.EventHandler(this.bttnekle_Click);
            // 
            // bttnsil
            // 
            this.bttnsil.BackColor = System.Drawing.Color.LightCoral;
            this.bttnsil.Location = new System.Drawing.Point(192, 256);
            this.bttnsil.Name = "bttnsil";
            this.bttnsil.Size = new System.Drawing.Size(75, 53);
            this.bttnsil.TabIndex = 12;
            this.bttnsil.Text = "Sil";
            this.bttnsil.UseVisualStyleBackColor = false;
            this.bttnsil.Click += new System.EventHandler(this.bttnsil_Click);
            // 
            // btttnguncelle
            // 
            this.btttnguncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btttnguncelle.Location = new System.Drawing.Point(122, 315);
            this.btttnguncelle.Name = "btttnguncelle";
            this.btttnguncelle.Size = new System.Drawing.Size(130, 53);
            this.btttnguncelle.TabIndex = 13;
            this.btttnguncelle.Text = "Güncelle";
            this.btttnguncelle.UseVisualStyleBackColor = false;
            this.btttnguncelle.Click += new System.EventHandler(this.btttnguncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(963, 384);
            this.Controls.Add(this.btttnguncelle);
            this.Controls.Add(this.bttnsil);
            this.Controls.Add(this.bttnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskdTc);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.MaskedTextBox mskdTc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnekle;
        private System.Windows.Forms.Button bttnsil;
        private System.Windows.Forms.Button btttnguncelle;
    }
}