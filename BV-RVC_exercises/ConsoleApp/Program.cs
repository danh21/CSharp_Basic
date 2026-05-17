using Company.Payroll;
using School;
using String_;

class Program
{
    static void Main()
    {
        var employees = new Employee[]
        {
            new JuniorManager("Bob", baseSalary: 3000m, monthlyBonus: 500m, hoursWorked: 185),
            new Worker("Alice", hoursPerMonth: 160, ratePerHour: 15.50m),
            new SeniorManager("Carol", baseSalary: 6000m, monthlyBonus: 1500m, performanceEvaluation: 5.8m),
            new SeniorManager("Bakik", baseSalary: 6000m, monthlyBonus: 500m, performanceEvaluation: 5.0m),
        };

        Console.WriteLine("\nEmployees sorted by gross salary (desc):");
        foreach (var employee in EmployeeQueries.salaryDescendSort(employees)) 
            Console.WriteLine(employee);

        Console.WriteLine("\nLargest gross salary: ");
        foreach (var employee in EmployeeQueries.maxSalary(employees))
            Console.WriteLine(employee);



        var students = new[]
        {
            new Student("Alice", "Smith", 17),
            new Student("Bob", "Jones", 18),
            new Student("Carol", "White", 22),
            new Student("Dave", "Brown", 24),
            new Student("Eve", "Black", 25)
        };

        Console.WriteLine("\nStudents aged 18..24:");
        foreach (var student in StudentQueries.GetNamesAge18To24(students))
            Console.WriteLine(student);



        string str = "THIS is A very STRANGE string, heLLO MY1 N@ME IS_  DANH.";
        Console.WriteLine("\nUppercase words:");
        foreach (var w in StringQueries.GetUppercaseWords(str))
            Console.WriteLine(w);
    }
}