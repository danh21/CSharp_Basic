using System;

namespace Company.Payroll
{
    public abstract class Employee
    {
        public string Name { get; }

        protected Employee(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        // Fixed part of the salary (monthly)
        public abstract decimal FixedAmount { get; }

        // Bonus part of the salary (monthly)
        public abstract decimal BonusAmount { get; }

        // Condition for whether the bonus is paid this month
        public abstract bool IsBonusPaid();

        // Total salary for the month
        public decimal GetSalary()
        {
            return FixedAmount + (IsBonusPaid() ? BonusAmount : 0m);
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name}, Salary: {GetSalary():C}";
        }
    }
}