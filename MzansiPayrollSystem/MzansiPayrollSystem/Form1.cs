using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MzansiPayrollSystem
{
    public partial class Form1 : Form
    {
        PayrollCalculator calculate = new PayrollCalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ----- Validation -----
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the contractor name.");
                txtName.Focus();
                return;
            }

            decimal hours;
            if (!decimal.TryParse(txtHours.Text, out hours))
            {
                MessageBox.Show("Hours worked must be a number.");
                txtHours.Focus();
                return;
            }

            if (hours < 0)
            {
                MessageBox.Show("Hours worked cannot be negative.");
                txtHours.Focus();
                return;
            }

            int dependents;
            if (!int.TryParse(txtNumberOf.Text, out dependents))
            {
                MessageBox.Show("Dependents must be a whole number.");
                txtNumberOf.Focus();
                return;
            }

            if (dependents < 0)
            {
                MessageBox.Show("Dependents cannot be negative.");
                txtNumberOf.Focus();
                return;
            }

            if (dependents > 10)
            {
                MessageBox.Show("Dependents cannot be more than 10.");
                txtNumberOf.Focus();
                return;
            }

            // ----- Calculations -----
            decimal gross = calculate.CalculateGrossPay(hours);
            decimal uif = calculate.CalculateUIF(gross);
            decimal paye = calculate.CalculatePAYE(gross, dependents);
            decimal membership = calculate.CalculateMembershipFee(gross);
            decimal totalDeductions = calculate.CalculateTotalDeductions(uif, paye, membership);
            decimal net = calculate.CalculateNetPay(gross, totalDeductions);

            // ----- Output -----
            txtGrossPay.Text = "R " + gross.ToString("N2");
            txtUifDeduction.Text = "R " + uif.ToString("N2");
            txtPayDeduction.Text = "R " + paye.ToString("N2");
            txtMembershipFee.Text = "R " + membership.ToString("N2");
            txtTotal.Text = "R " + totalDeductions.ToString("N2");
            txtNetPay.Text = "R " + net.ToString("N2");
            }

       private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtHours.Clear();
            txtNumberOf.Clear();
            txtGrossPay.Clear();
            txtUifDeduction.Clear();
            txtPayDeduction.Clear();
            txtMembershipFee.Clear();
            txtTotal.Clear();
            txtNetPay.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
