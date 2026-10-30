using System;

namespace MzansiPayrollSystem
{
    public class PayrollCalculator
    {
        private const decimal HourlyRate = 950m;

        public decimal CalculateGrossPay(decimal hours)
        {
            return hours * HourlyRate;
        }

        public decimal CalculateUIF(decimal grossPay)
        {
            return grossPay * 0.01m;
        }

        public decimal CalculateMembershipFee(decimal grossPay)
        {
            return grossPay * 0.13m;
        }

        public decimal CalculatePAYE(decimal grossPay, int dependents)
        {
            decimal taxable = grossPay - (grossPay * 0.0575m * dependents);
            return taxable * 0.25m;
        }

        public decimal CalculateTotalDeductions(decimal uif, decimal paye, decimal membership)
        {
            return uif + paye + membership;
        }

        public decimal CalculateNetPay(decimal grossPay, decimal totalDeductions)
        {
            return grossPay - totalDeductions;
        }
    }
}

