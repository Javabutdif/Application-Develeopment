﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    internal class Hover
    {
        System.Drawing.Color light = ColorTranslator.FromHtml("#107874");
        System.Drawing.Color dark = ColorTranslator.FromHtml("#062e2c");
        System.Drawing.Color lightD = ColorTranslator.FromHtml("#116F6A");
        public Hover() {
        
        }

         public System.Drawing.Color lighter()
        {
            return this.light;
        }
        public System.Drawing.Color darker()
        {
            return this.dark;
        }
        public System.Drawing.Color lightDark()
        {
            return this.lightD;
        }
    }
}
