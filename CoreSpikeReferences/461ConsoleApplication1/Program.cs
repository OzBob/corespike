using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreClassLibrary.IGreetingService g = new CoreClassLibrary.GreetingService();
            Console.WriteLine(g.Iam("groot"));

            Console.WriteLine("press ENTER to end");
            Console.ReadLine();
        }
    }
}
