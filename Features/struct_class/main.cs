using System;

// STRUCT — value type, copied by value
struct PointStruct
{
    public int x, y;
    public PointStruct(int x, int y) { this.x = x; this.y = y; }
}

// CLASS — reference type, copied by reference
class PointClass
{
    public int x, y;
    public PointClass(int x, int y) { this.x = x; this.y = y; }
}

class Program
{
    static void Main()
    {
        // STRUCT
        PointStruct a = new PointStruct(10, 10);
        PointStruct b = a;   // b is a COPY of a
        a.x = 20;
        Console.WriteLine($"Struct b.x = {b.x}");  // 10 — b is unaffected

        Console.WriteLine("---");

        // CLASS
        PointClass c = new PointClass(10, 10);
        PointClass d = c;    // d points to SAME object as c
        c.x = 20;
        Console.WriteLine($"Class  d.x = {d.x}");  // 20 — d is affected
    }
}