using PiTung.Components;

namespace IntegratedCircuits.Components.Float
{
    class FloatToInt : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            Util.WriteIntToOutputs(Outputs, 0, 31, (int)FloatUtil.ReadIEEE754Float(Inputs, 0));
        }
    }
}
