using IntegratedCircuits;
using IntegratedCircuits.Components;
using IntegratedCircuits.Components.Add;
using IntegratedCircuits.Components.And;
using IntegratedCircuits.Components.Bcd;
using IntegratedCircuits.Components.Dcb;
using IntegratedCircuits.Components.Inc;
using IntegratedCircuits.Components.Mul;
using IntegratedCircuits.Components.Nand;
using IntegratedCircuits.Components.Ram;
using IntegratedCircuits.Components.Xor;
using PiTung.Components;
using System;

namespace IntegratedCircuits1B
{
    public class IntegratedCircuits1B : PiTung.Mod
    {
        public override string Name => CommonData.name;
        public override string PackageName => CommonData.packageName;
        public override string Author => CommonData.author;
        public override Version ModVersion => CommonData.modVersion;

        public override void BeforePatch()
        {
            CreateAdds();
            CreateAnds();
            CreateBcds();
            CreateDcbs();
            CreateIncs();
            CreateMuls();
            CreateNands();
            CreateRams();
            CreateXors();
        }

        internal void CreateAdds()
        {
            CreateAdd<Add1B>(1);
            CreateAdd<Add4B>(4);
            CreateAdd<Add8B>(8);
            CreateAdd<Add12B>(12);
            CreateAdd<Add16B>(16);
        }

        internal void CreateBcds()
        {
            CreateBcd<Bcd4B>(4, 2);
            CreateBcd<Bcd8B>(8, 3);
            CreateBcd<Bcd12B>(12, 4);
            CreateBcd<Bcd16B>(16, 5);
        }

        internal void CreateDcbs()
        {
            CreateDcb<Dcb2D>(2, 7);
            CreateDcb<Dcb3D>(3, 10);
            CreateDcb<Dcb4D>(4, 14);
            CreateDcb<Dcb5D>(5, 17);
        }

        internal void CreateMuls()
        {
            CreateMul<Mul4B>(4);
            CreateMul<Mul8B>(8);
            CreateMul<Mul12B>(12);
            CreateMul<Mul16B>(16);
        }

        internal void CreateIncs()
        {
            CreateInc<Inc1B>(1);
            CreateInc<Inc4B>(4);
            CreateInc<Inc8B>(8);
            CreateInc<Inc12B>(12);
            CreateInc<Inc16B>(16);
        }

        internal void CreateRams()
        {
            CreateRam<Ram1B>(1);
            CreateRam<Ram4B>(4);
            CreateRam<Ram8B>(8);
            CreateRam<Ram12B>(12);
            CreateRam<Ram16B>(16);
        }

        internal void CreateAnds()
        {
            Create2InputGate<And1B>("and", 1);
            Create2InputGate<And4B>("and", 4);
            Create2InputGate<And8B>("and", 8);
            Create2InputGate<And12B>("and", 12);
            Create2InputGate<And16B>("and", 16);
        }
        internal void CreateNands()
        {
            Create2InputGate<Nand1B>("nand", 1);
            Create2InputGate<Nand4B>("nand", 4);
            Create2InputGate<Nand8B>("nand", 8);
            Create2InputGate<Nand12B>("nand", 12);
            Create2InputGate<Nand16B>("nand", 16);
        }

        internal void CreateXors()
        {
            Create2InputGate<Xor1B>("xor", 1);
            Create2InputGate<Xor4B>("xor", 4);
            Create2InputGate<Xor8B>("xor", 8);
            Create2InputGate<Xor12B>("xor", 12);
            Create2InputGate<Xor16B>("xor", 16);
        }


        internal void CreateAdd<T>(int bits) where T : AddBase
        {
            ComponentRegistry.CreateNew<T>("add" + bits, "ADD " + bits + " Bit", BuilderHelper.CreateAdd(bits));
        }

        internal void CreateBcd<T>(int bits, int digits) where T : BcdBase
        {

            ComponentRegistry.CreateNew<T>("bcd" + bits, "BIN to BCD " + bits + " Bit", BuilderHelper.CreateBcd(bits, digits));
        }

        internal void CreateDcb<T>(int digits, int bits) where T : DcbBase
        {

            ComponentRegistry.CreateNew<T>("dcb" + digits, "BCD to BIN " + digits + " Digit", BuilderHelper.CreateDcb(digits, bits));
        }

        internal void CreateInc<T>(int bits) where T : IncBase
        {

            ComponentRegistry.CreateNew<T>("inc" + bits, "INC " + bits + " Bit", BuilderHelper.CreateInc(bits));
        }

        internal void CreateMul<T>(int bits) where T : MulBase
        {
            ComponentRegistry.CreateNew<T>("mul" + bits, "MUL " + bits + " Bit", BuilderHelper.CreateMul(bits));
        }

        internal void CreateRam<T>(int bits) where T : RamBase
        {

            ComponentRegistry.CreateNew<Ram1B>("ram" + bits, "RAM " + bits + " Bit", BuilderHelper.CreateRam(bits));
        }

        internal void Create2InputGate<T>(string name, int bits) where T: TwoInputGateBase
        {
            ComponentRegistry.CreateNew<T>(name + bits, name.ToUpper() + " " + bits + " Bit", BuilderHelper.Create2To1(bits));
        }
    }
}
