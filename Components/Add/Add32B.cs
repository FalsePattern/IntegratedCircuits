namespace IntegratedCircuits.Components.Add
{
    class Add32B : AddBase
    {
        public Add32B() : base(32) { }

        protected override void CircuitLogicUpdate()
        {
            long a = Util.ReadLongFromInputs(Inputs, 0, 31);
            long b = Util.ReadLongFromInputs(Inputs, 32, 63);
            long cin = Inputs[64].On ? 1 : 0;
            Util.WriteLongToOutputs(Outputs, 0, 32, a + b + cin);
        }
    }
}
