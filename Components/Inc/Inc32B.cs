namespace IntegratedCircuits.Components.Inc
{
    class Inc32B : IncBase
    {

        public Inc32B() : base(32) {}

        protected override void CircuitLogicUpdate()
        {
            long val = Util.ReadLongFromInputs(Inputs, 1, 32);
            Util.WriteLongToOutputs(Outputs, 0, 32, Inputs[0].On ? val - 1 : val + 1);
        }
    }
}
