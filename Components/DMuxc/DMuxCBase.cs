using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.DMuxc
{
    class DMuxCBase : UpdateHandler
    {
        private int selectorBits;
        private int channels;

        public DMuxCBase(int selectorBits)
        {
            this.selectorBits = selectorBits;
            this.channels = 1 << selectorBits;
        }

        protected override void CircuitLogicUpdate()
        {
            int selector = Util.ReadIntFromInputs(Inputs, 0, selectorBits - 1);
            Util.WriteIntToOutputs(Outputs, 0, channels - 1, 0);
            Outputs[selector].On = Inputs[selectorBits].On;
        }
    }
}
