using PiTung.Components;

namespace IntegratedCircuits.Components.Ram
{
    class Ram32B : UpdateHandler
    {
        [SaveThis]
        public int[] content;

        [SaveThis]
        public bool prevWrite;
        public Ram32B()
        {
            if (content == null)
            {
                content = new int[1 << 24];
            }
        }

        protected override void CircuitLogicUpdate()
        {
            int address = Util.ReadIntFromInputs(Inputs, 0, 23);
            bool write = Inputs[24].On;
            if (write && !prevWrite)
            {
                content[address] = Util.ReadIntFromInputs(Inputs, 25, 56);
            }
            prevWrite = write;
            Util.WriteIntToOutputs(Outputs, 0, 31, content[address]);
        }
    }
}
