using System;

namespace Company.Payroll
{
    public abstract class Manager : Employee
    {
        public decimal BaseSalary { get; }
        public decimal MonthlyBonus { get; }

        protected Manager(string name, decimal baseSalary, decimal monthlyBonus)
            : base(name)
        {
            if (baseSalary < 0m) throw new ArgumentOutOfRangeException(nameof(baseSalary));
            if (monthlyBonus < 0m) throw new ArgumentOutOfRangeException(nameof(monthlyBonus));

            BaseSalary = baseSalary;
            MonthlyBonus = monthlyBonus;
        }

        public override decimal FixedAmount => BaseSalary;

        public override decimal BonusAmount => MonthlyBonus;

        // Concrete managers must implement bonus condition
        public abstract override bool IsBonusPaid();
    }
}