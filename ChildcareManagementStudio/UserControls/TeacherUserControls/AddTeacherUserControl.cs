﻿using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    /// <summary>
    /// This class builds and manages the add new teacher user control
    /// </summary>
    public partial class AddTeacherUserControl : UserControl
    {
        private readonly EmployeeController employeeController;       

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public AddTeacherUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            
        }

        /// <summary>
        /// Actions to perform when the submit button is clicked.  It should run a validation of form data 
        /// and then attempt to create the new employee in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {               
            this.labelErrorMessage.Text = this.CheckInputFields();

            if (this.labelErrorMessage.Text == "")
            {
                string firstName = this.textBoxFirstName.Text;
                string lastName = this.textBoxLastName.Text;
                DateTime dob = this.dateTimePickerDOB.Value;
                string ssn = this.textBoxSSN.Text;
                string phone = this.textBoxPhoneNumber.Text;
                string gender = this.comboBoxGender.Text;
                string address1 = this.textBoxAddress1.Text;
                string address2 = this.textBoxAddress2.Text;
                string city = this.textBoxCity.Text;
                string state = this.comboBoxState.Text;
                string zip = this.textBoxZipCode.Text;
                try
                {
                    Employee newEmployee = new Employee
                    {
                        LastName = lastName,
                        FirstName = firstName,
                        DateOfBirth = dob,
                        SocialSecurityNumber = ssn,
                        PhoneNumber = phone,
                        Gender = gender,
                        AddressLine1 = address1,
                        AddressLine2 = address2,
                        City = city,
                        State = state,
                        ZipCode = zip
                    };
                    this.employeeController.AddEmployee(newEmployee);
                    String successText = "Employee  (" + firstName + " " + lastName + ") successfully added.";
                    var dialogeResult = MessageBox.Show(successText, "Employee Added Success");
                    this.ClearForm();
                }
                catch (SqliteException sqlex)
                {
                    this.labelErrorMessage.Text = "The social security number entered for this employee " +
                        "is already found in the system.  Duplicate social security numbers are not allowed. " +
                        "Please fix and try again. ";
                }
                catch (Exception ex)
                {
                    this.labelErrorMessage.Text = "Form data not submitted." + ex.Message + " Please fix and try again. ";
                }
                    

            }
        }


        /// <summary>
        /// Handler for button clicks of the Clear button.  Should reset the form to empty/default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        /// <summary>
        /// Clears all form fields and resets date pickers back to today.
        /// </summary>
        private void ClearForm()
        {
            this.textBoxFirstName.Text = "";
            this.textBoxLastName.Text = "";
            this.dateTimePickerDOB.Value = DateTime.Now;
            this.textBoxSSN.Text = "";
            this.textBoxPhoneNumber.Text = "";
            this.comboBoxGender.SelectedIndex = -1;
            this.textBoxAddress1.Text = "";
            this.textBoxAddress2.Text = "";
            this.textBoxCity.Text = "";
            this.comboBoxState.SelectedIndex = -1;
            this.textBoxZipCode.Text = "";
            this.labelErrorMessage.Text = "";
        }

        /// <summary>
        /// Performs inital validation on the form fields.
        /// </summary>
        /// <returns>alert text to be displayed if errors are found (blank string if no errors)</returns>
        private string CheckInputFields()
        {
            String alertText = "";

            if (String.IsNullOrEmpty(this.textBoxLastName.Text))
            {
                alertText += "First name cannot be blank.  ";
            }
            if (String.IsNullOrEmpty(this.textBoxFirstName.Text))
            {
                alertText += "Last name cannot be blank.  ";
            }
            if (DateTime.Compare(this.dateTimePickerDOB.Value, DateTime.Now) > 0)
            {
                alertText += "The date of birth cannot be in the future.  ";
            }
            if (this.textBoxPhoneNumber.Text.Length != 14)
            {
                alertText += "Ten digit phone number is required of the following format: (xxx) xxx-xxxx.  ";
            }
            if (String.IsNullOrEmpty(this.textBoxAddress1.Text))
            {
                alertText += "Address cannot be blank.  ";
            }
            if (String.IsNullOrEmpty(this.comboBoxState.Text))
            {
                alertText += "State must be selected.  ";
            }
            if (String.IsNullOrEmpty(this.textBoxCity.Text))
            {
                alertText += "City is required.  ";
            }
            else if (char.IsLower(textBoxCity.Text[0]))
            {
                alertText += "City name should start with a capital letter.  ";
            }
            if (this.textBoxZipCode.Text.Length != 5)
            {
                alertText += "Five digit zip number is required.  ";
            }

            return alertText;
        }
    }

    
}
