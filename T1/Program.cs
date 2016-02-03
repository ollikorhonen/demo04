using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Floor = 3;
            Console.WriteLine("Hissi on kerroksessa: " + elevator.Floor);
            Console.ReadLine();
        }
    }
}
