using PiTung.Components;

namespace IntegratedCircuits.Components.Bcd
{
    class BcdBase : UpdateHandler
    {
        private int bits;
        private int digits;
        public BcdBase(int bits, int digits)
        {
            this.bits = bits;
            this.digits = digits;
        }

        protected override void CircuitLogicUpdate()
        {
            int val = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            for (int i = 0; i < digits; i++)
            {
                Util.WriteIntToOutputs(Outputs, i * 4, i * 4 + 3, val % 10);
                val /= 10;
            }
        }
    }
}
