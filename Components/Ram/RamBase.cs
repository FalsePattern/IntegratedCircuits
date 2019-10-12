using PiTung.Components;

namespace IntegratedCircuits.Components.Ram
{
    class RamBase : UpdateHandler
    {
        [SaveThis]
        public int[] content;

        [SaveThis]
        public bool prevWrite;

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
            if (write && !prevWrite)
            {
                content[address] = value;
            }
            prevWrite = write;
            Util.WriteIntToOutputs(Outputs, 0, bits - 1, content[address]);
        }
    }
}
