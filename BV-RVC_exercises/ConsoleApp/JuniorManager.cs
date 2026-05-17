using System;

namespace Company.Payroll
{
    public class JuniorManager : Manager
    {
        // Hours actually worked this month
        public int HoursWorked { get; }

        public JuniorManager(string name, decimal baseSalary, decimal monthlyBonus, int hoursWorked)
            : base(name, baseSalary, monthlyBonus)
        {
            if (hoursWorked < 0) throw new ArgumentOutOfRangeException(nameof(hoursWorked));
            HoursWorked = hoursWorked;
        }

        // Bonus paid if worked at least 180 hours this month
        public override bool IsBonusPaid() => HoursWorked >= 180;
    }
}