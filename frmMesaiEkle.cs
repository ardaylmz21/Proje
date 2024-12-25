using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONEL_TAKİP_OTOMASyonu
{
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil=DateTime.Now.Year;
            for (int i = yil; i >= yil-5; i--)
            {
                comboYil.Items.Add(i);
            }
            YapilanZamlar.ComboyaPersonelGetir(comboPersonelAdSoyad);
        }
        Label lbl;

        private void comboPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl=new Label();
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersonelAdSoyad,lbl);
            //MessageBox.Show(lbl.Text);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isOverTimePay(string AdiSoyadi)
        {
            // Veritabanı bağlantı dizesi (kendi bağlantı dizesinizi yazın)
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=PersonellTakibi1;Integrated Security=True;Pooling=False";

            // SQL sorgusu
            string sql = @"
        SELECT 
            SUM(DATEDIFF(MINUTE, BaslangicSaati, BitisSaati)) AS ToplamDakika
        FROM 
            Mesailer
        WHERE 
            AdiSoyadi = @AdiSoyadi
        GROUP BY 
            AdiSoyadi;";

            // Bağlantıyı oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Komutu oluştur
                using (SqlCommand komut = new SqlCommand(sql, connection))
                {
                    komut.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);

                    try
                    {
                        // Bağlantıyı aç
                        connection.Open();

                        // Sorguyu çalıştır ve sonucu al
                        object result = komut.ExecuteScalar();

                        // Eğer sonuç null değilse, sonucu işle
                        if (result != null && int.TryParse(result.ToString(), out int toplamDakika))
                        {
                            // Fazla mesai kontrolü (örnek: 480 dakika = 8 saat)
                            if (toplamDakika > 480)
                            {
                                MessageBox.Show($"Fazla mesai: {toplamDakika - 480} dakika.");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show($"Normal mesai: {toplamDakika} dakika.");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcıya ait mesai bilgisi bulunamadı.");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda kullanıcıya bilgi verme
                        MessageBox.Show($"Hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personeller p= new Personeller();
            Mesailer m= new Mesailer();
            k.KullaniciID=Kullanicilar.kid;
            p.PERSONELID = int.Parse(lbl.Text);
            m.AdiSoyadi = comboPersonelAdSoyad.Text;
            m.Baslangic_Saati = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
            m.Bitis_Saati = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
            m.MesaiSaatUcreti=decimal.Parse(txtMesaiSaatUcreti.Text);
            m.Tutar=decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih=DateTime.Now;
            string sql = "insert into Mesailer(KullaniciID,PersonelID,AdiSoyadi,BaslangicSaati,BitisSaati,MesaiSaatUcreti,Tutar,Donem,Aciklama,Tarih) " +
                "values('" + k.KullaniciID + "','" + p.PERSONELID + "','"+m.AdiSoyadi+"','" + m.Baslangic_Saati + "','" + m.Bitis_Saati + "',@MSaatUcreti,@Tutar,'" + m.Donem + "','" + m.Aciklama + "',@Tarih)";
           
            if (isOverTimePay(m.AdiSoyadi))
            {
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@MSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Mesai bilgileri eklendi.", "Mesailer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Mesai limiti doldurulmadığında kayıt basarıyla gerceklestırıldı");
            }
            else
            {
                MessageBox.Show("Mesai limiti dolduruldugundan kayıt gerceklestırılmedı");
            }
            

            
            
        }
       
        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true; 
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
                string bitis = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatfarki.TotalHours * MSaatUcreti;
                txtTutar.Text=tutar.ToString("0.00");
            }
            catch 
            {
                               
            }
        }
    }
}
