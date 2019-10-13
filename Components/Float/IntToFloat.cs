using PiTung.Components;

namespace IntegratedCircuits.Components.Float
{
    class IntToFloat : UpdateHandler
    {
        protected override void CircuitLogicUpdate()
        {
            FloatUtil.WriteIEEE754Float(Outputs, 0, Util.ReadIntFromInputs(Inputs, 0, 31));
        }
    }
}
