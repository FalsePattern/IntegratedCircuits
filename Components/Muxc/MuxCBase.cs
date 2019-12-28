using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Muxc
{
    class MuxCBase : UpdateHandler
    {
        private int selectorBits;

        public MuxCBase(int selectorBits)
        {
            this.selectorBits = selectorBits;
        }

        protected override void CircuitLogicUpdate()
        {
            int selector = Util.ReadIntFromInputs(Inputs, 0, selectorBits - 1);
            Outputs[0].On = Inputs[selectorBits + selector].On;
        }
    }
}
