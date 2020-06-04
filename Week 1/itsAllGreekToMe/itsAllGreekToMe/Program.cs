using System;

namespace itsAllGreekToMe
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Welcome, this program represents distance between 2 points and the angel" +
                "between them");

            Console.Write("\n");
            // get coordinates
            Console.Write("Enter the first x value:");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the first y value:");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second x value:");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second y value:");
            float y2 = float.Parse(Console.ReadLine());

            float deltaY = y2 - y1;
            float deltaX = x2 - x1;

            // calculate distance
            double distancePower2 = (double)deltaX * deltaX + deltaY * deltaY;
            float distance = (float)Math.Sqrt(distancePower2);

            // calculate angel
            float angel = (float)Math.Atan2(deltaY, deltaX);
            float radians = angel * 180 / (float)Math.PI;

            Console.WriteLine("Distance is: " + distance);
            Console.WriteLine("Angel is: " + radians);


        }
    }
}
