namespace Proje_Hastane
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.btngirisyap = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.mskdTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngirisyap
            // 
            this.btngirisyap.Location = new System.Drawing.Point(212, 261);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(150, 54);
            this.btngirisyap.TabIndex = 13;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(212, 186);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(212, 32);
            this.txtsifre.TabIndex = 12;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // mskdTC
            // 
            this.mskdTC.Location = new System.Drawing.Point(212, 138);
            this.mskdTC.Mask = "00000000000";
            this.mskdTC.Name = "mskdTC";
            this.mskdTC.Size = new System.Drawing.Size(179, 32);
            this.mskdTC.TabIndex = 11;
            this.mskdTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(550, 344);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskdTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.Text = "FrmDoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox mskdTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}