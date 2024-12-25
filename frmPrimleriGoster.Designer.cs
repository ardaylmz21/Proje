namespace PERSONEL_TAKİP_OTOMASyonu
{
    partial class frmPrimleriGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimleriGoster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.dataGridView1.Size = new System.Drawing.Size(902, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Prim Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Personel ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Personel Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(552, 265);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(84, 24);
            this.comboYil.TabIndex = 18;
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
            this.comboAy.Location = new System.Drawing.Point(450, 265);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(83, 24);
            this.comboAy.TabIndex = 19;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(445, 327);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(352, 61);
            this.txtAciklama.TabIndex = 14;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(445, 299);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(191, 22);
            this.txtPrimTutari.TabIndex = 15;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(139, 329);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(223, 22);
            this.txtPersonelAdSoyad.TabIndex = 16;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(139, 301);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(223, 22);
            this.txtPersonelID.TabIndex = 17;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(139, 273);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(223, 22);
            this.txtPrimID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Prim ID:";
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.FlatAppearance.BorderSize = 0;
            this.btnTumPrimleriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumPrimleriOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumPrimleriOde.ImageKey = "6141736.png";
            this.btnTumPrimleriOde.ImageList = this.ımageList1;
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(12, 407);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(198, 50);
            this.btnTumPrimleriOde.TabIndex = 26;
            this.btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimleriOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTumPrimleriOde.UseVisualStyleBackColor = true;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.FlatAppearance.BorderSize = 0;
            this.btnPrimOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimOde.ImageKey = "2651454.png";
            this.btnPrimOde.ImageList = this.ımageList1;
            this.btnPrimOde.Location = new System.Drawing.Point(216, 408);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(120, 50);
            this.btnPrimOde.TabIndex = 26;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimOde.UseVisualStyleBackColor = true;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.FlatAppearance.BorderSize = 0;
            this.btnPrimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimGuncelle.ImageKey = "4768752.png";
            this.btnPrimGuncelle.ImageList = this.ımageList1;
            this.btnPrimGuncelle.Location = new System.Drawing.Point(338, 408);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(165, 50);
            this.btnPrimGuncelle.TabIndex = 26;
            this.btnPrimGuncelle.Text = "Prim Güncelle";
            this.btnPrimGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimGuncelle.UseVisualStyleBackColor = true;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.FlatAppearance.BorderSize = 0;
            this.btnDonemDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonemDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonemDegistir.ImageKey = "11876537.png";
            this.btnDonemDegistir.ImageList = this.ımageList1;
            this.btnDonemDegistir.Location = new System.Drawing.Point(642, 265);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(178, 58);
            this.btnDonemDegistir.TabIndex = 26;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.FlatAppearance.BorderSize = 0;
            this.btnPrimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimSil.ImageKey = "9004828_cross_delete_remove_cancel_icon.png";
            this.btnPrimSil.ImageList = this.ımageList1;
            this.btnPrimSil.Location = new System.Drawing.Point(506, 407);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(127, 50);
            this.btnPrimSil.TabIndex = 26;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimSil.UseVisualStyleBackColor = true;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "4115235_exit_logout_sign out_icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(749, 408);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 48);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "118917_edit_clear_icon.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(630, 409);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 48);
            this.btnTemizle.TabIndex = 28;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "2651454.png");
            this.ımageList1.Images.SetKeyName(1, "6141736.png");
            this.ımageList1.Images.SetKeyName(2, "118917_edit_clear_icon.png");
            this.ımageList1.Images.SetKeyName(3, "4115235_exit_logout_sign out_icon.png");
            this.ımageList1.Images.SetKeyName(4, "9004828_cross_delete_remove_cancel_icon.png");
            this.ımageList1.Images.SetKeyName(5, "4768752.png");
            this.ımageList1.Images.SetKeyName(6, "11876537.png");
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 503);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.btnTumPrimleriOde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Personellerin Primleri";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTumPrimleriOde;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}