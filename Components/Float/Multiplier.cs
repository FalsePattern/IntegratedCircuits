namespace IntegratedCircuits.Components.Float
{
    class Multiplier : BinOp
    {
        protected override float Operate(float a, float b)
        {
            return a * b;
        }
    }
}
