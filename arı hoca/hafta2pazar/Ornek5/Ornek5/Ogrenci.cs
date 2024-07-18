using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string ogrenciAdi { get; set; }
        public string Adres { get; set; }
        public Okul okulId { get; set; }
    }
}
