﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP12
{
    class YOgrenci:Kisi ,IOgrenci
    {
        private String ogrNo;
        public String OgrNo
        {
            set { ogrNo = value; }
            get { return "Y" + ogrNo; }
        }
    }
}
