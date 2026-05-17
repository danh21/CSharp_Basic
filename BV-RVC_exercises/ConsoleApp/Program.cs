using Company.Payroll;
using School;
using String_;

class Program
{
    static void Main()
    {
        var worker = new Worker("Alice", hoursPerMonth: 160, ratePerHour: 15.50m);
        var junior = new JuniorManager("Bob", baseSalary: 3000m, monthlyBonus: 500m, hoursWorked: 185);
        var senior = new SeniorManager("Carol", baseSalary: 6000m, monthlyBonus: 1500m, performanceEvaluation: 5.8m);

        Console.WriteLine(worker); // Worker: Alice, Salary: ...
        Console.WriteLine(junior); // Bonus paid
        Console.WriteLine(senior); // Bonus not paid (performance < 6)



        var students = new[]
        {
            new Student("Alice", "Smith", 17),
            new Student("Bob", "Jones", 18),
            new Student("Carol", "White", 22),
            new Student("Dave", "Brown", 24),
            new Student("Eve", "Black", 25)
        };

        Console.WriteLine("Students aged 18..24:");
        foreach (var student in StudentQueries.GetNamesAge18To24(students))
            Console.WriteLine(student);

        string str = "THIS is A very STRANGE string, heLLO MY1 N@ME IS_  DANH.";
        Console.WriteLine("Uppercase words:");
        foreach (var w in StringQueries.GetUppercaseWords(str))
            Console.WriteLine(w);
    }
}