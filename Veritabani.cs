using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONEL_TAKİP_OTOMASyonu
{
    internal class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=PersonellTakibi1;Integrated Security=True;Pooling=False");
        public static void ESG(SqlCommand cmd,string sql)
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglanti.Close();

        }
        public static int SonucDondur(string AdiSoyadi, SqlCommand cmd)
        {
            // Sorguyu parametreye uygun hale getirin
            string sql = @"
        SELECT 
            SUM(TIMESTAMPDIFF(SECOND,
                CONVERT(DATETIME, BaslangicSaati, 105),
                 CONVERT(DATETIME, BitisSaati, 105);

            ) AS ToplamSure
        FROM tablo_adi
        WHERE AdiSoyadi = @AdiSoyadi
        GROUP BY AdiSoyadi;";

            cmd.CommandText = sql;
            cmd.Parameters.Clear(); // Parametre çakışmalarını önlemek için temizle
            cmd.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);

            int toplamSure = 0; // Sonuç değeri

            try
            {
                cmd.Connection.Open(); // Bağlantıyı aç
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Dönen sonucu oku
                        toplamSure = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama veya işlem yapabilirsiniz
                throw new Exception("Hata: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close(); // Bağlantıyı kapat
            }

            return toplamSure;
        }

        public static DataTable Listele_Ara(DataGridView gridView,string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr=new SqlDataAdapter(sql,baglanti);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();

            return tbl;
        }
    }
}
