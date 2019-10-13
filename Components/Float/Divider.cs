namespace IntegratedCircuits.Components.Float
{
    class Divider : BinOp
    {
        protected override float Operate(float a, float b)
        {
            return a / b;
        }
    }
}
