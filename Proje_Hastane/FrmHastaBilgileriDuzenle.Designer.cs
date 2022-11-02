namespace Proje_Hastane
{
    partial class FrmHastaBilgileriDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgileriDuzenle));
            this.btnbilgiguncelle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.mskdtelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskdTC = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbilgiguncelle
            // 
            this.btnbilgiguncelle.BackColor = System.Drawing.Color.Chocolate;
            this.btnbilgiguncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbilgiguncelle.Location = new System.Drawing.Point(167, 495);
            this.btnbilgiguncelle.Name = "btnbilgiguncelle";
            this.btnbilgiguncelle.Size = new System.Drawing.Size(192, 55);
            this.btnbilgiguncelle.TabIndex = 30;
            this.btnbilgiguncelle.Text = "Bilgilerimi Güncelle";
            this.btnbilgiguncelle.UseVisualStyleBackColor = false;
            this.btnbilgiguncelle.Click += new System.EventHandler(this.btnbilgiguncelle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Belirtmek İstemiyorum"});
            this.comboBox1.Location = new System.Drawing.Point(167, 439);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 32);
            this.comboBox1.TabIndex = 29;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(167, 396);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(192, 32);
            this.txtsifre.TabIndex = 28;
            // 
            // mskdtelefon
            // 
            this.mskdtelefon.Location = new System.Drawing.Point(167, 353);
            this.mskdtelefon.Mask = "(999) 000-0000";
            this.mskdtelefon.Name = "mskdtelefon";
            this.mskdtelefon.Size = new System.Drawing.Size(192, 32);
            this.mskdtelefon.TabIndex = 27;
            // 
            // mskdTC
            // 
            this.mskdTC.Location = new System.Drawing.Point(167, 306);
            this.mskdTC.Mask = "0000000000";
            this.mskdTC.Name = "mskdTC";
            this.mskdTC.Size = new System.Drawing.Size(192, 32);
            this.mskdTC.TabIndex = 26;
            this.mskdTC.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(167, 258);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(192, 32);
            this.txtsoyad.TabIndex = 25;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(167, 219);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(192, 32);
            this.txtad.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaBilgileriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(504, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbilgiguncelle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskdtelefon);
            this.Controls.Add(this.mskdTC);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgileriDuzenle";
            this.Text = "Hasta Bilgileri Düzenle";
            this.Load += new System.EventHandler(this.FrmHastaBilgileriDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbilgiguncelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox mskdtelefon;
        private System.Windows.Forms.MaskedTextBox mskdTC;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}