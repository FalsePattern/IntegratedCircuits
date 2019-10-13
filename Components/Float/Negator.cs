using PiTung.Components;

namespace IntegratedCircuits.Components.Float
{
    class Negator : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            FloatUtil.WriteIEEE754Float(Outputs, 0, -FloatUtil.ReadIEEE754Float(Inputs, 0));
        }
    }
}
