using System;

namespace Company.Payroll
{
    public class SeniorManager : Manager
    {
        // Performance evaluation score for the month (e.g. 0..10)
        public decimal PerformanceEvaluation { get; }

        public SeniorManager(string name, decimal baseSalary, decimal monthlyBonus, decimal performanceEvaluation)
            : base(name, baseSalary, monthlyBonus)
        {
            if (performanceEvaluation < 0m) throw new ArgumentOutOfRangeException(nameof(performanceEvaluation));
            PerformanceEvaluation = performanceEvaluation;
        }

        // Bonus paid if performance evaluation is at least 6
        public override bool IsBonusPaid() => PerformanceEvaluation >= 6m;
    }
}