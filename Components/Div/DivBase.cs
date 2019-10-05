using PiTung.Components;

namespace IntegratedCircuits.Components.Div
{
    class DivBase : UpdateHandler
    {
        private int bits;

        public DivBase(int bits)
        {
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            int a = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            int b = Util.ReadIntFromInputs(Inputs, bits, bits + bits - 1);
            Outputs[bits].On = b == 0;
            if (b != 0)
            {
                Util.WriteIntToOutputs(Outputs, 0, bits - 1, a / b);
            } else
            {
                Util.WriteIntToOutputs(Outputs, 0, bits - 1, 0);
            }
        }
    }
}
