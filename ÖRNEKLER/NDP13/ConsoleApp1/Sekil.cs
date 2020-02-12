using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Sekil  //interface alanları mutlaka ezdirilir ve public olmaz zorunda.
    {
          double Alan//virtual ezdirilme durumunun olması. ister ez iter ezme. abstract olsaydı ezdirme zorunlu.
          {
            get;
          }
          double Cevre
          {
            get;
          }
    }
}
