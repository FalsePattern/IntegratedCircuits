using PiTung.Components;

namespace IntegratedCircuits.Components.Matrix
{
    class MatrixBase: UpdateHandler
    {
        [SaveThis]
        public int[] content;

        [SaveThis]
        public bool prevWrite;

        private int bits;
        private int rows;
        private int columns;

        public MatrixBase(int columns, int rowBits) {
            this.rows = 1 << rowBits;
            this.bits = rowBits;
            this.columns = columns;
            if (content == null)
            {
                content = new int[rows];
            }
        }

        protected override void CircuitLogicUpdate()
        {
            ProcessRamMode();
            ProcessGpuMode();
        }

        private void ProcessRamMode()
        {
            int address = Util.ReadIntFromInputs(Inputs, rows + 1, rows + bits);
            bool write = Inputs[columns].On;
            if (write && !prevWrite)
            {
                content[address] = Util.ReadIntFromInputs(Inputs, 0, rows - 1);
            }
            prevWrite = write;
            Util.WriteIntToOutputs(Outputs, 0, columns - 1, content[address]);
        }

        private void ProcessGpuMode()
        {
            for (int i = 0; i < rows; i++)
            {
                int offset = columns + i * columns;
                Util.WriteIntToOutputs(Outputs, offset, offset + columns - 1, content[i]);
            }
        }
    }
}
