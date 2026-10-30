
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MzansiPayrollSystem;

namespace PayrollTests
{
    [TestClass]
    public class PayrollTests
    {
        PayrollCalculator calculate = new PayrollCalculator();

        public TestContext TestContext { get; set; }
        //Unit Test
        [TestMethod]
        public void GrossPay_160Hours_Returns152000()
        {    //Act
            decimal actual = calculate.CalculateGrossPay(160);
            //Assert
            TestContext.WriteLine("Expected: R152000, Actual: " + actual);
            Assert.AreEqual(152000m, actual);
        }
        //Unit Test
        [TestMethod]
        public void UIF_Gross152000_Returns1520()
        {   //Arrange
            decimal grossPay = 152000m;
            //Act
            decimal actual = calculate.CalculateUIF(grossPay);
            //Assert
            TestContext.WriteLine("Expected: R1520, Actual: " + actual);
            Assert.AreEqual(1520m, actual);
        }
        //Unit Test
        [TestMethod]
        public void Membership_Gross152000_Returns19760()
        {   //Arrange
            decimal grossPay = 152000m;
            //Act
            decimal actual = calculate.CalculateMembershipFee(grossPay);
            //Assert
            TestContext.WriteLine("Expected: R19760, Actual: " + actual);
            Assert.AreEqual(19760m, actual);
        }
        //Unit Test
        [TestMethod]
        public void PAYE_Gross152000_2Dependents_Returns33630()
        {   //Arrange
            decimal grossPay = 152000m;
            int dependents = 2;
            //Act
            decimal actual = calculate.CalculatePAYE(grossPay, dependents);
            //Assert
            TestContext.WriteLine("Expected: R33630, Actual: " + actual);
            Assert.AreEqual(33630m, actual);
        }
        //Unit Test
        [TestMethod]
        public void NetPay_Gross152000_Deductions54910_Returns97090()
        {   //Arrange
            decimal grossPay = 152000m;
            decimal deductions = 54910m;
            //Act
            decimal actual = calculate.CalculateNetPay(grossPay, deductions);
            //Assert
            TestContext.WriteLine("Expected: R97090, Actual: " + actual);
            Assert.AreEqual(97090m, actual);
        }
        //Integration Test
        [TestMethod]
        public void FullCalculation_160Hours_2Dependents_ReturnsCorrectNetPay()
        {   //Act
            decimal grossPay = calculate.CalculateGrossPay(160);
            decimal uif = calculate.CalculateUIF(grossPay);
            decimal paye = calculate.CalculatePAYE(grossPay, 2);
            decimal membership = calculate.CalculateMembershipFee(grossPay);
            decimal total = calculate.CalculateTotalDeductions(uif, paye, membership);
            decimal net = calculate.CalculateNetPay(grossPay, total);
            //Assert
            TestContext.WriteLine("Total deductions: R" + total + ", Net pay: R" + net);
            Assert.AreEqual(54910m, total);
            Assert.AreEqual(97090m, net);
        }
        //Integration Test
        [TestMethod]
        public void FullCalculation_40Hours_0Dependents_Returns23180()
        {   //Act
            decimal grossPay = calculate.CalculateGrossPay(40);
            decimal uif = calculate.CalculateUIF(grossPay);
            decimal paye = calculate.CalculatePAYE(grossPay, 0);
            decimal membership = calculate.CalculateMembershipFee(grossPay);
            decimal total = calculate.CalculateTotalDeductions(uif, paye, membership);
            decimal net = calculate.CalculateNetPay(grossPay, total);
            //Assert
            TestContext.WriteLine("Total: R" + total + ", Net: R" + net);
            Assert.AreEqual(14820m, total);
            Assert.AreEqual(23180m, net);
        }
        //Integration Test
        [TestMethod]
        public void FullCalculation_100Hours_10Dependents_Returns71606_25()
        {   //Act
            decimal grossPay = calculate.CalculateGrossPay(100);
            decimal uif = calculate.CalculateUIF(grossPay);
            decimal paye = calculate.CalculatePAYE(grossPay, 10);
            decimal membership = calculate.CalculateMembershipFee(grossPay);
            decimal total = calculate.CalculateTotalDeductions(uif, paye, membership);
            decimal net = calculate.CalculateNetPay(grossPay, total);
            //Assert
            TestContext.WriteLine("Total: R" + total + ", Net: R" + net);
            Assert.AreEqual(23393.75m, total);
            Assert.AreEqual(71606.25m, net);
        }
        //Integration Test
        [TestMethod]
        public void NetPay_ShouldReturnR97090_WhenAllDeductionsAreApplied()
        {
            //Arrange
            decimal hours = 160;
            int dependents = 2;

            TestContext.WriteLine("Testing Net Pay calculation with all deductions.");

            //Act
            decimal grossPay = calculate.CalculateGrossPay(hours);
            decimal uif = calculate.CalculateUIF(grossPay);
            decimal paye = calculate.CalculatePAYE(grossPay, dependents);
            decimal membership = calculate.CalculateMembershipFee(grossPay);
            decimal totalDeductions = calculate.CalculateTotalDeductions(uif, paye, membership);
            decimal netPay = calculate.CalculateNetPay(grossPay, totalDeductions);

            TestContext.WriteLine("Gross Pay: R" + grossPay.ToString("F2"));
            TestContext.WriteLine("UIF: R" + uif.ToString("F2"));
            TestContext.WriteLine("PAYE: R" + paye.ToString("F2"));
            TestContext.WriteLine("Membership Fee: R" + membership.ToString("F2"));
            TestContext.WriteLine("Total Deductions: R" + totalDeductions.ToString("F2"));
            TestContext.WriteLine("Calculated Net Pay: R" + netPay.ToString("F2"));

            //Assert
            Assert.AreEqual(152000m, grossPay);
            Assert.AreEqual(1520m, uif);
            Assert.AreEqual(33630m, paye);
            Assert.AreEqual(19760m, membership);
            Assert.AreEqual(54910m, totalDeductions);
            Assert.AreEqual(97090m, netPay);

        }
    }
}