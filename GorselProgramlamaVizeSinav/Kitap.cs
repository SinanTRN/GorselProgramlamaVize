﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaVizeSinav
{
    public class Kitap
    {
        private string? _baslik;
        private string? _yazar;
        private string? _yayinevi;
        private string? _ISBN;
        private int _baskiSayisi;
        private int _basimYili;

        public string? Baslik { get { return _baslik; }set { _baslik = value; } }
        public string? Yazar { get { return _yazar; }set { _yazar = value; } }
        public string? Yayinevi { get { return _yayinevi; } set { _yayinevi = value; } }
        public string? ISBN { get { return _ISBN; }set { _ISBN = value; } }
        public int BaskiSayisi { get {  return _baskiSayisi; } set { _baskiSayisi = value; } }
        public int BasimYili { get { return _basimYili;}set { _basimYili = value; } }

        public Kitap() { }

        public void tabloyaEkle(DataTable tablo) { 
                tablo.Rows.Add(new object[] { _baslik, _yazar, _yayinevi, _ISBN, _baskiSayisi, _basimYili });
        }
    }
}