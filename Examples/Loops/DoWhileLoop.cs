using System;

class DoWhileLoop {
    static void Main() {
        int i = 0;
        do {
            i += 1;
            Console.WriteLine("Loop #" + i);
        } while (i < 5);
    }
}
