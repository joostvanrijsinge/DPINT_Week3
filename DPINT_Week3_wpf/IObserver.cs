﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Week3
{
    public interface IObserver
    {
        void Update(int counter);
    }
}
