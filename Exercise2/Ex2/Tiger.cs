﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Ex2
{
    public class Tiger : Animal
    {
        public Tiger(double weight, string name)
        {
            base.SetMe(weight, name);
        }

        public override void Show()
        {
            base.Show();

        }
    }
}
