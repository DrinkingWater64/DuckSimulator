﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator.Ovserver
{
    interface Observer
    {
        void Update(Observable observable);
    }
}
