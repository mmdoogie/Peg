﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peg
{
    class LayoutFeatures
    {
        public bool perkey { get; set; }
        public bool oled { get; set; }
        public bool ble { get; set; }
        public bool underglow { get; set; }
        public string name { get; set; }
        public string creator { get; set; }
        public int perkeyCount { get; set; }
        public int underglowCount { get; set; }
        public bool split { get; set; }

    }
}
