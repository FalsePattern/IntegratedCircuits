namespace IntegratedCircuits.Components.Xor
{
    class XorBase : TwoInputGateBase
    {
        public XorBase(int bits) : base(bits) { }
        protected override int operate(int a, int b)
        {
            return a ^ b;
        }
    }
}
