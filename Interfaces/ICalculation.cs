﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Interfaces
{
    interface ICalculation<T>
    {
        T Calculate();
    }
}
