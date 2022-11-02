namespace Proje_Hastane
{
    partial class FrmUyeKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeKayıt));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.mskdTC = new System.Windows.Forms.MaskedTextBox();
            this.mskdtelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(177, 210);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(192, 32);
            this.txtad.TabIndex = 9;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(177, 249);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(192, 32);
            this.txtsoyad.TabIndex = 10;
            // 
            // mskdTC
            // 
            this.mskdTC.Location = new System.Drawing.Point(177, 297);
            this.mskdTC.Mask = "00000000000";
            this.mskdTC.Name = "mskdTC";
            this.mskdTC.Size = new System.Drawing.Size(192, 32);
            this.mskdTC.TabIndex = 11;
            this.mskdTC.ValidatingType = typeof(int);
            // 
            // mskdtelefon
            // 
            this.mskdtelefon.Location = new System.Drawing.Point(177, 344);
            this.mskdtelefon.Mask = "(999) 000-0000";
            this.mskdtelefon.Name = "mskdtelefon";
            this.mskdtelefon.Size = new System.Drawing.Size(192, 32);
            this.mskdtelefon.TabIndex = 12;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(177, 387);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(192, 32);
            this.txtsifre.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Belirtmek İstemiyorum"});
            this.comboBox1.Location = new System.Drawing.Point(177, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 32);
            this.comboBox1.TabIndex = 14;
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.BackColor = System.Drawing.Color.Chocolate;
            this.btnkayıtol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkayıtol.Location = new System.Drawing.Point(177, 486);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(192, 43);
            this.btnkayıtol.TabIndex = 15;
            this.btnkayıtol.Text = "Kayıt Ol";
            this.btnkayıtol.UseVisualStyleBackColor = false;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(113, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 47);
            this.label7.TabIndex = 17;
            this.label7.Text = "Aramıza Hoşgeldin";
            // 
            // FrmUyeKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(495, 544);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkayıtol);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmUyeKayıt";
            this.Text = "FrmUyeKayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox mskdTC;
        private System.Windows.Forms.MaskedTextBox mskdtelefon;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}