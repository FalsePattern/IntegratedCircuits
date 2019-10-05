using PiTung.Components;

namespace IntegratedCircuits.Components.Float
{
    abstract class BinOp : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            float a = FloatUtil.ReadIEEE754Float(Inputs, 0);
            float b = FloatUtil.ReadIEEE754Float(Inputs, 32);
            FloatUtil.WriteIEEE754Float(Outputs, 0, Operate(a, b));
        }

        protected abstract float Operate(float a, float b);
    }
}
