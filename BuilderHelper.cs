using PiTung.Components;
using System;
using UnityEngine;

namespace IntegratedCircuits
{
    public class BuilderHelper
    {
        private const float baseSize = 0.3f;

        public static CustomBuilder CreateRam(int bits)
        {
            return CreateMultiIOChip(bits, 1, bits, bits, false, false, true, false, "A", "Write", "O", "D", false, true, false, false);
        }

        public static CustomBuilder Create1To1(int bits)
        {
            return CreateMultiIOChip(0, 0, bits, bits, false, false, true, false, "", "", "O", "I", false, false, false, false);
        }

        public static CustomBuilder Create2To1(int bits)
        {
            return CreateMultiIOChip(bits, bits, bits, 0, false, false, true, false, "A", "B", "O", "", false, false, false, false);
        }

        public static CustomBuilder CreateAdd(int bits)
        {
            return CreateMultiIOChip(bits, bits, bits + 1, 1, false, false, true, false, "A", "B", "S", "Cin", false, false, false, true);
        }

        public static CustomBuilder CreateBcd(int bits, int digits)
        {
            return CreateMultiIOChip(0, 0, digits * 4, bits, false, false, true, false, "", "", "BCD", "BIN", false, false, false, false);
        }

        public static CustomBuilder CreateDcb(int digits, int bits)
        {
            return CreateMultiIOChip(0, 0, bits, digits * 4, false, false, true, false, "", "", "BIN", "BCD", false, false, false, false);
        }


        public static CustomBuilder CreateInc(int bits)
        {
            return CreateMultiIOChip(0, 1, bits + 1, bits, false, false, true, false, "", "DEC", "O", "I", false, true, false, false);
        }

        public static CustomBuilder CreateMul(int bits)
        {
            return CreateMultiIOChip(bits, bits, bits * 2, 0, false, false, true, false, "A", "B", "O", "", false, false, false, false);
        }

        public static CustomBuilder CreateMultiIOChip(int leftIO, int rightIO, int frontIO, int backIO, bool leftOutput, bool rightOutput, bool frontOutput, bool backOutput,
            string leftPrefix, string rightPrefix, string frontPrefix, string backPrefix, bool leftPrefixOnly, bool rightPrefixOnly, bool frontPrefixOnly, bool backPrefixOnly)
        {
            int length = Math.Max(1, Math.Max(leftIO, rightIO));
            int width = Math.Max(1, Math.Max(frontIO, backIO));
            var builder = PrefabBuilder.Custom(() => createObject(width, length));
            generatePegs(builder, new Vector3(1, 0, 0), leftPrefix, leftPrefixOnly, 0, baseSize / 2, -baseSize, (leftIO - length) * baseSize, leftIO, false, leftOutput);
            generatePegs(builder, new Vector3(-1, 0, 0), rightPrefix, rightPrefixOnly, 0, -width * baseSize + (baseSize / 2), -baseSize, (rightIO - length) * baseSize, rightIO, true, rightOutput);
            generatePegs(builder, new Vector3(0, 0, -1), frontPrefix, frontPrefixOnly, -baseSize, (frontIO - width) * baseSize, 0, -length * baseSize + (baseSize / 2), frontIO, true, frontOutput);
            generatePegs(builder, new Vector3(0, 0, 1), backPrefix, backPrefixOnly, -baseSize, (backIO - width) * baseSize, 0, baseSize / 2, backIO, true, backOutput);
            return builder;
        }

        private static void generatePegs(CustomBuilder builder, Vector3 facing, string namePrefix, bool prefixOnly, float xMultiplier, float xConstant, float zMultiplier, float zConstant, int pinCount, bool reversed, bool output)
        {
            var rotation = Quaternion.FromToRotation(new Vector3(0, 1, 0), facing);
            int start = reversed ? pinCount - 1 : 0;
            int end = reversed ? -1 : pinCount;
            int step = reversed ? -1 : 1;
            for (int i = start; i != end; i += step)
            {
                var pos = new Vector3(xMultiplier * i + xConstant, 0.15f, zMultiplier * i + zConstant);
                var name = prefixOnly ? namePrefix : namePrefix + (reversed ? (pinCount - i - 1) : i).ToString();
                if (output)
                {
                    builder.WithOutput(pos, rotation, name);
                } else
                {
                    builder.WithInput(pos, rotation, name);
                }
            }
        }
        private static GameObject createObject(int w, int l)
        {

            var obj = new GameObject();
            obj.SetActive(true);
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.parent = obj.transform;
            cube.transform.localScale = new Vector3(baseSize * w, baseSize, baseSize * l);
            cube.transform.localPosition = new Vector3(-baseSize * (w - 1)/2, 0.15f, -baseSize * (l - 1)/2);
            return obj;
        }
    }
}
