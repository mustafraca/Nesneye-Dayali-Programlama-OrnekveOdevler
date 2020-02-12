/****************************************************************************
**			                SAKARYA ÜNİVERSİTESİ 
**		            BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
**		             BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**		                  NESNEYE DAYALI PROGRAMLAMA
**			                2017-2018 BAHAR DÖNEMİ 
**  
**			              ÖDEV NUMARASI..........: 2
**			              ÖĞRENCİ ADI............: Mustafa ACAR
**			              ÖĞRENCİ NUMARASI.......: B161200304
**                        DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B161200304
{
    class Program
    {

        static void Main(string[] args)
        {
            Fark fark = new Fark();
            fark.Birlestir();
            Console.ReadKey();
        }
    }
}
