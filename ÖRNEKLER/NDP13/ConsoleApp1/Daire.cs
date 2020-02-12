using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Daire:Sekil
    {
        public Nokta MNokta { get; set; }
        public int R { get; set; }
        public  double Alan
        {
            get
            {
                return 3.14 * R * R;
            }
            
        }
        public  double Cevre
        {
            get
            {
                 return 2 * 3.14 * R;
            }
          
        }
    }
}
