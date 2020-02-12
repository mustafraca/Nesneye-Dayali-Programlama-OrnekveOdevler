using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kare:Sekil
    {
        public Nokta BN { get; set; }
        public int kenarU { get; set; }
        public  double Alan//ezdik ezmesydil 0 0 cıkar. zorunlu değil
        {
            get
            {
                return kenarU * kenarU;
            }
            
        }
        public  double Cevre
        {
            get
            {
                return 4 * kenarU;
            }
            
        }
    }
}
