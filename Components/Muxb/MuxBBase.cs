using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Muxb
{
    class MuxBBase : TwoInputGateBase
    {
        private int selectorID;
        public MuxBBase(int bits) : base(bits)
        {
            this.selectorID = bits * 2;
        }

        protected override int operate(int a, int b)
        {
            if (Inputs[selectorID].On)
            {
                return b;
            } else
            {
                return a;
            }
        }
    }
}
