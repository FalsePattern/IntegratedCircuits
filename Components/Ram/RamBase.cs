using PiTung.Components;

namespace IntegratedCircuits.Components.Ram
{
    class RamBase : UpdateHandler
    {
        [SaveThis]
        public int[] content;

        private int bits;
        public RamBase(int bits)
        {
            this.bits = bits;
            if (content == null)
            {
                content = new int[1 << bits];
            }
        }

        protected override void CircuitLogicUpdate()
        {
            int address = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            int value = Util.ReadIntFromInputs(Inputs, bits + 1, bits * 2);
            bool write = Inputs[bits].On;
            if (write)
            {
                content[address] = value;
            }
            Util.WriteIntToOutputs(Outputs, 0, bits - 1, content[address]);
        }
    }
}
