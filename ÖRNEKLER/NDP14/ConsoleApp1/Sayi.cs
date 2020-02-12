using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sayi<T>//T veri türü
    {
        public T eleman { get; set; }
        public Sayi(T s)
        {
            eleman = s;
        }
        public Sayi() { }
    }
}
