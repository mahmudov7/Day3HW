public static class Shape
{
    const double PI=3.14;
    public static void CalcCircleArea(double a)
    {
        System.Console.WriteLine(PI*a*a);
    }
    public static void CalcCirclePerimeter(double radius)
    {
        System.Console.WriteLine(2*PI*radius);
    }
    public static void CalcRectangleArea(double length, double width)
    {
        System.Console.WriteLine(length*width);
    }
    public static void CalcRectanglePerimetr(double length, double width)
    {
        System.Console.WriteLine(2*(length+width));
    }
    public static void CalcTriangleArea(double bese, double height)
    {
        System.Console.WriteLine(0.5*bese*height);
    }
    public static void CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        System.Console.WriteLine(side1+side2+side3);
    }
    
}