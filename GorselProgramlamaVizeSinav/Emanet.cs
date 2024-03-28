using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlamaVizeSinav
{
    public class Emanet
    {
        public static List<Emanet> emanetler=new List<Emanet>();

        private string? _kitapBaslik;
        private string? _kitapYazar;
        private string? _uyeIsmi;
        private string? _uyeSoyismi;
        private int _uyeId;
        private DateTime _aldigiTarih;
        private DateTime _teslimTarihi;
        private  int _emanetId;
        private static int sayac = 1;


        public int EmanetId { get { return _emanetId; }set { _emanetId = value; } }
        public string? KitapBaslik { get { return _kitapBaslik; } set { _kitapBaslik = value; } }
        public string? KitapYazar { get {  return _kitapYazar; } set { _kitapYazar = value; } }  
        public string? UyeIsmi { get {  return _uyeIsmi; } set { _uyeIsmi = value; } }
        public string? uyeSoyismi { get { return _uyeSoyismi; } set { _uyeSoyismi = value; } }
        public int UyeId { get { return _uyeId; } set { _uyeId = value; } }
        public DateTime AlinmaTarihi { get { return _aldigiTarih;}set { _aldigiTarih = value; } }
        public DateTime TeslimTarihi { get { return _teslimTarihi;}set { _teslimTarihi = value; } }

        public Emanet() { _emanetId = sayac++; }

        public void tabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] { _emanetId, _uyeId,_uyeIsmi, _uyeSoyismi, _kitapBaslik, _kitapYazar, _aldigiTarih, _teslimTarihi });

        }
        

    }
}
