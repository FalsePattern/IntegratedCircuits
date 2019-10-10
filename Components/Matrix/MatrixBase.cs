using IntegratedCircuits.Components.Ram;
using PiTung.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Matrix
{
    class MatrixBase: UpdateHandler
    {
        [SaveThis]
        public int[] content;

        private int rows;
        private int columns;

        public MatrixBase(int rows, int columnBits) {
            this.rows = rows;
            this.columns = 1 << columnBits;
            if (content == null)
            {
                content = new int[1 << columnBits];
            }
        }

        protected override void CircuitLogicUpdate()
        {
            //ProcessRamMode();
            //ProcessGpuMode();
        }

        private void ProcessRamMode()
        {

            int value = Util.ReadIntFromInputs(Inputs, 0, rows - 1);
            int address = Util.ReadIntFromInputs(Inputs, rows + 1, 2 * rows);
            bool write = Inputs[columns].On;
            if (write)
            {
                content[address] = value;
            }
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
