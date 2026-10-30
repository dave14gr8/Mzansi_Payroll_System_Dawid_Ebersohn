namespace MzansiPayrollSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblNumberOf = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtNumberOf = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblPayDeduction = new System.Windows.Forms.Label();
            this.lblUif = new System.Windows.Forms.Label();
            this.lblMembershipFee = new System.Windows.Forms.Label();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtPayDeduction = new System.Windows.Forms.TextBox();
            this.txtUifDeduction = new System.Windows.Forms.TextBox();
            this.txtMembershipFee = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Black;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeading.Location = new System.Drawing.Point(112, 34);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(480, 50);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Mzansi Tech Contractors";
            // 
            // lblContractorName
            // 
            this.lblContractorName.AutoSize = true;
            this.lblContractorName.BackColor = System.Drawing.Color.Black;
            this.lblContractorName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContractorName.Location = new System.Drawing.Point(33, 184);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(191, 27);
            this.lblContractorName.TabIndex = 1;
            this.lblContractorName.Text = "Contractor Name:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.BackColor = System.Drawing.Color.Black;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHoursWorked.Location = new System.Drawing.Point(33, 243);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(164, 27);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblNumberOf
            // 
            this.lblNumberOf.AutoSize = true;
            this.lblNumberOf.BackColor = System.Drawing.Color.Black;
            this.lblNumberOf.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumberOf.Location = new System.Drawing.Point(33, 305);
            this.lblNumberOf.Name = "lblNumberOf";
            this.lblNumberOf.Size = new System.Drawing.Size(256, 27);
            this.lblNumberOf.TabIndex = 3;
            this.lblNumberOf.Text = "Number of Dependents:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(325, 181);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 28);
            this.txtName.TabIndex = 4;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(325, 240);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(251, 28);
            this.txtHours.TabIndex = 5;
            // 
            // txtNumberOf
            // 
            this.txtNumberOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOf.Location = new System.Drawing.Point(325, 302);
            this.txtNumberOf.Name = "txtNumberOf";
            this.txtNumberOf.Size = new System.Drawing.Size(251, 28);
            this.txtNumberOf.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(65, 384);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(184, 44);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Net Pay";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(291, 384);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 44);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(433, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.BackColor = System.Drawing.Color.Black;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGrossPay.Location = new System.Drawing.Point(659, 219);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(119, 25);
            this.lblGrossPay.TabIndex = 10;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblPayDeduction
            // 
            this.lblPayDeduction.AutoSize = true;
            this.lblPayDeduction.BackColor = System.Drawing.Color.Black;
            this.lblPayDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDeduction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPayDeduction.Location = new System.Drawing.Point(659, 285);
            this.lblPayDeduction.Name = "lblPayDeduction";
            this.lblPayDeduction.Size = new System.Drawing.Size(159, 25);
            this.lblPayDeduction.TabIndex = 11;
            this.lblPayDeduction.Text = "Pay Deduction:";
            // 
            // lblUif
            // 
            this.lblUif.AutoSize = true;
            this.lblUif.BackColor = System.Drawing.Color.Black;
            this.lblUif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUif.Location = new System.Drawing.Point(659, 355);
            this.lblUif.Name = "lblUif";
            this.lblUif.Size = new System.Drawing.Size(156, 25);
            this.lblUif.TabIndex = 12;
            this.lblUif.Text = "UIF Deduction:";
            // 
            // lblMembershipFee
            // 
            this.lblMembershipFee.AutoSize = true;
            this.lblMembershipFee.BackColor = System.Drawing.Color.Black;
            this.lblMembershipFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipFee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMembershipFee.Location = new System.Drawing.Point(659, 427);
            this.lblMembershipFee.Name = "lblMembershipFee";
            this.lblMembershipFee.Size = new System.Drawing.Size(180, 25);
            this.lblMembershipFee.TabIndex = 13;
            this.lblMembershipFee.Text = "Membership Fee:";
            // 
            // lblTotalDeductions
            // 
            this.lblTotalDeductions.AutoSize = true;
            this.lblTotalDeductions.BackColor = System.Drawing.Color.Black;
            this.lblTotalDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeductions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalDeductions.Location = new System.Drawing.Point(659, 503);
            this.lblTotalDeductions.Name = "lblTotalDeductions";
            this.lblTotalDeductions.Size = new System.Drawing.Size(182, 25);
            this.lblTotalDeductions.TabIndex = 14;
            this.lblTotalDeductions.Text = "Total Deductions:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.BackColor = System.Drawing.Color.Black;
            this.lblNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNetPay.Location = new System.Drawing.Point(659, 577);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(95, 25);
            this.lblNetPay.TabIndex = 15;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(905, 221);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(272, 28);
            this.txtGrossPay.TabIndex = 16;
            // 
            // txtPayDeduction
            // 
            this.txtPayDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayDeduction.Location = new System.Drawing.Point(905, 290);
            this.txtPayDeduction.Name = "txtPayDeduction";
            this.txtPayDeduction.ReadOnly = true;
            this.txtPayDeduction.Size = new System.Drawing.Size(272, 28);
            this.txtPayDeduction.TabIndex = 17;
            // 
            // txtUifDeduction
            // 
            this.txtUifDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUifDeduction.Location = new System.Drawing.Point(905, 360);
            this.txtUifDeduction.Name = "txtUifDeduction";
            this.txtUifDeduction.ReadOnly = true;
            this.txtUifDeduction.Size = new System.Drawing.Size(272, 28);
            this.txtUifDeduction.TabIndex = 18;
            // 
            // txtMembershipFee
            // 
            this.txtMembershipFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembershipFee.Location = new System.Drawing.Point(905, 432);
            this.txtMembershipFee.Name = "txtMembershipFee";
            this.txtMembershipFee.ReadOnly = true;
            this.txtMembershipFee.Size = new System.Drawing.Size(272, 28);
            this.txtMembershipFee.TabIndex = 19;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(905, 508);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(272, 28);
            this.txtTotal.TabIndex = 20;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.Location = new System.Drawing.Point(905, 577);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(272, 28);
            this.txtNetPay.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 656);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtMembershipFee);
            this.Controls.Add(this.txtUifDeduction);
            this.Controls.Add(this.txtPayDeduction);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblTotalDeductions);
            this.Controls.Add(this.lblMembershipFee);
            this.Controls.Add(this.lblUif);
            this.Controls.Add(this.lblPayDeduction);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumberOf);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumberOf);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblContractorName);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mzansi Tech Contractors Payroll System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblNumberOf;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtNumberOf;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblPayDeduction;
        private System.Windows.Forms.Label lblUif;
        private System.Windows.Forms.Label lblMembershipFee;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtPayDeduction;
        private System.Windows.Forms.TextBox txtUifDeduction;
        private System.Windows.Forms.TextBox txtMembershipFee;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNetPay;
    }
}

