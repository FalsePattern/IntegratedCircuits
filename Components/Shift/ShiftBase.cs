using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Shift
{
    class ShiftBase : UpdateHandler
    {
        private int bits;
        private int shiftBits;
        public ShiftBase(int bits, int shiftBits)
        {
            this.bits = bits;
            this.shiftBits = shiftBits;
        }

        protected override void CircuitLogicUpdate()
        {
            int shiftCount = Util.ReadIntFromInputs(Inputs, 0, shiftBits - 1);
            bool reverse = Inputs[shiftBits].On;
            uint inputData = Util.ReadUIntFromInputs(Inputs, shiftBits + 1, shiftBits + bits);
            uint result = reverse ? inputData >> shiftCount : inputData << shiftCount;
            Util.WriteUIntToOutputs(Outputs, 0, bits - 1, result);

        }
    }
}
