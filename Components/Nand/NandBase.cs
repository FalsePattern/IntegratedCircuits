namespace IntegratedCircuits.Components.Nand
{
    class NandBase : TwoInputGateBase
    {
        public NandBase(int bits) : base(bits) { }
        protected override int operate(int a, int b)
        {
            return ~(a & b);
        }
    }
}
