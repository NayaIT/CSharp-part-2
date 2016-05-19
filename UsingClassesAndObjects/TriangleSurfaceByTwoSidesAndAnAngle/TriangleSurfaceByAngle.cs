/* 06. Triangle surface by two sides and an angle
Description
Write program that calculates the surface of a triangle by given two sides and an angle between them.

Input
On the first line you will receive the length of the first side of the triangle
On the second line you will receive the length of the second side of the triangle
On the third line you will receive the angle between the given sides
Angle is given in degrees

Output
Print the surface of the rectangle with two digits of precision

Constraints
Input data describes a valid triangle
 */

using System;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class TriangleSurfaceByAngle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = Math.PI / 180 * double.Parse(Console.ReadLine());

            var surface = (a * b * Math.Sin(angle)) / 2;

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
