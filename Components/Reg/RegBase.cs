using PiTung.Components;

namespace IntegratedCircuits.Components.Reg
{
    class RegBase : UpdateHandler
    {

        [SaveThis]
        public int value;

        [SaveThis]
        public bool prevWrite;

        private int bits;

        public RegBase(int bits)
        {
            this.bits = bits;
        }

        protected override void CircuitLogicUpdate()
        {
            bool write = Inputs[0].On;
            if (write && !prevWrite)
            {
                value = Util.ReadIntFromInputs(Inputs, 1, bits);
            }
            prevWrite = write;
            Util.WriteIntToOutputs(Outputs, 0, bits - 1, value);
        }
    }
}
