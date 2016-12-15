namespace otobusfirmasi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbox_otobüstürü = new System.Windows.Forms.ComboBox();
            this.otobus_türü = new System.Windows.Forms.Label();
            this.panel_travego = new System.Windows.Forms.Panel();
            this.panel_setra = new System.Windows.Forms.Panel();
            this.musteriBilgileri_GBox = new System.Windows.Forms.GroupBox();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.txt_ad_soyad = new System.Windows.Forms.TextBox();
            this.cinsiyet_gBox = new System.Windows.Forms.GroupBox();
            this.rdbtn_erkek = new System.Windows.Forms.RadioButton();
            this.rdbtn_kadin = new System.Windows.Forms.RadioButton();
            this.lblKoltuk_No = new System.Windows.Forms.Label();
            this.lbl_otobusTürü = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.musteriBilgileri_GBox.SuspendLayout();
            this.cinsiyet_gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbox_otobüstürü
            // 
            this.cbox_otobüstürü.FormattingEnabled = true;
            this.cbox_otobüstürü.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.cbox_otobüstürü.Location = new System.Drawing.Point(46, 110);
            this.cbox_otobüstürü.Name = "cbox_otobüstürü";
            this.cbox_otobüstürü.Size = new System.Drawing.Size(121, 21);
            this.cbox_otobüstürü.TabIndex = 1;
            this.cbox_otobüstürü.SelectedIndexChanged += new System.EventHandler(this.cbox_otobüstürü_SelectedIndexChanged);
            // 
            // otobus_türü
            // 
            this.otobus_türü.AutoSize = true;
            this.otobus_türü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otobus_türü.Location = new System.Drawing.Point(54, 74);
            this.otobus_türü.Name = "otobus_türü";
            this.otobus_türü.Size = new System.Drawing.Size(92, 16);
            this.otobus_türü.TabIndex = 2;
            this.otobus_türü.Text = "Otobüs Türü";
            // 
            // panel_travego
            // 
            this.panel_travego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_travego.Location = new System.Drawing.Point(190, 74);
            this.panel_travego.Name = "panel_travego";
            this.panel_travego.Size = new System.Drawing.Size(212, 408);
            this.panel_travego.TabIndex = 3;
            // 
            // panel_setra
            // 
            this.panel_setra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_setra.Location = new System.Drawing.Point(192, 74);
            this.panel_setra.Name = "panel_setra";
            this.panel_setra.Size = new System.Drawing.Size(212, 408);
            this.panel_setra.TabIndex = 4;
            // 
            // musteriBilgileri_GBox
            // 
            this.musteriBilgileri_GBox.Controls.Add(this.label2);
            this.musteriBilgileri_GBox.Controls.Add(this.label1);
            this.musteriBilgileri_GBox.Controls.Add(this.btn_kaydet);
            this.musteriBilgileri_GBox.Controls.Add(this.lbl_otobusTürü);
            this.musteriBilgileri_GBox.Controls.Add(this.lblKoltuk_No);
            this.musteriBilgileri_GBox.Controls.Add(this.cinsiyet_gBox);
            this.musteriBilgileri_GBox.Controls.Add(this.txt_ad_soyad);
            this.musteriBilgileri_GBox.Controls.Add(this.lbl_ad_soyad);
            this.musteriBilgileri_GBox.Location = new System.Drawing.Point(423, 74);
            this.musteriBilgileri_GBox.Name = "musteriBilgileri_GBox";
            this.musteriBilgileri_GBox.Size = new System.Drawing.Size(275, 253);
            this.musteriBilgileri_GBox.TabIndex = 5;
            this.musteriBilgileri_GBox.TabStop = false;
            this.musteriBilgileri_GBox.Text = "Müşteri Bİlgileri";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad_soyad.Location = new System.Drawing.Point(7, 20);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(61, 13);
            this.lbl_ad_soyad.TabIndex = 0;
            this.lbl_ad_soyad.Text = "Ad-Soyad";
            // 
            // txt_ad_soyad
            // 
            this.txt_ad_soyad.Location = new System.Drawing.Point(6, 37);
            this.txt_ad_soyad.Name = "txt_ad_soyad";
            this.txt_ad_soyad.Size = new System.Drawing.Size(139, 20);
            this.txt_ad_soyad.TabIndex = 1;
            // 
            // cinsiyet_gBox
            // 
            this.cinsiyet_gBox.Controls.Add(this.rdbtn_kadin);
            this.cinsiyet_gBox.Controls.Add(this.rdbtn_erkek);
            this.cinsiyet_gBox.Location = new System.Drawing.Point(6, 63);
            this.cinsiyet_gBox.Name = "cinsiyet_gBox";
            this.cinsiyet_gBox.Size = new System.Drawing.Size(139, 49);
            this.cinsiyet_gBox.TabIndex = 2;
            this.cinsiyet_gBox.TabStop = false;
            this.cinsiyet_gBox.Text = "Cinsiyet";
            // 
            // rdbtn_erkek
            // 
            this.rdbtn_erkek.AutoSize = true;
            this.rdbtn_erkek.Location = new System.Drawing.Point(7, 20);
            this.rdbtn_erkek.Name = "rdbtn_erkek";
            this.rdbtn_erkek.Size = new System.Drawing.Size(53, 17);
            this.rdbtn_erkek.TabIndex = 0;
            this.rdbtn_erkek.TabStop = true;
            this.rdbtn_erkek.Text = "Erkek";
            this.rdbtn_erkek.UseVisualStyleBackColor = true;
            // 
            // rdbtn_kadin
            // 
            this.rdbtn_kadin.AutoSize = true;
            this.rdbtn_kadin.Location = new System.Drawing.Point(66, 20);
            this.rdbtn_kadin.Name = "rdbtn_kadin";
            this.rdbtn_kadin.Size = new System.Drawing.Size(52, 17);
            this.rdbtn_kadin.TabIndex = 1;
            this.rdbtn_kadin.TabStop = true;
            this.rdbtn_kadin.Text = "Kadın";
            this.rdbtn_kadin.UseVisualStyleBackColor = true;
            // 
            // lblKoltuk_No
            // 
            this.lblKoltuk_No.AutoSize = true;
            this.lblKoltuk_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltuk_No.Location = new System.Drawing.Point(82, 119);
            this.lblKoltuk_No.Name = "lblKoltuk_No";
            this.lblKoltuk_No.Size = new System.Drawing.Size(0, 13);
            this.lblKoltuk_No.TabIndex = 3;
            this.lblKoltuk_No.Text = "0";
            // 
            // lbl_otobusTürü
            // 
            this.lbl_otobusTürü.AutoSize = true;
            this.lbl_otobusTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_otobusTürü.Location = new System.Drawing.Point(88, 136);
            this.lbl_otobusTürü.Name = "lbl_otobusTürü";
            this.lbl_otobusTürü.Size = new System.Drawing.Size(0, 13);
            this.lbl_otobusTürü.TabIndex = 4;
            this.lbl_otobusTürü.Text = "-";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(18, 167);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(113, 23);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Koltuk No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Otobüs Türü:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 536);
            this.Controls.Add(this.musteriBilgileri_GBox);
            this.Controls.Add(this.panel_setra);
            this.Controls.Add(this.panel_travego);
            this.Controls.Add(this.otobus_türü);
            this.Controls.Add(this.cbox_otobüstürü);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.musteriBilgileri_GBox.ResumeLayout(false);
            this.musteriBilgileri_GBox.PerformLayout();
            this.cinsiyet_gBox.ResumeLayout(false);
            this.cinsiyet_gBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbox_otobüstürü;
        private System.Windows.Forms.Label otobus_türü;
        private System.Windows.Forms.Panel panel_travego;
        private System.Windows.Forms.Panel panel_setra;
        private System.Windows.Forms.GroupBox musteriBilgileri_GBox;
        private System.Windows.Forms.GroupBox cinsiyet_gBox;
        private System.Windows.Forms.RadioButton rdbtn_kadin;
        private System.Windows.Forms.RadioButton rdbtn_erkek;
        private System.Windows.Forms.TextBox txt_ad_soyad;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_otobusTürü;
        private System.Windows.Forms.Label lblKoltuk_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

