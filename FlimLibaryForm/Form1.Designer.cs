namespace FlimLibaryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKayitliflimler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAraFlimAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtResimUrl = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImdbPuani = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSenarist = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFlimTuru = new System.Windows.Forms.TextBox();
            this.txtKonusu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOyuncular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtflimAdi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblSenarist = new System.Windows.Forms.Label();
            this.lblYonetmen = new System.Windows.Forms.Label();
            this.lblFlimTuru = new System.Windows.Forms.Label();
            this.lblFlimAdi = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSonucKonusu = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pcbResim = new System.Windows.Forms.PictureBox();
            this.txtSonucOyuncular = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFilmiKaydet = new System.Windows.Forms.Button();
            this.dtpAraFlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAraFlimTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbKayitliflimler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAraFlimAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(520, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Arama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "---";
            // 
            // cmbKayitliflimler
            // 
            this.cmbKayitliflimler.FormattingEnabled = true;
            this.cmbKayitliflimler.Location = new System.Drawing.Point(93, 22);
            this.cmbKayitliflimler.Name = "cmbKayitliflimler";
            this.cmbKayitliflimler.Size = new System.Drawing.Size(134, 21);
            this.cmbKayitliflimler.TabIndex = 6;
            this.cmbKayitliflimler.SelectedIndexChanged += new System.EventHandler(this.cmbKayitliflimler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kayıtlı Filmler";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(119, 166);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(108, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filmin Tarihi: ";
            // 
            // txtAraFlimAdi
            // 
            this.txtAraFlimAdi.Location = new System.Drawing.Point(93, 86);
            this.txtAraFlimAdi.Name = "txtAraFlimAdi";
            this.txtAraFlimAdi.Size = new System.Drawing.Size(134, 20);
            this.txtAraFlimAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filmin Adı: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFlimTarihi);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtResimUrl);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtImdbPuani);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSenarist);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtYonetmen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFlimTuru);
            this.groupBox2.Controls.Add(this.txtKonusu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOyuncular);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtflimAdi);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Film Ekle";
            // 
            // dtpFlimTarihi
            // 
            this.dtpFlimTarihi.Location = new System.Drawing.Point(93, 162);
            this.dtpFlimTarihi.Name = "dtpFlimTarihi";
            this.dtpFlimTarihi.Size = new System.Drawing.Size(134, 20);
            this.dtpFlimTarihi.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Resim Url:";
            // 
            // txtResimUrl
            // 
            this.txtResimUrl.Location = new System.Drawing.Point(347, 119);
            this.txtResimUrl.Name = "txtResimUrl";
            this.txtResimUrl.Size = new System.Drawing.Size(134, 20);
            this.txtResimUrl.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Filmin Tarihi: ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(314, 183);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 23);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(369, 149);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 23);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(255, 149);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "iMDB Puanı: ";
            // 
            // txtImdbPuani
            // 
            this.txtImdbPuani.Location = new System.Drawing.Point(347, 93);
            this.txtImdbPuani.Name = "txtImdbPuani";
            this.txtImdbPuani.Size = new System.Drawing.Size(134, 20);
            this.txtImdbPuani.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Senarist: ";
            // 
            // txtSenarist
            // 
            this.txtSenarist.Location = new System.Drawing.Point(347, 67);
            this.txtSenarist.Name = "txtSenarist";
            this.txtSenarist.Size = new System.Drawing.Size(134, 20);
            this.txtSenarist.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yönetmen: ";
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(347, 41);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(134, 20);
            this.txtYonetmen.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Filmin Türü: ";
            // 
            // txtFlimTuru
            // 
            this.txtFlimTuru.Location = new System.Drawing.Point(347, 15);
            this.txtFlimTuru.Name = "txtFlimTuru";
            this.txtFlimTuru.Size = new System.Drawing.Size(134, 20);
            this.txtFlimTuru.TabIndex = 15;
            // 
            // txtKonusu
            // 
            this.txtKonusu.Location = new System.Drawing.Point(93, 101);
            this.txtKonusu.Multiline = true;
            this.txtKonusu.Name = "txtKonusu";
            this.txtKonusu.Size = new System.Drawing.Size(134, 54);
            this.txtKonusu.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Konusu";
            // 
            // txtOyuncular
            // 
            this.txtOyuncular.Location = new System.Drawing.Point(93, 41);
            this.txtOyuncular.Multiline = true;
            this.txtOyuncular.Name = "txtOyuncular";
            this.txtOyuncular.Size = new System.Drawing.Size(134, 54);
            this.txtOyuncular.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Filmin Adı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Oyuncular";
            // 
            // txtflimAdi
            // 
            this.txtflimAdi.Location = new System.Drawing.Point(93, 15);
            this.txtflimAdi.Name = "txtflimAdi";
            this.txtflimAdi.Size = new System.Drawing.Size(134, 20);
            this.txtflimAdi.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFilmiKaydet);
            this.groupBox3.Controls.Add(this.lblImdb);
            this.groupBox3.Controls.Add(this.lblSenarist);
            this.groupBox3.Controls.Add(this.lblYonetmen);
            this.groupBox3.Controls.Add(this.lblFlimTuru);
            this.groupBox3.Controls.Add(this.lblFlimAdi);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtSonucKonusu);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.pcbResim);
            this.groupBox3.Controls.Add(this.txtSonucOyuncular);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 403);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arama Sonucları";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(730, 19);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(11, 13);
            this.lblImdb.TabIndex = 28;
            this.lblImdb.Text = "*";
            // 
            // lblSenarist
            // 
            this.lblSenarist.Location = new System.Drawing.Point(428, 95);
            this.lblSenarist.Name = "lblSenarist";
            this.lblSenarist.Size = new System.Drawing.Size(307, 107);
            this.lblSenarist.TabIndex = 28;
            this.lblSenarist.Text = "*";
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.AutoSize = true;
            this.lblYonetmen.Location = new System.Drawing.Point(428, 69);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(11, 13);
            this.lblYonetmen.TabIndex = 28;
            this.lblYonetmen.Text = "*";
            // 
            // lblFlimTuru
            // 
            this.lblFlimTuru.AutoSize = true;
            this.lblFlimTuru.Location = new System.Drawing.Point(428, 45);
            this.lblFlimTuru.Name = "lblFlimTuru";
            this.lblFlimTuru.Size = new System.Drawing.Size(11, 13);
            this.lblFlimTuru.TabIndex = 28;
            this.lblFlimTuru.Text = "*";
            // 
            // lblFlimAdi
            // 
            this.lblFlimAdi.AutoSize = true;
            this.lblFlimAdi.Location = new System.Drawing.Point(428, 19);
            this.lblFlimAdi.Name = "lblFlimAdi";
            this.lblFlimAdi.Size = new System.Drawing.Size(11, 13);
            this.lblFlimAdi.TabIndex = 28;
            this.lblFlimAdi.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(646, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "iMDB Puanı: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(344, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Filmin Türü: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(344, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Senarist: ";
            // 
            // txtSonucKonusu
            // 
            this.txtSonucKonusu.Location = new System.Drawing.Point(431, 272);
            this.txtSonucKonusu.Multiline = true;
            this.txtSonucKonusu.Name = "txtSonucKonusu";
            this.txtSonucKonusu.Size = new System.Drawing.Size(304, 77);
            this.txtSonucKonusu.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(344, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Yönetmen: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Filmin Adı: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Konusu";
            // 
            // pcbResim
            // 
            this.pcbResim.Location = new System.Drawing.Point(9, 19);
            this.pcbResim.Name = "pcbResim";
            this.pcbResim.Size = new System.Drawing.Size(320, 330);
            this.pcbResim.TabIndex = 0;
            this.pcbResim.TabStop = false;
            // 
            // txtSonucOyuncular
            // 
            this.txtSonucOyuncular.Location = new System.Drawing.Point(431, 212);
            this.txtSonucOyuncular.Multiline = true;
            this.txtSonucOyuncular.Name = "txtSonucOyuncular";
            this.txtSonucOyuncular.Size = new System.Drawing.Size(304, 54);
            this.txtSonucOyuncular.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(344, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Oyuncular";
            // 
            // btnFilmiKaydet
            // 
            this.btnFilmiKaydet.Location = new System.Drawing.Point(627, 363);
            this.btnFilmiKaydet.Name = "btnFilmiKaydet";
            this.btnFilmiKaydet.Size = new System.Drawing.Size(108, 23);
            this.btnFilmiKaydet.TabIndex = 29;
            this.btnFilmiKaydet.Text = "Filmi Kaydet";
            this.btnFilmiKaydet.UseVisualStyleBackColor = true;
            this.btnFilmiKaydet.Click += new System.EventHandler(this.btnFilmiKaydet_Click);
            // 
            // dtpAraFlimTarihi
            // 
            this.dtpAraFlimTarihi.Location = new System.Drawing.Point(93, 124);
            this.dtpAraFlimTarihi.Name = "dtpAraFlimTarihi";
            this.dtpAraFlimTarihi.Size = new System.Drawing.Size(134, 20);
            this.dtpAraFlimTarihi.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAraFlimAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKayitliflimler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtImdbPuani;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSenarist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFlimTuru;
        private System.Windows.Forms.TextBox txtKonusu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOyuncular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtflimAdi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSonucKonusu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pcbResim;
        private System.Windows.Forms.TextBox txtSonucOyuncular;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtResimUrl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblSenarist;
        private System.Windows.Forms.Label lblYonetmen;
        private System.Windows.Forms.Label lblFlimTuru;
        private System.Windows.Forms.Label lblFlimAdi;
        private System.Windows.Forms.DateTimePicker dtpFlimTarihi;
        private System.Windows.Forms.Button btnFilmiKaydet;
        private System.Windows.Forms.DateTimePicker dtpAraFlimTarihi;
    }
}

