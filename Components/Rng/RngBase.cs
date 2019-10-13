using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Rng
{
    class RngBase : UpdateHandler
    {
        private static readonly Random rng = new Random();

        [SaveThis]
        public int value;

        [SaveThis]
        public bool prevState;

        private int bits;

        public RngBase(int bits)
        {
            this.bits = bits;
        }

        protected override void CircuitLogicUpdate()
        {
            if (Inputs[0].On && !prevState)
            {
                if (bits >= 32)
                {
                    value = rng.Next(int.MinValue, int.MaxValue);
                } else
                {
                    value = rng.Next(0, 1 << bits);
                }
            }
            prevState = Inputs[0].On;
            Util.WriteIntToOutputs(Outputs, 0, bits - 1, value);
        }
    }
}
