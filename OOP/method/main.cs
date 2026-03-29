using System;

class Entity
{
    static int nextSerialNo;
    int serialNo;

    // constructor
    public Entity()
    {
        serialNo = nextSerialNo++;
    } 

    // instance method
    public int GetSerialNo()
    {
        return serialNo;
    } 

    /* static methods */
    public static int GetNextSerialNo()
    {
        return nextSerialNo;
    } 
    public static void SetNextSerialNo(int value)
    {
        nextSerialNo = value;
    }
}

class HelloWorld {
    public static void Main()
    {
        Entity.SetNextSerialNo(1000);
        Entity e1 = new Entity();
        Entity e2 = new Entity();
        Console.WriteLine(e1.GetSerialNo()); // Outputs "1000"
        Console.WriteLine(e2.GetSerialNo()); // Outputs "1001"
        Console.WriteLine(Entity.GetNextSerialNo()); // Outputs "1002"
    }
}