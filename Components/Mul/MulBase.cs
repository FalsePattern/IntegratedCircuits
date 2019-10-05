using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Mul
{
    class MulBase : UpdateHandler
    {
        private int bits;
        public MulBase(int bits)
        {
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            int a = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            int b = Util.ReadIntFromInputs(Inputs, bits, bits + bits - 1);
            long result = a * b;
            Util.WriteLongToOutputs(Outputs, 0, bits * 2 - 1, result);
        }
    }
}
