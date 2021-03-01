//Name: Devanshi Patel
//Student ID: 100805084
//Course: Net Development
//Date: 22 January, 2021
//Modified Date: 28 Februray, 2021
//Description: This application will calculate the average unit shipped of the 7 days. 
// It will validate the user input and only allows input which are numeric and is in the 
// range between 0 to 5000.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShipped
{
    public partial class formAverageUnitsShipped : Form
    {
        // Declarations
        // Constants
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        // Current Day 
        int dayOfUnitShipped = 1;
        // Current Employee
        int currentEmployee = 1;
        // Variable
        double overallTotal = 0;
        
        // Arrays
        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;
        

        public formAverageUnitsShipped()
        {
            InitializeComponent();

            // Initialization of an arrays
            employeeTextBoxes = new TextBox[] { textBoxEmployee1Entries, textBoxEmployee2Entries, textBoxEmployee3Entries };
            employeeAverages = new Label[] { labelEmployee1Average, labelEmployee2Average, labelEmployee3Average };
        }

        private void formAverageUnitsShipped_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// on pressing enter button, it will calculate the average
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declarations
            // Declare constant for the minimum units
            const int MinimumUnits = 0;
            // Declare constant for the maximum units
            const int MaximumUnits = 5000;
            

            // it will take the valid entry to the entry box
            if (int.TryParse(textBoxUnitsInput.Text, out entryArray[currentEmployee - 1, dayOfUnitShipped - 1]))
            {
                // It checks whether the value is in range or not
                if (entryArray[currentEmployee - 1, dayOfUnitShipped - 1] >= MinimumUnits
                    && entryArray[currentEmployee - 1, dayOfUnitShipped - 1] <= MaximumUnits)
                { 
                    // It will assign valid values to the employee1
                    if (currentEmployee == 1)
                    {
                        // Change employee 1 font into bold
                        labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Bold);
                        
                        // it will add entry to the entry box
                        textBoxEmployee1Entries.Text += entryArray[currentEmployee - 1, dayOfUnitShipped - 1] + "\r\n";
                        textBoxUnitsInput.Clear();
                        
                    }

                    // It will assign valid values to employee2
                    else if (currentEmployee == 2)
                    {
                        // Change the font
                        labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Bold);

                        // it will add entry to the entry box
                        textBoxEmployee2Entries.Text += entryArray[currentEmployee - 1, dayOfUnitShipped - 1] + "\r\n";
                        textBoxUnitsInput.Clear();
                        
                    }

                    // It will assign valid values to employee3
                    else if (currentEmployee == 3)
                    {
                        // Change the font
                        labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Regular);
                        labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Bold);

                        // it will add entry to the entry box
                        textBoxEmployee3Entries.Text += entryArray[currentEmployee - 1, dayOfUnitShipped - 1] + "\r\n";
                        textBoxUnitsInput.Clear();
                      
                    }
                    

                    // If the current day is greater than or equals to 7, it will calculate average 
                    if (dayOfUnitShipped++ >= NumberOfDays)
                    {
                        // Local variable
                        int employeeTotal = 0;

                        // It will add all the valid values
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee - 1, day];
                        }

                        // Calculate average for employee1
                        if (currentEmployee == 1)
                        {
                            labelEmployee1Average.Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2).ToString("#0.00");
                            textBoxEmployee1Entries.Enabled = false;
                        }

                        // Calculate average for employee2
                        else if (currentEmployee == 2)
                        {
                            labelEmployee2Average.Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2).ToString("#0.00");
                            textBoxEmployee2Entries.Enabled = false;
                        }

                        // Calculate average for employee3
                        else if (currentEmployee == 3)
                        {
                            labelEmployee3Average.Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2).ToString("#0.00");
                            textBoxEmployee3Entries.Enabled = false;
                        }

                        // Set current day = 1
                        dayOfUnitShipped = 1;
                        // Add the employee
                        currentEmployee++;
                        
                    }

                    // If current employee is greater than 3, it will calculate overall average
                    if (currentEmployee > NumberOfEmployees)
                    {
                        dayOfUnitShipped = 1;
                        currentEmployee = 0;

                        // Change the font
                        labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Regular);
                        
                        // Local variable
                        double averageUnits = 0;

                        // It will take all the values
                        for (int i = 0; i < NumberOfEmployees; i++)
                        {
                            for (int j = 0; j < NumberOfDays; j++)
                            {
                                // Add all the valid values
                                overallTotal += entryArray[i, j];
                                // Overall Average
                                averageUnits = (double) overallTotal / entryArray.Length;
                            }

                        }

                        // it will display the text in the label
                        labelOverallAverage.Text = "Average per Employee: " + Math.Round((double)averageUnits, 2).ToString("#0.00");

                        // it disabled the entry box after the minimum entries
                        textBoxUnitsInput.Enabled = false;

                        // the enter button also gets disabled
                        buttonEnter.Enabled = false;

                        // it will set the focus on the reset button
                        buttonReset.Focus();
                    }

                    // It will display currentday
                    labelDays.Text = "Day " + dayOfUnitShipped;
                }

                // Display an error message if the value is out of range
                else
                {
                    // if the entered value is out of range, it will display the error message
                    MessageBox.Show("Please enter the unit shipped value between "
                        + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Output!");
                    // the entry box gets cleared and set focus to enter another one
                    textBoxUnitsInput.Clear();
                    textBoxUnitsInput.SelectAll();
                    textBoxUnitsInput.Focus();
                }
                
            }

            // display the error message if the value is non numeric
            else
                {
                    // if the value is non numeric, it will display error message
                    MessageBox.Show("The entered unit value must be whole number. Please enter again.",
                        "Invalid Input!");
                    textBoxUnitsInput.Clear();
                    textBoxUnitsInput.SelectAll();
                    textBoxUnitsInput.Focus();
                }


        }

        /// <summary>
        /// It will close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            // It is used to close the form.
            Close();
        }


        /// <summary>
        /// it will reset the form on pressing reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }


        /// <summary>
        /// It will set all the textboxes and labels to its default place
        /// </summary>
        private void SetDefaults()
        {
            // the entry box gets cleared
            textBoxUnitsInput.Clear();

            // the added entries gets cleared
            textBoxEmployee1Entries.Clear();
            textBoxEmployee2Entries.Clear();
            textBoxEmployee3Entries.Clear();

            // the label text gets empty
            labelOverallAverage.Text = "";
            labelEmployee1Average.Text = "";
            labelEmployee2Average.Text = "";
            labelEmployee3Average.Text = "";

            // the current days set to 1
            dayOfUnitShipped = 1;

            // It set the font of employee1 to bold 
            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Regular);
            labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Regular);

            // the label of the day displayed day1
            labelDays.Text = "Day " + dayOfUnitShipped;

            // it enabled the entry box and enter button
            textBoxUnitsInput.Enabled = true;
            textBoxEmployee1Entries.Enabled = true;
            textBoxEmployee2Entries.Enabled = true;
            textBoxEmployee3Entries.Enabled = true;

            buttonEnter.Enabled = true;

            // set the focus on the entry box for user to calculate another set of values
            textBoxUnitsInput.Focus();

            // Set current employee as 1
            currentEmployee = 1;
            overallTotal = 0;

            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
