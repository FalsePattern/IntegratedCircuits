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
                result |= multiplier * (inputs[i + lsb].On ? 1 : 0);
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
        public static void WriteLongToOutputs(CircuitOutput[] outputs, int lsb, int msb, long value)
        {
            int delta = msb - lsb;
            for (int i = 0; i <= delta; i++)
            {
                outputs[i + lsb].On = (value & (1L << i)) != 0;
            }
        }
    }
}
