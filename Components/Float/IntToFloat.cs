using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Float
{
    class IntToFloat : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            FloatUtil.WriteIEEE754Float(Outputs, 0, Util.ReadIntFromInputs(Inputs, 0, 31));
        }
    }
}
