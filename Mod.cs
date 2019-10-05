using System;

namespace IntegratedCircuits
{
    public class IntegratedCircuits : PiTung.Mod
    {
        public override string Name => CommonData.name;
        public override string PackageName => CommonData.packageName;
        public override string Author => CommonData.author;
        public override Version ModVersion => CommonData.modVersion;

        public override void BeforePatch()
        {
            new IntegerCircuitLoader().LoadIntegerCircuits();
            new FloatCircuitLoader().LoadFloatCircuits();
        }
    }
}
