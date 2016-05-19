/* 04. Triangle surface by side and altitude
Description
Write program that calculates the surface of a triangle by given a side and an altitude to it.

Input
On the first line you will receive the length of a side of the triangle
On the second line you will receive the altitude to that side

Output
Print the surface of the rectangle with two digits of precision

Constraints
Input data describes a valid triangle
 */

using System;

namespace TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceByAltitude
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            var surface = (side * altitude) / 2;

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
