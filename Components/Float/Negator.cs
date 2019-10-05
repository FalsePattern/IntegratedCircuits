using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Float
{
    class Negator : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            FloatUtil.WriteIEEE754Float(Outputs, 0, -FloatUtil.ReadIEEE754Float(Inputs, 0));
        }
    }
}
