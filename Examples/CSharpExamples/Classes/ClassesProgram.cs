using System;

namespace CSharpExamples {
    class Program {
        static void Main(string[] args) {
            TestClass x1 = new TestClass();
            x1.Value = 1;

            TestClass x2 = x1;
            x2.Value = 2;
            
            Console.WriteLine("x1: " + x1.Value);
            Console.WriteLine("x2: " + x2.Value);
        }

        class TestClass {
            public int Value;
        }

    }
}
