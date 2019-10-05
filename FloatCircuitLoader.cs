using IntegratedCircuits.Components.Float;
using PiTung.Components;

namespace IntegratedCircuits
{
    internal sealed class FloatCircuitLoader
    {
        public void LoadFloatCircuits()
        {
            var unary = BuilderHelper.Create1To1(32);
            var binary = BuilderHelper.Create2To1(32);
            ComponentRegistry.CreateNew<IntToFloat>("ifconv", "INT to FLOAT conv", unary);
            ComponentRegistry.CreateNew<FloatToInt>("ficonv", "FLOAT to INT conv", unary);
            ComponentRegistry.CreateNew<Negator>("fneg", "FLOAT negator", unary);
            ComponentRegistry.CreateNew<Adder>("fadd", "FLOAT adder", binary);
            ComponentRegistry.CreateNew<Divider>("fdiv", "FLOAT divider", binary);
            ComponentRegistry.CreateNew<Moduler>("fmod", "FLOAT modulo", binary);
            ComponentRegistry.CreateNew<Multiplier>("fmul", "FLOAT multiplier", binary);
            ComponentRegistry.CreateNew<Subtractor>("fsub", "FLOAT subtractor", binary);
        }
    }
}
