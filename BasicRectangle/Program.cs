using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRectangle
{
    class Rectangle
    {
        private double length { get; set; }
        private double width { get; set; }
        private double area { get; set; }

        public Rectangle()
        {
            length = 0;
            width = 0;
            area = getArea(0, 0);
        }

        public Rectangle(double inputLength, double inputWidth)
        {
            length = inputLength;
            width = inputWidth;
            area = getArea(inputLength, inputWidth);
        }

        private double getArea(double inputLength, double inputWidth)
        {
            area = inputLength * inputWidth;
            printInfo(inputLength, inputWidth, area);
            return area;
        }

        public static void printInfo(double inputLength, double inputWidth, double area)
        {
            string rectangleDimensions = "Rectangle length: " + inputLength + "\nRectangle width: " + inputWidth + "\nRectangle area: " + area;
            Console.WriteLine(rectangleDimensions);
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(100.5, 25);
            Console.ReadKey();
        }
    }
}
