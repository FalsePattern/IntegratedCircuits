namespace IntegratedCircuits.Components.Float
{
    class Moduler : BinOp
    {
        protected override float Operate(float a, float b)
        {
            return a % b;
        }
    }
}
