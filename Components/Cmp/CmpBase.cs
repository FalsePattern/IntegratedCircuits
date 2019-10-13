using PiTung.Components;

namespace IntegratedCircuits.Components.Cmp
{
    class CmpBase : UpdateHandler
    {
        private int bits;
        public CmpBase(int bits)
        {
            this.bits = bits;
        }
        protected override void CircuitLogicUpdate()
        {
            int a = Util.ReadIntFromInputs(Inputs, 0, bits - 1);
            int b = Util.ReadIntFromInputs(Inputs, bits, 2 * bits - 1);
            Outputs[0].On = a < b;
            Outputs[1].On = a == b;
            Outputs[2].On = a > b;
        }
    }
}
