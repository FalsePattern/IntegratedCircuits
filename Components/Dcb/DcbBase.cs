using PiTung.Components;

namespace IntegratedCircuits.Components.Dcb
{
    class DcbBase : UpdateHandler
    {
        private int digits;
        private int bits;
        public DcbBase(int digits, int bits)
        {
            this.digits = digits;
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            long val = 0;
            for (int i = digits - 1; i >= 0; i--)
            {
                val *= 10;
                val += Util.ReadIntFromInputs(Inputs, i * 4, i * 4 + 3);
            }
            Util.WriteLongToOutputs(Outputs, 0, bits - 1, val);
        }
    }
}
