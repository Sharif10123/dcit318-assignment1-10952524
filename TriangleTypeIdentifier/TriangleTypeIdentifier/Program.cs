using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the third side: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene");
        }
    }
}