using System;

namespace Esse {
    class Program {
        static void Main(string[] args) {
            CowardBeing being = new CowardBeing(new DateTime());
            
            Console.WriteLine(being.Name);
        }
    }
}
