﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        private int _wheelCount;

        public int WheelCount { get { return _wheelCount; } }
 
        public Bicycle(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public Bicycle()
        {
            _wheelCount = 0;
        }

    }
}
