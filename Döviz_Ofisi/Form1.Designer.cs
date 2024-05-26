namespace Döviz_Ofisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEuroSatis = new System.Windows.Forms.Label();
            this.lblEuroAlis = new System.Windows.Forms.Label();
            this.lblDolarSatis = new System.Windows.Forms.Label();
            this.lblDolarAlis = new System.Windows.Forms.Label();
            this.btnDolarAl = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.btnDövizCikis = new System.Windows.Forms.Button();
            this.btnDövizGiris = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnDolarSat = new System.Windows.Forms.Button();
            this.btnEuroAl = new System.Windows.Forms.Button();
            this.btnEuroSat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEuroSatis
            // 
            this.lblEuroSatis.AutoSize = true;
            this.lblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSatis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEuroSatis.Location = new System.Drawing.Point(198, 216);
            this.lblEuroSatis.Name = "lblEuroSatis";
            this.lblEuroSatis.Size = new System.Drawing.Size(28, 29);
            this.lblEuroSatis.TabIndex = 9;
            this.lblEuroSatis.Text = "0";
            // 
            // lblEuroAlis
            // 
            this.lblEuroAlis.AutoSize = true;
            this.lblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroAlis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEuroAlis.Location = new System.Drawing.Point(198, 166);
            this.lblEuroAlis.Name = "lblEuroAlis";
            this.lblEuroAlis.Size = new System.Drawing.Size(28, 29);
            this.lblEuroAlis.TabIndex = 10;
            this.lblEuroAlis.Text = "0";
            // 
            // lblDolarSatis
            // 
            this.lblDolarSatis.AutoSize = true;
            this.lblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSatis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDolarSatis.Location = new System.Drawing.Point(198, 116);
            this.lblDolarSatis.Name = "lblDolarSatis";
            this.lblDolarSatis.Size = new System.Drawing.Size(28, 29);
            this.lblDolarSatis.TabIndex = 5;
            this.lblDolarSatis.Text = "0";
            // 
            // lblDolarAlis
            // 
            this.lblDolarAlis.AutoSize = true;
            this.lblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarAlis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDolarAlis.Location = new System.Drawing.Point(198, 65);
            this.lblDolarAlis.Name = "lblDolarAlis";
            this.lblDolarAlis.Size = new System.Drawing.Size(28, 29);
            this.lblDolarAlis.TabIndex = 6;
            this.lblDolarAlis.Text = "0";
            // 
            // btnDolarAl
            // 
            this.btnDolarAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDolarAl.Location = new System.Drawing.Point(26, 61);
            this.btnDolarAl.Name = "btnDolarAl";
            this.btnDolarAl.Size = new System.Drawing.Size(139, 37);
            this.btnDolarAl.TabIndex = 13;
            this.btnDolarAl.Text = "Dolar Alış";
            this.btnDolarAl.UseVisualStyleBackColor = true;
            this.btnDolarAl.Click += new System.EventHandler(this.btnDolarAl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(17, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kur:";
            // 
            // txtKur
            // 
            this.txtKur.Enabled = false;
            this.txtKur.Location = new System.Drawing.Point(126, 34);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(304, 35);
            this.txtKur.TabIndex = 14;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.btnDövizCikis);
            this.groupBox1.Controls.Add(this.btnDövizGiris);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Location = new System.Drawing.Point(328, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 299);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(17, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Kalan:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(17, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tutar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(17, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Miktar:";
            // 
            // txtKalan
            // 
            this.txtKalan.Enabled = false;
            this.txtKalan.Location = new System.Drawing.Point(127, 163);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(304, 35);
            this.txtKalan.TabIndex = 14;
            // 
            // btnDövizCikis
            // 
            this.btnDövizCikis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDövizCikis.Location = new System.Drawing.Point(287, 213);
            this.btnDövizCikis.Name = "btnDövizCikis";
            this.btnDövizCikis.Size = new System.Drawing.Size(143, 51);
            this.btnDövizCikis.TabIndex = 13;
            this.btnDövizCikis.Text = "Döviz Çıkış";
            this.btnDövizCikis.UseVisualStyleBackColor = true;
            this.btnDövizCikis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnDövizGiris
            // 
            this.btnDövizGiris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDövizGiris.Location = new System.Drawing.Point(126, 213);
            this.btnDövizGiris.Name = "btnDövizGiris";
            this.btnDövizGiris.Size = new System.Drawing.Size(143, 51);
            this.btnDövizGiris.TabIndex = 13;
            this.btnDövizGiris.Text = "Döviz Giriş";
            this.btnDövizGiris.UseVisualStyleBackColor = true;
            this.btnDövizGiris.Click += new System.EventHandler(this.btnAlis_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(126, 122);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(304, 35);
            this.txtTutar.TabIndex = 14;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(126, 78);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(304, 35);
            this.txtMiktar.TabIndex = 14;
            // 
            // btnDolarSat
            // 
            this.btnDolarSat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDolarSat.Location = new System.Drawing.Point(26, 110);
            this.btnDolarSat.Name = "btnDolarSat";
            this.btnDolarSat.Size = new System.Drawing.Size(139, 40);
            this.btnDolarSat.TabIndex = 13;
            this.btnDolarSat.Text = "Dolar Satış";
            this.btnDolarSat.UseVisualStyleBackColor = true;
            this.btnDolarSat.Click += new System.EventHandler(this.btnDolarSat_Click);
            // 
            // btnEuroAl
            // 
            this.btnEuroAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEuroAl.Location = new System.Drawing.Point(26, 160);
            this.btnEuroAl.Name = "btnEuroAl";
            this.btnEuroAl.Size = new System.Drawing.Size(139, 40);
            this.btnEuroAl.TabIndex = 13;
            this.btnEuroAl.Text = "Euro Alış";
            this.btnEuroAl.UseVisualStyleBackColor = true;
            this.btnEuroAl.Click += new System.EventHandler(this.btnEuroAl_Click);
            // 
            // btnEuroSat
            // 
            this.btnEuroSat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEuroSat.Location = new System.Drawing.Point(26, 211);
            this.btnEuroSat.Name = "btnEuroSat";
            this.btnEuroSat.Size = new System.Drawing.Size(139, 39);
            this.btnEuroSat.TabIndex = 13;
            this.btnEuroSat.Text = "Euro Satış";
            this.btnEuroSat.UseVisualStyleBackColor = true;
            this.btnEuroSat.Click += new System.EventHandler(this.btnEuroSat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kuyumcu İçin İşlem Yapılmaktadır !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEuroSat);
            this.Controls.Add(this.btnEuroAl);
            this.Controls.Add(this.btnDolarSat);
            this.Controls.Add(this.btnDolarAl);
            this.Controls.Add(this.lblEuroSatis);
            this.Controls.Add(this.lblEuroAlis);
            this.Controls.Add(this.lblDolarSatis);
            this.Controls.Add(this.lblDolarAlis);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Bürosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuroSatis;
        private System.Windows.Forms.Label lblEuroAlis;
        private System.Windows.Forms.Label lblDolarSatis;
        private System.Windows.Forms.Label lblDolarAlis;
        private System.Windows.Forms.Button btnDolarAl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnDolarSat;
        private System.Windows.Forms.Button btnEuroAl;
        private System.Windows.Forms.Button btnEuroSat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Button btnDövizGiris;
        private System.Windows.Forms.Button btnDövizCikis;
        private System.Windows.Forms.Label label1;
    }
}

