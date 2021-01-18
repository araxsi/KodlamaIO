using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Room { Bathroom, Bedroom, Hall };

namespace Homework_Day2_Swith
{
    class Program
    {
        static void Main(string[] args)
        {
            Room c = (Room)(new Random()).Next(0, 3);
            switch (c)
            {
                case Room.Bathroom:
                    Console.WriteLine("The room is Bathroom");
                    break;
                case Room.Bedroom:
                    Console.WriteLine("The room is Bedroom");
                    break;
                case Room.Hall:
                    Console.WriteLine("The room is Hall");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }


        }
    }
}
