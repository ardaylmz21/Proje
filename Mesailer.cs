﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONEL_TAKİP_OTOMASyonu
{
    internal class Mesailer
    {
        private int _MesaiID;
        private string _Baslangic_Saati;
        private string _Bitis_Saati;
        private decimal _MesaiSaatUcreti;
        private decimal _Tutar;
        private string _Donem;
        private string _OdenmeDurumu;
        private string _Aciklama;
        private string _Islem;
        private DateTime _Tarih;
        private string _AdiSoyadi;

        public int MesaiID { get => _MesaiID; set => _MesaiID = value; }
        public string Baslangic_Saati { get => _Baslangic_Saati; set => _Baslangic_Saati = value; }
        public string Bitis_Saati { get => _Bitis_Saati; set => _Bitis_Saati = value; }
        public decimal MesaiSaatUcreti { get => _MesaiSaatUcreti; set => _MesaiSaatUcreti = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public string AdiSoyadi { get => _AdiSoyadi; set => _AdiSoyadi = value; }
    }
}
