using PiTung.Components;

namespace IntegratedCircuits.Components.Add
{
    class AddBase : UpdateHandler
    {
        private int bits;
        public AddBase(int bits)
        {
            this.bits = bits;
        }

        protected override void CircuitLogicUpdate()
        {
            int a = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            int b = Util.ReadIntFromInputs(Inputs, bits, bits * 2 - 1);
            int cin = Inputs[bits * 2].On ? 1 : 0;
            Util.WriteIntToOutputs(Outputs, 0, bits, a + b + cin);
        }
    }
}
