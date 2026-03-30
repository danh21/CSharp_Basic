class Program
{
    // 1. VALUE param — copy, original unchanged
    static void ValueParam(int x)
    {
        x = 99;
    }

    // 2. REF param — pass by reference, must be initialized
    static void RefParam(ref int x)
    {
        x = 99;
    }

    // 3. OUT param — must be assigned inside, no need to initialize
    static void OutParam(out int x)
    {
        x = 99;
    }

    // 4. PARAMS — variable number of args
    static int Sum(params int[] nums)
    {
        int total = 0;
        foreach (var n in nums) total += n;
        return total;
    }

    // 5. OPTIONAL param — has default value
    static void Greet(string name, string greeting = "Hello")
    {
        Console.WriteLine($"{greeting}, {name}!");
    }

    // 6. NAMED param — pass by name, order doesn't matter
    static void Order(string first, string second, string third)
    {
        Console.WriteLine($"{first}, {second}, {third}");
    }

    // 7. IN param — pass by reference but READ-ONLY, cannot modify
    static void InParam(in int x)
    {
        // x = 99; // ← compile error: cannot assign to 'in' param
        Console.WriteLine($"In:       x = {x}");
    }

    static void Main()
    {
        // 1. VALUE
        int a = 1;
        ValueParam(a);
        Console.WriteLine($"Value:    a = {a}");       // a = 1 (unchanged)

        // 2. REF
        int b = 1;
        RefParam(ref b);
        Console.WriteLine($"Ref:      b = {b}");       // b = 99 (changed)

        // 3. OUT
        OutParam(out int c);
        Console.WriteLine($"Out:      c = {c}");       // c = 99

        // 4. PARAMS
        Console.WriteLine($"Params:   {Sum(1, 2, 3, 4, 5)}");   // 15

        // 5. OPTIONAL
        Greet("Alice");                // Hello, Alice!
        Greet("Bob", "Hi");            // Hi, Bob!

        // 6. NAMED
        Order(third: "C", first: "A", second: "B");    // A, B, C

        // 7. IN
        int d = 42;
        InParam(in d);                                  // d = 42 (read-only, never changed)
        Console.WriteLine($"After In: d = {d}");        // d = 42 (unchanged)
    }
}