namespace PERSONEL_TAKİP_OTOMASyonu
{
    partial class frmizinHareketleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmizinHareketleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnizinTurleri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtizinHareketID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboizinTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.btnizinHareketRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnizinTurleri
            // 
            this.btnizinTurleri.FlatAppearance.BorderSize = 0;
            this.btnizinTurleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinTurleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnizinTurleri.ImageKey = "3586362_checklist_document_list_paper_icon.png";
            this.btnizinTurleri.ImageList = this.ımageList1;
            this.btnizinTurleri.Location = new System.Drawing.Point(288, 597);
            this.btnizinTurleri.Name = "btnizinTurleri";
            this.btnizinTurleri.Size = new System.Drawing.Size(113, 79);
            this.btnizinTurleri.TabIndex = 1;
            this.btnizinTurleri.Text = "İzin Türleri";
            this.btnizinTurleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnizinTurleri.UseVisualStyleBackColor = true;
            this.btnizinTurleri.Click += new System.EventHandler(this.btnizinTurleri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "134221_refresh_reload_repeat_update_arrow_icon.png");
            this.ımageList1.Images.SetKeyName(1, "299068_add_sign_icon.png");
            this.ımageList1.Images.SetKeyName(2, "3586362_checklist_document_list_paper_icon.png");
            this.ımageList1.Images.SetKeyName(3, "4115235_exit_logout_sign out_icon.png");
            this.ımageList1.Images.SetKeyName(4, "6296676_excel_microsoft_office_office365_icon.png");
            this.ımageList1.Images.SetKeyName(5, "9004828_cross_delete_remove_cancel_icon.png");
            this.ımageList1.Images.SetKeyName(6, "5975175_coronavirus_report_clipboard_medical_virus_icon.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageKey = "134221_refresh_reload_repeat_update_arrow_icon.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(499, 593);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 86);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "9004828_cross_delete_remove_cancel_icon.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(604, 593);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 86);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "4115235_exit_logout_sign out_icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(705, 597);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(98, 79);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageKey = "299068_add_sign_icon.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(407, 597);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 79);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtizinHareketID
            // 
            this.txtizinHareketID.Location = new System.Drawing.Point(117, 500);
            this.txtizinHareketID.Name = "txtizinHareketID";
            this.txtizinHareketID.Size = new System.Drawing.Size(201, 22);
            this.txtizinHareketID.TabIndex = 2;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(117, 528);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(201, 22);
            this.txtPersonelID.TabIndex = 2;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(117, 556);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(201, 22);
            this.txtAdiSoyadi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "İzin Hareket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adı Soyadı:";
            // 
            // comboizinTuru
            // 
            this.comboizinTuru.FormattingEnabled = true;
            this.comboizinTuru.Location = new System.Drawing.Point(433, 497);
            this.comboizinTuru.Name = "comboizinTuru";
            this.comboizinTuru.Size = new System.Drawing.Size(174, 24);
            this.comboizinTuru.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "İzin Türleri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "İzin Başlangıç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "İzin Bitiş:";
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(433, 527);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(174, 22);
            this.dateTimeBaslangic.TabIndex = 5;
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(433, 556);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(174, 22);
            this.dateTimeBitis.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(640, 522);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(195, 56);
            this.txtAciklama.TabIndex = 2;
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.FlatAppearance.BorderSize = 0;
            this.btnExceleAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExceleAktar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExceleAktar.ImageKey = "6296676_excel_microsoft_office_office365_icon.png";
            this.btnExceleAktar.ImageList = this.ımageList1;
            this.btnExceleAktar.Location = new System.Drawing.Point(153, 597);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(129, 79);
            this.btnExceleAktar.TabIndex = 1;
            this.btnExceleAktar.Text = "Excel\'e Aktar";
            this.btnExceleAktar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // btnizinHareketRaporu
            // 
            this.btnizinHareketRaporu.FlatAppearance.BorderSize = 0;
            this.btnizinHareketRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinHareketRaporu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnizinHareketRaporu.ImageKey = "5975175_coronavirus_report_clipboard_medical_virus_icon.png";
            this.btnizinHareketRaporu.ImageList = this.ımageList1;
            this.btnizinHareketRaporu.Location = new System.Drawing.Point(0, 597);
            this.btnizinHareketRaporu.Name = "btnizinHareketRaporu";
            this.btnizinHareketRaporu.Size = new System.Drawing.Size(165, 79);
            this.btnizinHareketRaporu.TabIndex = 1;
            this.btnizinHareketRaporu.Text = "İzin Hareket Raporu";
            this.btnizinHareketRaporu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnizinHareketRaporu.UseVisualStyleBackColor = true;
            this.btnizinHareketRaporu.Click += new System.EventHandler(this.btnizinHareketRaporu_Click);
            // 
            // frmizinHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 688);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboizinTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtizinHareketID);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnizinHareketRaporu);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.btnizinTurleri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmizinHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareketleri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmizinHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnizinTurleri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtizinHareketID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboizinTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnizinHareketRaporu;
    }
}