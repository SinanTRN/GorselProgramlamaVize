using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GorselProgramlamaVizeSinav
{
    public class Uye
    {
        private string? _isim;
        private string? _soyisim;
        private string? _email;
        private  int _id;
        private string _telefon;
        private static int sayac = 1;

        public string? Isim { get { return _isim; } set { _isim = value; } }
        public string? Soyisim { get { return _soyisim; } set { _soyisim = value; } }
        public string? Eposta { get { return _email; } set { _email = value; } }
        public string Telefon { get { return _telefon; }  set { _telefon = value; } } 
        public int ID { get { return _id; } }

        public Uye() { _id = sayac++; }

        public void tabloyaEkle(DataTable tablo)
        {
                tablo.Rows.Add(new object[] { _id, _isim, _soyisim, _email, _telefon });
        }

    }
}
