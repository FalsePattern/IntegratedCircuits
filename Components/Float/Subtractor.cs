namespace IntegratedCircuits.Components.Float
{
    class Subtractor : BinOp
    {
        protected override float Operate(float a, float b)
        {
            return a - b;
        }
    }
}
