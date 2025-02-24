﻿using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    /// <summary>
    /// Class will create and manage the dit classroom form
    /// </summary>
    public partial class EditClassroomForm : Form
    {
        private readonly ViewClassroomListUserControl referringUserControl;
        private readonly Classroom originalClassroom;
        private readonly ClassroomController classroomController;


        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl">the userControl creating this form</param>
        /// <param name="originalClassroom">the original Classroom object which is being edited</param>
        public EditClassroomForm(ViewClassroomListUserControl referringUserControl, Classroom originalClassroom)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.originalClassroom = originalClassroom;
            this.classroomController = new ClassroomController();
            this.PrefillFormValues();
        }

        /// <summary>
        /// Prefills form values with values in db for classroom to be edited
        /// </summary>
        private void PrefillFormValues()
        {
            this.textBoxLocation.Text = originalClassroom.Location;
            this.numericUpDownCapacity.Value = originalClassroom.Capacity;
        }

        /// <summary>
        /// Handles the submit button clicks to attempt to create new classroom entry in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.UserInputFormIsValid())
            {
                try
                {
                    Classroom revisedClassroom = new Classroom
                    {
                        Id = this.originalClassroom.Id,
                        Location = this.textBoxLocation.Text,
                        Capacity = Convert.ToInt32(Math.Round(this.numericUpDownCapacity.Value))
                    };
                    this.classroomController.EditClassroom(this.originalClassroom, revisedClassroom);                                        
                    this.Close();
                    
                }
                catch (Exception ex)
                {
                    string title = "Error Message";
                    string message = "An error was found. " + ex.Message +
                        "The classroom was NOT changed. Click 'Okay' to continue.";
                    MessageBox.Show(message, title);
                }
            }
        }

        /// <summary>
        /// Verifies that the user has typed some text in the location text box.  Note that
        /// the number UpDown box is set to not allow for negative numbers to be submitted 
        /// even if they are typed in manually by the user
        /// </summary>
        /// <returns>true if length of text in textbox > 0</returns>
        private bool UserInputFormIsValid()
        {
            if (this.textBoxLocation.Text.Length < 1)
            {
                string title = "Location Not Entered";
                string message = "The classroom requires a description of the location.  " +
                    "Please click 'Okay' and add a location description and resubmit.";
                MessageBox.Show(message, title);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Handles cancel button clicks to close form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Upon form close, re-enable the reffering UC and refresh classroom listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditClassroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.referringUserControl.RefreshClassroomListView();
        }
    }
}
