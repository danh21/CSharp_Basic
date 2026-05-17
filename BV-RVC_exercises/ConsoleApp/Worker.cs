using System;

namespace Company.Payroll
{
    public class Worker : Employee
    {
        public int HoursPerMonth { get; }
        public decimal RatePerHour { get; }

        public Worker(string name, int hoursPerMonth, decimal ratePerHour)
            : base(name)
        {
            if (hoursPerMonth < 0) throw new ArgumentOutOfRangeException(nameof(hoursPerMonth));
            if (ratePerHour < 0m) throw new ArgumentOutOfRangeException(nameof(ratePerHour));

            HoursPerMonth = hoursPerMonth;
            RatePerHour = ratePerHour;
        }

        public override decimal FixedAmount => HoursPerMonth * RatePerHour;

        public override decimal BonusAmount => 0m;

        public override bool IsBonusPaid() => false;
    }
}