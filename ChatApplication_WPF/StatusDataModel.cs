﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication_WPF
{
    public class StatusDataModel
    {
        public string ContactName { get; set; }
        //public string StatusMessage { get; set; }
        public Uri ContactImage { get; set; }
        public Uri StatusImage { get; set; }

        public bool IsMeAddStatus { get; set; }
    }
}
