﻿
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class SetupClassUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelClassroom = new System.Windows.Forms.Label();
            this.labelSchoolYear = new System.Windows.Forms.Label();
            this.labelValueSchoolYear = new System.Windows.Forms.Label();
            this.buttonChangeSchoolYear = new System.Windows.Forms.Button();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEditTeacherList = new System.Windows.Forms.Button();
            this.labelAddedStudents = new System.Windows.Forms.Label();
            this.listViewStudentsNotInClass = new System.Windows.Forms.ListView();
            this.studentNameAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewStudentsInClass = new System.Windows.Forms.ListView();
            this.studentNameInClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonNewClass = new System.Windows.Forms.Button();
            this.labelValueClassroom = new System.Windows.Forms.Label();
            this.buttonChangeClassroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClassroom
            // 
            this.labelClassroom.AutoSize = true;
            this.labelClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassroom.Location = new System.Drawing.Point(17, 101);
            this.labelClassroom.Name = "labelClassroom";
            this.labelClassroom.Size = new System.Drawing.Size(93, 21);
            this.labelClassroom.TabIndex = 0;
            this.labelClassroom.Text = "Classroom:";
            // 
            // labelSchoolYear
            // 
            this.labelSchoolYear.AutoSize = true;
            this.labelSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolYear.Location = new System.Drawing.Point(17, 20);
            this.labelSchoolYear.Name = "labelSchoolYear";
            this.labelSchoolYear.Size = new System.Drawing.Size(106, 21);
            this.labelSchoolYear.TabIndex = 2;
            this.labelSchoolYear.Text = "School Year:";
            // 
            // labelValueSchoolYear
            // 
            this.labelValueSchoolYear.AutoSize = true;
            this.labelValueSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueSchoolYear.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueSchoolYear.Location = new System.Drawing.Point(118, 22);
            this.labelValueSchoolYear.Name = "labelValueSchoolYear";
            this.labelValueSchoolYear.Size = new System.Drawing.Size(70, 19);
            this.labelValueSchoolYear.TabIndex = 3;
            this.labelValueSchoolYear.Text = "2020-21";
            // 
            // buttonChangeSchoolYear
            // 
            this.buttonChangeSchoolYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSchoolYear.Location = new System.Drawing.Point(194, 22);
            this.buttonChangeSchoolYear.Name = "buttonChangeSchoolYear";
            this.buttonChangeSchoolYear.Size = new System.Drawing.Size(176, 23);
            this.buttonChangeSchoolYear.TabIndex = 1;
            this.buttonChangeSchoolYear.Text = "Change School Year";
            this.buttonChangeSchoolYear.UseVisualStyleBackColor = true;
            this.buttonChangeSchoolYear.Click += new System.EventHandler(this.ButtonChangeSchoolYear_Click);
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacher.Location = new System.Drawing.Point(417, 22);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(96, 21);
            this.labelTeacher.TabIndex = 5;
            this.labelTeacher.Text = "Teacher(s):";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewTeachers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTeachers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(519, 22);
            this.listViewTeachers.MultiSelect = false;
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(200, 70);
            this.listViewTeachers.TabIndex = 22;
            this.listViewTeachers.TabStop = false;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.List;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Teacher Name";
            // 
            // buttonEditTeacherList
            // 
            this.buttonEditTeacherList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTeacherList.Location = new System.Drawing.Point(519, 98);
            this.buttonEditTeacherList.Name = "buttonEditTeacherList";
            this.buttonEditTeacherList.Size = new System.Drawing.Size(200, 23);
            this.buttonEditTeacherList.TabIndex = 5;
            this.buttonEditTeacherList.Text = "Add/Remove Teachers";
            this.buttonEditTeacherList.UseVisualStyleBackColor = true;
            this.buttonEditTeacherList.Click += new System.EventHandler(this.ButtonEditTeacherList_Click);
            // 
            // labelAddedStudents
            // 
            this.labelAddedStudents.AutoSize = true;
            this.labelAddedStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddedStudents.Location = new System.Drawing.Point(417, 142);
            this.labelAddedStudents.Name = "labelAddedStudents";
            this.labelAddedStudents.Size = new System.Drawing.Size(145, 21);
            this.labelAddedStudents.TabIndex = 8;
            this.labelAddedStudents.Text = "Students In Class:";
            // 
            // listViewStudentsNotInClass
            // 
            this.listViewStudentsNotInClass.CheckBoxes = true;
            this.listViewStudentsNotInClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentNameAvailable});
            this.listViewStudentsNotInClass.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStudentsNotInClass.HideSelection = false;
            this.listViewStudentsNotInClass.Location = new System.Drawing.Point(21, 166);
            this.listViewStudentsNotInClass.Name = "listViewStudentsNotInClass";
            this.listViewStudentsNotInClass.Size = new System.Drawing.Size(298, 244);
            this.listViewStudentsNotInClass.TabIndex = 6;
            this.listViewStudentsNotInClass.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsNotInClass.View = System.Windows.Forms.View.Details;
            // 
            // studentNameAvailable
            // 
            this.studentNameAvailable.Text = "Student Name";
            this.studentNameAvailable.Width = 275;
            // 
            // listViewStudentsInClass
            // 
            this.listViewStudentsInClass.CheckBoxes = true;
            this.listViewStudentsInClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentNameInClass});
            this.listViewStudentsInClass.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStudentsInClass.HideSelection = false;
            this.listViewStudentsInClass.Location = new System.Drawing.Point(421, 166);
            this.listViewStudentsInClass.Name = "listViewStudentsInClass";
            this.listViewStudentsInClass.Size = new System.Drawing.Size(298, 244);
            this.listViewStudentsInClass.TabIndex = 8;
            this.listViewStudentsInClass.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsInClass.View = System.Windows.Forms.View.Details;
            // 
            // studentNameInClass
            // 
            this.studentNameInClass.Text = "Student Name";
            this.studentNameInClass.Width = 275;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Available Students:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(325, 217);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(90, 40);
            this.buttonAddStudent.TabIndex = 7;
            this.buttonAddStudent.Text = "-->";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Location = new System.Drawing.Point(325, 272);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(90, 40);
            this.buttonRemoveStudent.TabIndex = 9;
            this.buttonRemoveStudent.Text = "<--";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            this.buttonRemoveStudent.Click += new System.EventHandler(this.ButtonRemoveStudent_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(17, 60);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(53, 21);
            this.labelClass.TabIndex = 14;
            this.labelClass.Text = "Class:";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(76, 57);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(254, 29);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClass_SelectedIndexChanged);
            // 
            // buttonNewClass
            // 
            this.buttonNewClass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewClass.Location = new System.Drawing.Point(336, 60);
            this.buttonNewClass.Name = "buttonNewClass";
            this.buttonNewClass.Size = new System.Drawing.Size(113, 25);
            this.buttonNewClass.TabIndex = 3;
            this.buttonNewClass.Text = "Create New Class";
            this.buttonNewClass.UseVisualStyleBackColor = true;
            this.buttonNewClass.Click += new System.EventHandler(this.ButtonNewClass_Click);
            // 
            // labelValueClassroom
            // 
            this.labelValueClassroom.AutoSize = true;
            this.labelValueClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueClassroom.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueClassroom.Location = new System.Drawing.Point(116, 103);
            this.labelValueClassroom.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelValueClassroom.Name = "labelValueClassroom";
            this.labelValueClassroom.Size = new System.Drawing.Size(37, 19);
            this.labelValueClassroom.TabIndex = 17;
            this.labelValueClassroom.Text = "n/a";
            // 
            // buttonChangeClassroom
            // 
            this.buttonChangeClassroom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeClassroom.Location = new System.Drawing.Point(272, 103);
            this.buttonChangeClassroom.Name = "buttonChangeClassroom";
            this.buttonChangeClassroom.Size = new System.Drawing.Size(126, 25);
            this.buttonChangeClassroom.TabIndex = 4;
            this.buttonChangeClassroom.Text = "Change Classroom";
            this.buttonChangeClassroom.UseVisualStyleBackColor = true;
            this.buttonChangeClassroom.Click += new System.EventHandler(this.ButtonChangeClassroom_Click);
            // 
            // SetupClassUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonChangeClassroom);
            this.Controls.Add(this.labelValueClassroom);
            this.Controls.Add(this.buttonNewClass);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStudentsInClass);
            this.Controls.Add(this.listViewStudentsNotInClass);
            this.Controls.Add(this.labelAddedStudents);
            this.Controls.Add(this.buttonEditTeacherList);
            this.Controls.Add(this.listViewTeachers);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.buttonChangeSchoolYear);
            this.Controls.Add(this.labelValueSchoolYear);
            this.Controls.Add(this.labelSchoolYear);
            this.Controls.Add(this.labelClassroom);
            this.Name = "SetupClassUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClassroom;
        private System.Windows.Forms.Label labelSchoolYear;
        private System.Windows.Forms.Label labelValueSchoolYear;
        private System.Windows.Forms.Button buttonChangeSchoolYear;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.Button buttonEditTeacherList;
        private System.Windows.Forms.Label labelAddedStudents;
        private System.Windows.Forms.ListView listViewStudentsNotInClass;
        private System.Windows.Forms.ListView listViewStudentsInClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonRemoveStudent;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button buttonNewClass;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Label labelValueClassroom;
        private System.Windows.Forms.Button buttonChangeClassroom;
        private System.Windows.Forms.ColumnHeader studentNameAvailable;
        private System.Windows.Forms.ColumnHeader studentNameInClass;
    }
}
