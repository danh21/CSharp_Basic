using System;
using Company.Payroll;

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
    }
}