using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegratedCircuits.Components.Float
{
    internal sealed class FloatUtil
    {
        public static float ReadIEEE754Float(CircuitInput[] Inputs, int lsb)
        {
            byte[] bytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                bytes[i] = (byte)Util.ReadIntFromInputs(Inputs, 8 * i + lsb, 8 * i + 7 + lsb);
            }
            return BitConverter.ToSingle(bytes, 0);
        }

        public static void WriteIEEE754Float(CircuitOutput[] Outputs, int lsb, float value)
        {

            byte[] bytes = BitConverter.GetBytes(value);
            for (int i = 0; i < 4; i++)
            {
                Util.WriteIntToOutputs(Outputs, 8 * i + lsb, 8 * i + 7 + lsb, bytes[i]);
            }
        }
    }
}
