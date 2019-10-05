namespace IntegratedCircuits.Components.And
{
    class AndBase : TwoInputGateBase
    {
        public AndBase(int bits) : base(bits) { }
        protected override int operate(int a, int b)
        {
            return a & b;
        }
    }
}
