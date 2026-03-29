using System;

public class Point
{
    public int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public virtual void getCoordinate()
    {
        Console.WriteLine($"{x}:{y}");
    }
} 

public class Point3D: Point
{
    public int z;
    public Point3D(int x, int y, int z) : base(x, y)
    {
        this.z = z;
    }
    public override void getCoordinate()
    {
        Console.WriteLine($"{x}:{y}:{z}");
    }
}

class HelloWorld {
    static void Main() {
        Point a = new Point(10, 20);
        Point b = new Point3D(10, 20, 30);
        a.getCoordinate();
        b.getCoordinate();
    }
}