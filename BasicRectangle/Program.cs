using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRectangle
{
    public class Rectangle
    {
        private double length;
        private double width;
        private double area;

        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
 
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid width. Please use only positive values.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        //public double getArea()
        //{
        //    this.area = Length * Width;
        //    printInfo();
        //    return area;
        //}

        //public void printInfo()
        //{
        //    string rectangleDimensions = "Rectangle length: " + this.length + "\nRectangle width: " + this.width + "\nRectangle area: " + this.area;
        //    Console.WriteLine(rectangleDimensions);
        //}
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Rectangle r2 = new Rectangle();
            r2.Length = 100;
            r2.Width = 0;
       
            Console.WriteLine("r2 length: {0}", r2.Length);
            Console.WriteLine("**********");
        }
    }
}
