using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Dmuxb
{
    class DMuxBBase : UpdateHandler
    {
        private int bits;
        public DMuxBBase(int bits)
        {
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            int data = Util.ReadIntFromInputs(Inputs, 1, bits);
            bool s = Inputs[0].On;
            Util.WriteIntToOutputs(Outputs, bits, bits * 2 - 1, s ? data : 0);
            Util.WriteIntToOutputs(Outputs, 0, bits - 1, s ? 0 : data);
        }
    }
}
