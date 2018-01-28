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

        public override string ToString()
        {
            string CircleInfo = "diameter= " + diameter + ", area = " + area +  ", circiumference = " + circumference; 
            return CircleInfo;
        }
    }


    class Rectangle
    {
        public double width, height, area, perimeter;

        public Rectangle()
        {
            width = 1;
            height = 1;
        }

       

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

        public override string ToString()
        {
            string RectangleInfo = "width = " + width + ", height = " + height + ", area = " + area + ", perimeter = " + perimeter;
            return RectangleInfo;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.getHeight();
            r.getWidth();
            r.getArea();
            r.getPerimeter();

            Console.WriteLine("Rectangle");

            Console.WriteLine(r);


            Circle c = new Circle();

            c.getRadius();
            c.getDiameter();
            c.getArea();
            c.getCircumference();

            Console.WriteLine("Circle");

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
