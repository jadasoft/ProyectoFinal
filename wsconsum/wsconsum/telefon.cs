﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsconsum
{
    class telefon
    {
        public int telId { get; set; }
        public string telefon1 { get; set; }
        public string tipus { get; set; }
        public Nullable<int> contacteId { get; set; }

        public virtual contacte contacte { get; set; }
    }
}
