using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Koltuklar
    {
        public int KoltukNo { get; set; }
        public String AdSoyad { get; set; }
        public int TC { get; set; }
        public String Cinsiyet { get; set; }
        public Boolean Dolubos { get; set; }

        public override string ToString()
        {
            if(this.Dolubos == true)
            {
                return "Dolu";
            }
            else
            {
                return "Bos";
            }
        }
    }
    
}
