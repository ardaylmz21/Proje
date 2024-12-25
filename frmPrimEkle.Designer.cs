namespace PERSONEL_TAKİP_OTOMASyonu
{
    partial class frmPrimEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimEkle));
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1Prim = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimleriGoster = new System.Windows.Forms.Button();
            this.btnPersoneleGorePrim = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Prim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(197, 484);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(223, 22);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(197, 512);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(223, 22);
            this.txtPersonelAdSoyad.TabIndex = 0;
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Location = new System.Drawing.Point(505, 414);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(180, 20);
            this.radioTumPersoneller.TabIndex = 1;
            this.radioTumPersoneller.TabStop = true;
            this.radioTumPersoneller.Text = "Tüm Personeller İçin Prim";
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            this.radioTumPersoneller.CheckedChanged += new System.EventHandler(this.radioTumPersoneller_CheckedChanged);
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Location = new System.Drawing.Point(167, 414);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(124, 20);
            this.radioKisiyeOzel.TabIndex = 2;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            this.radioKisiyeOzel.CheckedChanged += new System.EventHandler(this.radioKisiyeOzel_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(299, 550);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(121, 24);
            this.comboYil.TabIndex = 8;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(197, 550);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(83, 24);
            this.comboAy.TabIndex = 9;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(576, 450);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(223, 22);
            this.txtPrimTutari.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(576, 493);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(223, 64);
            this.txtAciklama.TabIndex = 0;
            // 
            // dataGridView1Prim
            // 
            this.dataGridView1Prim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1Prim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Prim.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1Prim.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1Prim.Name = "dataGridView1Prim";
            this.dataGridView1Prim.RowHeadersWidth = 51;
            this.dataGridView1Prim.RowTemplate.Height = 24;
            this.dataGridView1Prim.Size = new System.Drawing.Size(852, 408);
            this.dataGridView1Prim.TabIndex = 12;
            this.dataGridView1Prim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Personel Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personel ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prim Tutarı:";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.FlatAppearance.BorderSize = 0;
            this.btnPrimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimEkle.ImageKey = "299068_add_sign_icon.png";
            this.btnPrimEkle.ImageList = this.ımageList1;
            this.btnPrimEkle.Location = new System.Drawing.Point(148, 600);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(101, 90);
            this.btnPrimEkle.TabIndex = 13;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimleriGoster
            // 
            this.btnPrimleriGoster.FlatAppearance.BorderSize = 0;
            this.btnPrimleriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimleriGoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimleriGoster.ImageKey = "1851714.png";
            this.btnPrimleriGoster.ImageList = this.ımageList1;
            this.btnPrimleriGoster.Location = new System.Drawing.Point(255, 600);
            this.btnPrimleriGoster.Name = "btnPrimleriGoster";
            this.btnPrimleriGoster.Size = new System.Drawing.Size(101, 111);
            this.btnPrimleriGoster.TabIndex = 13;
            this.btnPrimleriGoster.Text = "Primleri Göster";
            this.btnPrimleriGoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimleriGoster.UseVisualStyleBackColor = true;
            this.btnPrimleriGoster.Click += new System.EventHandler(this.btnPrimleriGoster_Click);
            // 
            // btnPersoneleGorePrim
            // 
            this.btnPersoneleGorePrim.FlatAppearance.BorderSize = 0;
            this.btnPersoneleGorePrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneleGorePrim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersoneleGorePrim.ImageKey = "13484816.png";
            this.btnPersoneleGorePrim.ImageList = this.ımageList1;
            this.btnPersoneleGorePrim.Location = new System.Drawing.Point(365, 600);
            this.btnPersoneleGorePrim.Name = "btnPersoneleGorePrim";
            this.btnPersoneleGorePrim.Size = new System.Drawing.Size(118, 99);
            this.btnPersoneleGorePrim.TabIndex = 13;
            this.btnPersoneleGorePrim.Text = "Personel Primleri";
            this.btnPersoneleGorePrim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersoneleGorePrim.UseVisualStyleBackColor = true;
            this.btnPersoneleGorePrim.Click += new System.EventHandler(this.btnPersoneleGorePrim_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTemizle.ImageKey = "118917_edit_clear_icon.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(500, 600);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(101, 90);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "4115235_exit_logout_sign out_icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(610, 600);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(118, 90);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(197, 450);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(223, 22);
            this.txtArama.TabIndex = 0;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Personel Ara:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "118917_edit_clear_icon.png");
            this.ımageList1.Images.SetKeyName(1, "299068_add_sign_icon.png");
            this.ımageList1.Images.SetKeyName(2, "4115235_exit_logout_sign out_icon.png");
            this.ımageList1.Images.SetKeyName(3, "8046655.png");
            this.ımageList1.Images.SetKeyName(4, "13484816.png");
            this.ımageList1.Images.SetKeyName(5, "1851714.png");
            // 
            // frmPrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 702);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPersoneleGorePrim);
            this.Controls.Add(this.btnPrimleriGoster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.dataGridView1Prim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "frmPrimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Prim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1Prim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimleriGoster;
        private System.Windows.Forms.Button btnPersoneleGorePrim;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList ımageList1;
    }
}