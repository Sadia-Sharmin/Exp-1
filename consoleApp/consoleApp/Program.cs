using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string age = "";
            string address = "";
            string contact= "";
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter age:");
            age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter address :");
            address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter contact:");
            contact = Console.ReadLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
