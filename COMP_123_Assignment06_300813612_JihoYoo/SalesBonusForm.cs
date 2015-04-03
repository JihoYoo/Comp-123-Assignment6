/*  
 *  Author's name:Jiho Yoo  
 *  Date : 4/03/2015  
 *  Program description : Sharp Mail Order - SALES BONUS
 *  Revision History :  
 *                    3/25/2015 design the form
 *                    3/27/2015 translation languages 
 *                    3/30/2015 set up calculate button
 *                    4/02/2015 using standard currency format to display in Total Monthly Sales text box
 *                    4/03/2015 find out some errors
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace COMP_123_Assignment06_300813612_JihoYoo
{
    public partial class SaleBonusForm : Form
    {
        
        

        public SaleBonusForm()
        {
            InitializeComponent();
        }

        // Translate to English
        private void English_CheckedChanged(object sender, EventArgs e)
        {

            ActiveForm.Text = Properties.Resources.SalesBonusActiveFormEnglish;

            English.Text = Properties.Resources.EnglishRadioButtonEnglish;

            French.Text = Properties.Resources.FrenchRadioButtonEnglish;

            Languages.Text = Properties.Resources.LanguagesGroupBoxEnglish;

            EmployeeName.Text = Properties.Resources.EmployeeNameLabelEnglish;

            EmployeeID.Text = Properties.Resources.EmployeeIDLabelEnglish;

            TotalHoursWorked.Text = Properties.Resources.TotalHoursWorkedLabelEnglish;

            TotalMonthlySales.Text = Properties.Resources.TotalMonthlySalesLabelEnglish;

            SalesBonus.Text = Properties.Resources.SalesBonusLabelEnglish;

            CalculateButton.Text = Properties.Resources.CalculateButtonEnglish;

            NextButton.Text = Properties.Resources.NextButtonEnglish;

            PrintButton.Text = Properties.Resources.PrintButtonEnglish;
        }

        // Translate to French
        private void French_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.SalesBonusActiveFormFrench;

            English.Text = Properties.Resources.EnglishRadioButtonFrench;

            French.Text = Properties.Resources.FrenchRadioButtonFrench;

            Languages.Text = Properties.Resources.LanguagesGroupBoxFrench;

            EmployeeName.Text = Properties.Resources.EmployeeNameLabelFrench;

            EmployeeID.Text = Properties.Resources.EmployeeIDLabelFrench;

            TotalHoursWorked.Text = Properties.Resources.TotalHoursWorkedLabelFrench;

            TotalMonthlySales.Text = Properties.Resources.TotalMonthlySalesLabelFrench;

            SalesBonus.Text = Properties.Resources.SalesBonusLabelFrench;

            CalculateButton.Text = Properties.Resources.CalculateButtonFrench;

            NextButton.Text = Properties.Resources.NextButtonFrench;

            PrintButton.Text = Properties.Resources.PrintButtonFrench;
        }

        // Clear the entered information
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";

            EmployeeIDTextBox.Text = "";

            TheHoursWorkedTextBox.Text = "";

            SalesBonusTextBox.Text = "";

            EmployeeNameTextBox.Enabled = true;

            EmployeeIDTextBox.Enabled = true;

            TheHoursWorkedTextBox.Enabled = true;

            SalesBonusTextBox.Enabled = true;
        }

        private void SalesBonusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void TotalMonthlySalesTextBox_TextChanged(object sender, EventArgs e)
        {
           
         
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // values of calculate button
            double totalHoursWorked;
            double percentageOfHoursWorked;
            double totalMonthlySales;
            double totalBonusAmount;
            double salesBonus;


            
           
           

            if ((EmployeeNameTextBox.Text != "") && (EmployeeIDTextBox.Text != "") && (TheHoursWorkedTextBox.Text != "") && (TotalMonthlySalesTextBox.Text != ""))
            {
               

                try
                {
                    //Convert each values to double
                    totalHoursWorked = Convert.ToDouble(TheHoursWorkedTextBox.Text);
                    totalMonthlySales = Convert.ToDouble(TotalMonthlySalesTextBox.Text);

                    

                    // Sales Bonus is calculated up to 160 of Total hours worked
                    if (totalHoursWorked <= 160 && totalHoursWorked >=0)
                    {
                        percentageOfHoursWorked = totalHoursWorked / 160;
                        totalBonusAmount = totalMonthlySales * 0.02;
                        salesBonus = percentageOfHoursWorked * totalBonusAmount;

                        TotalMonthlySalesTextBox.Text = totalMonthlySales.ToString("C2");// display a value using standard currency format

                        SalesBonusTextBox.Text = Convert.ToString(percentageOfHoursWorked); //Convert to string to show value in Sales Bonus Text Box.

                        // to shade fields 
                        EmployeeNameTextBox.Enabled = false;
                        EmployeeIDTextBox.Enabled = false;
                        TheHoursWorkedTextBox.Enabled = false;
                        TotalMonthlySalesTextBox.Enabled = false;

                    }
                        // error message
                    else
                        MessageBox.Show("Total Hours Worked field cannot exceed 160 hours and negative numbers!!!");
                    TheHoursWorkedTextBox.Focus();
                    TheHoursWorkedTextBox.SelectAll();
                   

                }
                    // if the hours worked filed is typed letter, the error message comes up
                catch (Exception error)
                {
                    MessageBox.Show("Total Hours Worked filed should be number!!!");
                    TheHoursWorkedTextBox.Focus();
                    TheHoursWorkedTextBox.SelectAll();
                    
                    
                }
            }
               
                
        }

        // Display a print the form
        private void PrintButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print(); 
                
        }
    }
}
