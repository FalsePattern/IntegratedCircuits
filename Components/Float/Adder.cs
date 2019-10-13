namespace IntegratedCircuits.Components.Float
{
    class Adder : BinOp
    {
        protected override float Operate(float a, float b)
        {
            return a + b;
        }
    }
}
