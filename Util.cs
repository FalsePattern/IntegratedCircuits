namespace IntegratedCircuits
{
    public class Util
    {
        public static int ReadIntFromInputs(CircuitInput[] inputs, int lsb, int msb)
        {
            int result = 0;
            int multiplier = 1;
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                result |= inputs[i + lsb].On ? multiplier : 0;
                multiplier <<= 1;
            }
            return result;
        }

        public static uint ReadUIntFromInputs(CircuitInput[] inputs, int lsb, int msb)
        {
            uint result = 0;
            uint multiplier = 1;
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                result |= inputs[i + lsb].On ? multiplier : 0u;
                multiplier <<= 1;
            }
            return result;
        }

        public static long ReadLongFromInputs(CircuitInput[] inputs, int lsb, int msb)
        {
            long result = 0L;
            long multiplier = 1L;
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                result |= inputs[i + lsb].On ? multiplier : 0L;
                multiplier <<= 1;
            }
            return result;
        }

        public static void WriteIntToOutputs(CircuitOutput[] outputs, int lsb, int msb, int value)
        {
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                outputs[i + lsb].On = (value & (1 << i)) != 0;
            }
        }
        public static void WriteUIntToOutputs(CircuitOutput[] outputs, int lsb, int msb, uint value)
        {
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                outputs[i + lsb].On = (value & (1u << i)) != 0;
            }
        }

        public static void WriteLongToOutputs(CircuitOutput[] outputs, int lsb, int msb, long value)
        {
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                outputs[i + lsb].On = (value & (1L << i)) != 0;
            }
        }

        public static uint RotateLeft(uint value, int bits, int count)
        {
            uint mask = (1u << bits) - 1;
            value &= mask;
            return ((value << count) | (value >> (bits - count))) & mask;
        }

        public static uint RotateRight(uint value, int bits, int count)
        {
            uint mask = (1u << bits) - 1;
            value &= mask;
            return ((value >> count) | (value << (bits - count))) & mask;
        }
    }
}
