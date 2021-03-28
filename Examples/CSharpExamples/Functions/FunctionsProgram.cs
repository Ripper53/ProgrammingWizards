using System;

namespace CSharpExamples {
    class Program {
        static void Main(string[] args) {
            float[] x = new float[] {
                2f, 4f
            };
            Console.WriteLine("Add(x1, x2) => " + Add(x[0], x[1]));
            Console.WriteLine("Add(x[]) => " + Add(x));
            Console.WriteLine("AddBelowFive(x[]) => " + AddBelowFive(x));

            Func<float, float, float> add2 = Add;
            Console.WriteLine("add2: " + add2(x[0], x[1]));
        }

        static float Add(float x1, float x2) {
            return x1 + x2;
        }

        static float Add(float[] x) {
            float value = 0f;
            foreach (float v in x) {
                value += v;
            }
            return value;
        }

        static float AddBelowFive(float[] x) {
            float value = 0f;
            foreach (float v in x) {
                value += v;
                if (value > 5f) {
                    return -1;
                }
            }
            return value;
        }

    }
}
