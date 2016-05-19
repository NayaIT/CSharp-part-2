/* 05. Triangle surface by three sides
Description
Write program that calculates the surface of a triangle by given its three sides.

Input
On the first line you will receive the length of the first side of the triangle
On the second line you will receive the length of the second side of the triangle
On the third line you will receive the length of the third side of the triangle

Output
Print the surface of the rectangle with two digits of precision

Constraints
Input data describes a valid triangle
 */
using System;

namespace TriangleSurfaceByThreeSides
{
    class TriangleSurface
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            var p = (a + b + c) / 2;
            var surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
