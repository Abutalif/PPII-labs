using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Circle
    {
        public double radius, area, diameter, circumference;
        
        public void getRadius()
        {
            radius = double.Parse(Console.ReadLine());
        }

        public void getDiameter ()
        {
            diameter = 2 * radius;
        }

        public void getArea()
        {
            area = radius * radius * Math.PI;
        }

        public void getCircumference()
        {
            circumference = diameter*Math.PI;
        }
    }


    class Rectangle
    {
        double width, height, area, perimeter;

        public void getWidth()
        {
            width = double.Parse(Console.ReadLine());
        }

        public void getHeight()
        {
            height = double.Parse(Console.ReadLine());
        }

        public void getArea()
        {
            area = height*width;
        }

        public void getPerimeter()
        {
            perimeter = 2 * (height + width);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
