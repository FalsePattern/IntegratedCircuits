using PiTung.Components;

namespace IntegratedCircuits.Components.Inc
{
    class IncBase : UpdateHandler
    {
        private int bits;
        public IncBase(int bits)
        {
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            int val = Util.ReadIntFromInputs(Inputs, 1, bits);
            Util.WriteIntToOutputs(Outputs, 0, bits, Inputs[0].On ? val - 1 : val + 1);
        }
    }
}
