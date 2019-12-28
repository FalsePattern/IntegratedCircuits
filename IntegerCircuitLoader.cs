using IntegratedCircuits.Components;
using IntegratedCircuits.Components.Add;
using IntegratedCircuits.Components.And;
using IntegratedCircuits.Components.Bcd;
using IntegratedCircuits.Components.Cmp;
using IntegratedCircuits.Components.Dcb;
using IntegratedCircuits.Components.Div;
using IntegratedCircuits.Components.Dmuxb;
using IntegratedCircuits.Components.DMuxc;
using IntegratedCircuits.Components.Inc;
using IntegratedCircuits.Components.Matrix;
using IntegratedCircuits.Components.Mul;
using IntegratedCircuits.Components.Muxb;
using IntegratedCircuits.Components.Muxc;
using IntegratedCircuits.Components.Nand;
using IntegratedCircuits.Components.Ram;
using IntegratedCircuits.Components.Reg;
using IntegratedCircuits.Components.Rng;
using IntegratedCircuits.Components.Xor;
using PiTung.Components;

namespace IntegratedCircuits
{
    internal sealed class IntegerCircuitLoader
    {

        public void LoadIntegerCircuits()
        {

            CreateAdds();
            CreateAnds();
            CreateBcds();
            CreateCmps();
            CreateDcbs();
            CreateDivs();
            CreateDMuxBs();
            CreateDMuxCs();
            CreateIncs();
            CreateMuls();
            CreateMuxBs();
            CreateMuxCs();
            CreateMatrices();
            CreateNands();
            CreateRams();
            CreateRegs();
            CreateRngs();
            CreateXors();
        }
        internal void CreateAdds()
        {
            CreateAdd<Add1B>(1);
            CreateAdd<Add4B>(4);
            CreateAdd<Add8B>(8);
            CreateAdd<Add12B>(12);
            CreateAdd<Add16B>(16);
            CreateAdd<Add32B>(32);
        }

        internal void CreateBcds()
        {
            CreateBcd<Bcd4B>(4, 2);
            CreateBcd<Bcd8B>(8, 3);
            CreateBcd<Bcd12B>(12, 4);
            CreateBcd<Bcd16B>(16, 5);
            CreateBcd<Bcd32B>(32, 10);
        }

        internal void CreateCmps()
        {
            CreateCmp<Cmp4B>(4);
            CreateCmp<Cmp8B>(8);
            CreateCmp<Cmp12B>(12);
            CreateCmp<Cmp16B>(16);
            CreateCmp<Cmp32B>(32);
        }

        internal void CreateDcbs()
        {
            CreateDcb<Dcb2D>(2, 7);
            CreateDcb<Dcb3D>(3, 10);
            CreateDcb<Dcb4D>(4, 14);
            CreateDcb<Dcb5D>(5, 17);
            CreateDcb<Dcb6D>(6, 20);
            CreateDcb<Dcb7D>(7, 24);
            CreateDcb<Dcb8D>(8, 27);
            CreateDcb<Dcb9D>(9, 30);
            CreateDcb<Dcb10D>(10, 34);
        }

        internal void CreateDivs()
        {
            CreateDiv<Div4B>(4);
            CreateDiv<Div8B>(8);
            CreateDiv<Div12B>(12);
            CreateDiv<Div16B>(16);
            CreateDiv<Div32B>(32);
        }

        internal void CreateDMuxBs()
        {
            CreateDMuxB<DMuxB4>(4);
            CreateDMuxB<DMuxB8>(8);
            CreateDMuxB<DMuxB12>(12);
            CreateDMuxB<DMuxB16>(16);
            CreateDMuxB<DMuxB32>(32);
        }

        internal void CreateDMuxCs()
        {
            CreateDMuxC<DMuxC2>(2, 1);
            CreateDMuxC<DMuxC4>(4, 2);
            CreateDMuxC<DMuxC8>(8, 3);
            CreateDMuxC<DMuxC16>(16, 4);
            CreateDMuxC<DMuxC32>(32, 5);
        }

        internal void CreateMuls()
        {
            CreateMul<Mul4B>(4);
            CreateMul<Mul8B>(8);
            CreateMul<Mul12B>(12);
            CreateMul<Mul16B>(16);
            CreateMul<Mul32B>(32);
        }

        internal void CreateMuxCs()
        {
            CreateMuxC<MuxC2>(2, 1);
            CreateMuxC<MuxC4>(4, 2);
            CreateMuxC<MuxC8>(8, 3);
            CreateMuxC<MuxC16>(16, 4);
            CreateMuxC<MuxC32>(32, 5);
        }

        internal void CreateMuxBs()
        {
            CreateMuxB<MuxB4>(4);
            CreateMuxB<MuxB8>(8);
            CreateMuxB<MuxB12>(12);
            CreateMuxB<MuxB16>(16);
            CreateMuxB<MuxB32>(32);
        }

        internal void CreateMatrices()
        {
            CreateMatrix<Matrix4>(4, 2);
            CreateMatrix<Matrix8>(8, 3);
            CreateMatrix<Matrix16>(16, 4);
            CreateMatrix<Matrix32>(32, 5);
        }
        
        internal void CreateIncs()
        {
            CreateInc<Inc1B>(1);
            CreateInc<Inc4B>(4);
            CreateInc<Inc8B>(8);
            CreateInc<Inc12B>(12);
            CreateInc<Inc16B>(16);
            CreateInc<Inc32B>(32);
        }

        internal void CreateRams()
        {
            CreateRam<Ram1B>(1);
            CreateRam<Ram4B>(4);
            CreateRam<Ram8B>(8);
            CreateRam<Ram12B>(12);
            CreateRam<Ram16B>(16);
            ComponentRegistry.CreateNew<Ram32B>("ram32b", "RAM 32 Bit", BuilderHelper.CreateMultiIOChip(24, 1, 32, 32, false, false, true, false, "A", "Write", "O", "D", false, true, false, false));
        }

        internal void CreateRegs()
        {
            CreateReg<Reg1B>(1);
            CreateReg<Reg2B>(2);
            CreateReg<Reg4B>(4);
            CreateReg<Reg8B>(8);
            CreateReg<Reg16B>(16);
            CreateReg<Reg32B>(32);
        }

        internal void CreateRngs()
        {
            CreateRng<Rng4B>(4);
            CreateRng<Rng8B>(8);
            CreateRng<Rng12B>(12);
            CreateRng<Rng16B>(16);
            CreateRng<Rng32B>(32);
        }

        internal void CreateAnds()
        {
            Create2InputGate<And1B>("and", 1);
            Create2InputGate<And4B>("and", 4);
            Create2InputGate<And8B>("and", 8);
            Create2InputGate<And12B>("and", 12);
            Create2InputGate<And16B>("and", 16);
            Create2InputGate<And32B>("and", 32);
        }
        internal void CreateNands()
        {
            Create2InputGate<Nand1B>("nand", 1);
            Create2InputGate<Nand4B>("nand", 4);
            Create2InputGate<Nand8B>("nand", 8);
            Create2InputGate<Nand12B>("nand", 12);
            Create2InputGate<Nand16B>("nand", 16);
            Create2InputGate<Nand32B>("nand", 32);
        }

        internal void CreateXors()
        {
            Create2InputGate<Xor1B>("xor", 1);
            Create2InputGate<Xor4B>("xor", 4);
            Create2InputGate<Xor8B>("xor", 8);
            Create2InputGate<Xor12B>("xor", 12);
            Create2InputGate<Xor16B>("xor", 16);
            Create2InputGate<Xor32B>("xor", 32);
        }


        internal void CreateAdd<T>(int bits) where T : AddBase
        {
            ComponentRegistry.CreateNew<T>("add" + bits, "ADD " + bits + " Bit", BuilderHelper.CreateAdd(bits));
        }

        internal void CreateBcd<T>(int bits, int digits) where T : BcdBase
        {

            ComponentRegistry.CreateNew<T>("bcd" + bits, "BIN to BCD " + bits + " Bit", BuilderHelper.CreateBcd(bits, digits));
        }

        internal void CreateCmp<T>(int bits) where T : CmpBase
        {
            ComponentRegistry.CreateNew<T>("cmp" + bits, "CMP " + bits + " Bit", BuilderHelper.CreateCmp(bits));
        }

        internal void CreateDcb<T>(int digits, int bits) where T : DcbBase
        {

            ComponentRegistry.CreateNew<T>("dcb" + digits, "BCD to BIN " + digits + " Digit", BuilderHelper.CreateDcb(digits, bits));
        }

        internal void CreateDiv<T>(int bits) where T : DivBase
        {
            ComponentRegistry.CreateNew<T>("div" + bits, "DIV " + bits + " Bit", BuilderHelper.CreateDiv(bits));
        }

        internal void CreateDMuxB<T>(int bits) where T : DMuxBBase
        {
            ComponentRegistry.CreateNew<T>("dmuxb" + bits, "DMUXB" + bits, BuilderHelper.CreateDMuxB(bits));
        }

        internal void CreateDMuxC<T>(int channels, int selectorBits) where T : DMuxCBase
        {
            ComponentRegistry.CreateNew<T>("dmuxc" + channels, "DMUXC" + channels, BuilderHelper.CreateDMuxC(channels, selectorBits));
        }

        internal void CreateInc<T>(int bits) where T : IncBase
        {

            ComponentRegistry.CreateNew<T>("inc" + bits, "INC " + bits + " Bit", BuilderHelper.CreateInc(bits));
        }

        internal void CreateMatrix<T>(int columns, int rowBits) where T : MatrixBase
        {
            ComponentRegistry.CreateNew<T>("matrix" + columns + "x" + (1 << rowBits), "MATRIX " + columns + "X" + (1 << rowBits), BuilderHelper.CreateMatrix(columns, rowBits));
        }

        internal void CreateMul<T>(int bits) where T : MulBase
        {
            ComponentRegistry.CreateNew<T>("mul" + bits, "MUL " + bits + " Bit", BuilderHelper.CreateMul(bits));
        }

        internal void CreateMuxC<T>(int channels, int selectorBits) where T : MuxCBase
        {
            ComponentRegistry.CreateNew<T>("muxc" + channels, "MUXC" + channels, BuilderHelper.CreateMuxC(channels, selectorBits));
        }

        internal void CreateMuxB<T>(int bits) where T : MuxBBase
        {
            ComponentRegistry.CreateNew<T>("muxb" + bits, "MUXB" + bits, BuilderHelper.CreateMuxB(bits));
        }

        internal void CreateRam<T>(int bits) where T : UpdateHandler
        {

            ComponentRegistry.CreateNew<T>("ram" + bits, "RAM " + bits + " Bit", BuilderHelper.CreateRam(bits));
        }

        internal void CreateReg<T>(int bits) where T : RegBase
        {
            ComponentRegistry.CreateNew<T>("reg" + bits, "REG " + bits + " Bit", BuilderHelper.CreateReg(bits));
        }

        internal void CreateRng<T>(int bits) where T : RngBase
        {
            ComponentRegistry.CreateNew<T>("rng" + bits, "RNG " + bits + " Bit", BuilderHelper.CreateRng(bits));
        }

        internal void Create2InputGate<T>(string name, int bits) where T : TwoInputGateBase
        {
            ComponentRegistry.CreateNew<T>(name + bits, name.ToUpper() + " " + bits + " Bit", BuilderHelper.Create2To1(bits));
        }
    }

}
