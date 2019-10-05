using PiTung.Components;
using PiTung.Console;

namespace IntegratedCircuits.Components
{
    abstract class TwoInputGateBase : UpdateHandler
    {
        private int bits;

        public TwoInputGateBase(int bits)
        {
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            int a = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            int b = Util.ReadIntFromInputs(Inputs, bits, bits * 2 - 1);
            Util.WriteIntToOutputs(Outputs, 0, bits - 1, operate(a, b));
        }

        protected abstract int operate(int a, int b);
    }
}
