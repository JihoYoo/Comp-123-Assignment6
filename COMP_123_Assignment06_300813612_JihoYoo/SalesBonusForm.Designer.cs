namespace COMP_123_Assignment06_300813612_JihoYoo
{
    partial class SaleBonusForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleBonusForm));
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.TheHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SalesBonus = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.TotalHoursWorked = new System.Windows.Forms.Label();
            this.TotalMonthlySales = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.French = new System.Windows.Forms.RadioButton();
            this.English = new System.Windows.Forms.RadioButton();
            this.Languages = new System.Windows.Forms.GroupBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Languages.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(240, 304);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 21);
            this.SalesBonusTextBox.TabIndex = 15;
            this.SalesBonusTextBox.TextChanged += new System.EventHandler(this.SalesBonusTextBox_TextChanged);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(240, 197);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 21);
            this.EmployeeIDTextBox.TabIndex = 14;
            // 
            // TheHoursWorkedTextBox
            // 
            this.TheHoursWorkedTextBox.Location = new System.Drawing.Point(240, 235);
            this.TheHoursWorkedTextBox.Name = "TheHoursWorkedTextBox";
            this.TheHoursWorkedTextBox.Size = new System.Drawing.Size(100, 21);
            this.TheHoursWorkedTextBox.TabIndex = 13;
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(240, 266);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(100, 21);
            this.TotalMonthlySalesTextBox.TabIndex = 12;
            this.TotalMonthlySalesTextBox.TextChanged += new System.EventHandler(this.TotalMonthlySalesTextBox_TextChanged);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(240, 160);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.EmployeeNameTextBox.TabIndex = 11;
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(10, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(166, 112);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 16;
            this.PictureBox.TabStop = false;
            // 
            // SalesBonus
            // 
            this.SalesBonus.AutoSize = true;
            this.SalesBonus.Location = new System.Drawing.Point(21, 313);
            this.SalesBonus.Name = "SalesBonus";
            this.SalesBonus.Size = new System.Drawing.Size(81, 12);
            this.SalesBonus.TabIndex = 21;
            this.SalesBonus.Text = "Sales Bonus:";
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Location = new System.Drawing.Point(21, 206);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(81, 12);
            this.EmployeeID.TabIndex = 20;
            this.EmployeeID.Text = "Employee ID:";
            // 
            // TotalHoursWorked
            // 
            this.TotalHoursWorked.AutoSize = true;
            this.TotalHoursWorked.Location = new System.Drawing.Point(21, 244);
            this.TotalHoursWorked.Name = "TotalHoursWorked";
            this.TotalHoursWorked.Size = new System.Drawing.Size(119, 12);
            this.TotalHoursWorked.TabIndex = 19;
            this.TotalHoursWorked.Text = "Total Hours Worked:";
            // 
            // TotalMonthlySales
            // 
            this.TotalMonthlySales.AutoSize = true;
            this.TotalMonthlySales.Location = new System.Drawing.Point(21, 275);
            this.TotalMonthlySales.Name = "TotalMonthlySales";
            this.TotalMonthlySales.Size = new System.Drawing.Size(122, 12);
            this.TotalMonthlySales.TabIndex = 18;
            this.TotalMonthlySales.Text = "Total Monthly Sales:";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(21, 169);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(115, 12);
            this.EmployeeName.TabIndex = 17;
            this.EmployeeName.Text = "Employee\'s Name:";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(138, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(106, 23);
            this.NextButton.TabIndex = 24;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(264, 400);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(106, 23);
            this.PrintButton.TabIndex = 23;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(10, 400);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(106, 23);
            this.CalculateButton.TabIndex = 22;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // French
            // 
            this.French.AutoSize = true;
            this.French.Location = new System.Drawing.Point(56, 58);
            this.French.Name = "French";
            this.French.Size = new System.Drawing.Size(62, 16);
            this.French.TabIndex = 1;
            this.French.Text = "French";
            this.French.UseVisualStyleBackColor = true;
            this.French.CheckedChanged += new System.EventHandler(this.French_CheckedChanged);
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Checked = true;
            this.English.Location = new System.Drawing.Point(56, 36);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(65, 16);
            this.English.TabIndex = 0;
            this.English.TabStop = true;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.CheckedChanged += new System.EventHandler(this.English_CheckedChanged);
            // 
            // Languages
            // 
            this.Languages.Controls.Add(this.French);
            this.Languages.Controls.Add(this.English);
            this.Languages.Location = new System.Drawing.Point(184, 26);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(200, 100);
            this.Languages.TabIndex = 25;
            this.Languages.TabStop = false;
            this.Languages.Text = "Languages";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // SaleBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonus);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.TotalHoursWorked);
            this.Controls.Add(this.TotalMonthlySales);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.TheHoursWorkedTextBox);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Name = "SaleBonusForm";
            this.Text = "Sale Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Languages.ResumeLayout(false);
            this.Languages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox TheHoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label SalesBonus;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label TotalHoursWorked;
        private System.Windows.Forms.Label TotalMonthlySales;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.RadioButton French;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.GroupBox Languages;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

