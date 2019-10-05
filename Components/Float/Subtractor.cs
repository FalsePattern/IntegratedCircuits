using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Float
{
    class Subtractor : BinOp
    {
        protected override float Operate(float a, float b)
        {
            return a - b;
        }
    }
}
