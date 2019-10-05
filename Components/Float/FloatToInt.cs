using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Float
{
    class FloatToInt : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            Util.WriteIntToOutputs(Outputs, 0, 31, (int)FloatUtil.ReadIEEE754Float(Inputs, 0));
        }
    }
}
