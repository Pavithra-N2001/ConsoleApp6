using System;
public class Areas
{
    public double Area(int l, int b)
    {
        return l * b;
    }
    public double Area(double b, double h)
    {
        double a = 0.5 * b * h;
        return a;
    }
    public double Area(int s)
    {

        return s * s;
    }
    public double Area(double r)
    {

        return 3.14 * r * r;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Areas s = new Areas();
        Console.WriteLine("Enter length of rectangle");
        int len = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter breadth of rectangle");
        int br = Convert.ToInt32(Console.ReadLine());

        //Area of rectangle
        double rec = s.Area(len, br);
        Console.WriteLine("Area of Rectangle : " + rec);

        Console.WriteLine("Enter side of the square");
        int a = Convert.ToInt32(Console.ReadLine());

        //Area of square
        double sq = s.Area(a);
        Console.WriteLine("Area of square : " + sq);



        Console.WriteLine("Enter base of Traingle");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height of Traingle");
        double h = Convert.ToDouble(Console.ReadLine());

        //Area of triangle
        double tri = s.Area(b, h);
        Console.WriteLine("Area of Triangle : " + tri);

        Console.WriteLine("Enter radius of the circle");
        double radius = Convert.ToDouble(Console.ReadLine());

        //Area of Circle
        double cir = s.Area(radius);
        Console.WriteLine("Area of circle : " + cir);

    }
       
}