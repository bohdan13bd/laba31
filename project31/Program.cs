using System;
using System.Collections.Generic;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private List<Point> points = new List<Point>();

    public Figure(Point point1, Point point2, Point point3)
    {
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
        points.Add(point4);
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
        points.Add(point4);
        points.Add(point5);
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Count; i++)
        {
            int nextIndex = (i + 1) % points.Count;
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(3, 0, "B");
        Point C = new Point(3, 4, "C");

        Figure triangle = new Figure(A, B, C);
        triangle.CalculatePerimeter();
    }
}
