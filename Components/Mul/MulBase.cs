using PiTung.Components;

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
            long a = Util.ReadLongFromInputs(Inputs, 0, bits - 1);
            long b = Util.ReadLongFromInputs(Inputs, bits, bits + bits - 1);
            long result = a * b;
            Util.WriteLongToOutputs(Outputs, 0, bits * 2 - 1, result);
        }
    }
}
