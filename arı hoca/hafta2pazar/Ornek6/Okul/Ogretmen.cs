using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    public class Ogretmen
    {
        public int Id { get; set; }
        public string adSoyad { get; set; }
        public string brans { get; set; }
        public Ogrenci OgrenciID { get; set; }
    }
}
