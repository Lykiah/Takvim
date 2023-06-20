using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Takvim
{

    public class Kullanici
    {
        string connstring = "";
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string IsimSoyisim { get; set; }
        public string TelefonNumarasi { get; set; }
        public string TCKimlik { get; set; }
        public string KullaniciTipi { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
    }
}
