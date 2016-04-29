using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter.Hello();
            Console.WriteLine("Hej Codesion & Bitbucket !");
            Console.WriteLine("and goodbye !");
            Console.WriteLine("FriiiiiiiDaaaaaaaaaY Yeeeeeh");
        }

    }

    static class Greeter
    {
        public static void Hello()
        {
            Console.WriteLine("Hej alla glada fredagskodare !");
        }

        public static void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }

    
}
