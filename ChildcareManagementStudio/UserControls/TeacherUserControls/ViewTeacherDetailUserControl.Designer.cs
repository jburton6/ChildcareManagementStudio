﻿
namespace ChildcareManagementStudio.UserControls
{
    partial class ViewTeacherDetailUserControl
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelValueDOB = new System.Windows.Forms.Label();
            this.labelValueSSN = new System.Windows.Forms.Label();
            this.labelValuePhone = new System.Windows.Forms.Label();
            this.labelValueGender = new System.Windows.Forms.Label();
            this.labelValueAddress1 = new System.Windows.Forms.Label();
            this.labelValueAddress2 = new System.Windows.Forms.Label();
            this.labelValueCity = new System.Windows.Forms.Label();
            this.labelValueState = new System.Windows.Forms.Label();
            this.labelValueZipCode = new System.Windows.Forms.Label();
            this.labelValueStartDate = new System.Windows.Forms.Label();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCredentialHistory = new System.Windows.Forms.ListView();
            this.columnHeaderCredential = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPayHistory = new System.Windows.Forms.ListView();
            this.columnHeaderPayRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEffectiveDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCredentialHistory = new System.Windows.Forms.Label();
            this.labelPayHistory = new System.Windows.Forms.Label();
            this.labelPositionHistory = new System.Windows.Forms.Label();
            this.buttonChangePosition = new System.Windows.Forms.Button();
            this.buttonChangePayRate = new System.Windows.Forms.Button();
            this.buttonAddNewCredential = new System.Windows.Forms.Button();
            this.listViewPositionHistory = new System.Windows.Forms.ListView();
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSchoolYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripPositionHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeletePosition = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripPayHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDeletePay = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCredentialHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteCredential = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.contextMenuStripPositionHistory.SuspendLayout();
            this.contextMenuStripPayHistory.SuspendLayout();
            this.contextMenuStripCredentialHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(54, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 35);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Teacher Name:";
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(15, 47);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(134, 23);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress1.Location = new System.Drawing.Point(39, 117);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(110, 23);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "Address 1:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress2.Location = new System.Drawing.Point(39, 152);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(110, 23);
            this.labelAddress2.TabIndex = 5;
            this.labelAddress2.Text = "Address 2:";
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(97, 187);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(52, 23);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "City:";
            // 
            // labelState
            // 
            this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(387, 187);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(66, 23);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "State:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.Location = new System.Drawing.Point(45, 222);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(104, 23);
            this.labelZipCode.TabIndex = 8;
            this.labelZipCode.Text = "Zip Code:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(339, 222);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(114, 23);
            this.labelStartDate.TabIndex = 21;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(55, 70);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(94, 35);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelSSN
            // 
            this.labelSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSSN.AutoSize = true;
            this.labelSSN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.Location = new System.Drawing.Point(403, 47);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(50, 23);
            this.labelSSN.TabIndex = 23;
            this.labelSSN.Text = "SSN:";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(363, 82);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(90, 23);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "Gender:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDOB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCity, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelState, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelZipCode, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelStartDate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSSN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelValueDOB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValueSSN, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValuePhone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueGender, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueAddress1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelValueAddress2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelValueCity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelValueState, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelValueZipCode, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelValueStartDate, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditTeacher, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 283);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxName, 2);
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(155, 7);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(288, 31);
            this.comboBoxName.TabIndex = 25;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxName_SelectedIndexChanged);
            // 
            // labelValueDOB
            // 
            this.labelValueDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueDOB.AutoSize = true;
            this.labelValueDOB.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueDOB.Location = new System.Drawing.Point(155, 47);
            this.labelValueDOB.Name = "labelValueDOB";
            this.labelValueDOB.Size = new System.Drawing.Size(0, 23);
            this.labelValueDOB.TabIndex = 27;
            // 
            // labelValueSSN
            // 
            this.labelValueSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueSSN.AutoSize = true;
            this.labelValueSSN.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueSSN.Location = new System.Drawing.Point(459, 47);
            this.labelValueSSN.Name = "labelValueSSN";
            this.labelValueSSN.Size = new System.Drawing.Size(0, 23);
            this.labelValueSSN.TabIndex = 28;
            // 
            // labelValuePhone
            // 
            this.labelValuePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValuePhone.AutoSize = true;
            this.labelValuePhone.ForeColor = System.Drawing.Color.Maroon;
            this.labelValuePhone.Location = new System.Drawing.Point(155, 82);
            this.labelValuePhone.Name = "labelValuePhone";
            this.labelValuePhone.Size = new System.Drawing.Size(0, 23);
            this.labelValuePhone.TabIndex = 29;
            // 
            // labelValueGender
            // 
            this.labelValueGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueGender.AutoSize = true;
            this.labelValueGender.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueGender.Location = new System.Drawing.Point(459, 82);
            this.labelValueGender.Name = "labelValueGender";
            this.labelValueGender.Size = new System.Drawing.Size(0, 23);
            this.labelValueGender.TabIndex = 30;
            // 
            // labelValueAddress1
            // 
            this.labelValueAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueAddress1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelValueAddress1, 3);
            this.labelValueAddress1.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueAddress1.Location = new System.Drawing.Point(155, 117);
            this.labelValueAddress1.Name = "labelValueAddress1";
            this.labelValueAddress1.Size = new System.Drawing.Size(0, 23);
            this.labelValueAddress1.TabIndex = 31;
            // 
            // labelValueAddress2
            // 
            this.labelValueAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueAddress2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelValueAddress2, 3);
            this.labelValueAddress2.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueAddress2.Location = new System.Drawing.Point(155, 152);
            this.labelValueAddress2.Name = "labelValueAddress2";
            this.labelValueAddress2.Size = new System.Drawing.Size(0, 23);
            this.labelValueAddress2.TabIndex = 32;
            // 
            // labelValueCity
            // 
            this.labelValueCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueCity.AutoSize = true;
            this.labelValueCity.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueCity.Location = new System.Drawing.Point(155, 187);
            this.labelValueCity.Name = "labelValueCity";
            this.labelValueCity.Size = new System.Drawing.Size(0, 23);
            this.labelValueCity.TabIndex = 33;
            // 
            // labelValueState
            // 
            this.labelValueState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueState.AutoSize = true;
            this.labelValueState.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueState.Location = new System.Drawing.Point(459, 187);
            this.labelValueState.Name = "labelValueState";
            this.labelValueState.Size = new System.Drawing.Size(0, 23);
            this.labelValueState.TabIndex = 34;
            // 
            // labelValueZipCode
            // 
            this.labelValueZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueZipCode.AutoSize = true;
            this.labelValueZipCode.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueZipCode.Location = new System.Drawing.Point(155, 222);
            this.labelValueZipCode.Name = "labelValueZipCode";
            this.labelValueZipCode.Size = new System.Drawing.Size(0, 23);
            this.labelValueZipCode.TabIndex = 35;
            // 
            // labelValueStartDate
            // 
            this.labelValueStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueStartDate.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelValueStartDate, 2);
            this.labelValueStartDate.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueStartDate.Location = new System.Drawing.Point(459, 222);
            this.labelValueStartDate.Name = "labelValueStartDate";
            this.labelValueStartDate.Size = new System.Drawing.Size(0, 23);
            this.labelValueStartDate.TabIndex = 36;
            this.labelValueStartDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonEditTeacher, 5);
            this.buttonEditTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTeacher.Location = new System.Drawing.Point(125, 256);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(513, 28);
            this.buttonEditTeacher.TabIndex = 26;
            this.buttonEditTeacher.Text = "Edit Details for Selected Teacher";
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            this.buttonEditTeacher.Click += new System.EventHandler(this.ButtonEditTeacher_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.Controls.Add(this.listViewCredentialHistory, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.listViewPayHistory, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCredentialHistory, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPayHistory, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPositionHistory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangePosition, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangePayRate, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddNewCredential, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.listViewPositionHistory, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 312);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 187);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // listViewCredentialHistory
            // 
            this.listViewCredentialHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCredential,
            this.columnHeaderExpiration});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewCredentialHistory, 2);
            this.listViewCredentialHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCredentialHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCredentialHistory.FullRowSelect = true;
            this.listViewCredentialHistory.HideSelection = false;
            this.listViewCredentialHistory.Location = new System.Drawing.Point(491, 38);
            this.listViewCredentialHistory.Name = "listViewCredentialHistory";
            this.listViewCredentialHistory.Size = new System.Drawing.Size(245, 111);
            this.listViewCredentialHistory.TabIndex = 8;
            this.listViewCredentialHistory.UseCompatibleStateImageBehavior = false;
            this.listViewCredentialHistory.View = System.Windows.Forms.View.Details;
            this.listViewCredentialHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewCredentialHistory_MouseClick);
            // 
            // columnHeaderCredential
            // 
            this.columnHeaderCredential.Text = "Description";
            this.columnHeaderCredential.Width = 119;
            // 
            // columnHeaderExpiration
            // 
            this.columnHeaderExpiration.Text = "Expiration";
            this.columnHeaderExpiration.Width = 119;
            // 
            // listViewPayHistory
            // 
            this.listViewPayHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPayRate,
            this.columnHeaderEffectiveDate});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewPayHistory, 2);
            this.listViewPayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPayHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPayHistory.FullRowSelect = true;
            this.listViewPayHistory.HideSelection = false;
            this.listViewPayHistory.Location = new System.Drawing.Point(247, 38);
            this.listViewPayHistory.Name = "listViewPayHistory";
            this.listViewPayHistory.Size = new System.Drawing.Size(238, 111);
            this.listViewPayHistory.TabIndex = 7;
            this.listViewPayHistory.UseCompatibleStateImageBehavior = false;
            this.listViewPayHistory.View = System.Windows.Forms.View.Details;
            this.listViewPayHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewPayHistory_MouseClick);
            // 
            // columnHeaderPayRate
            // 
            this.columnHeaderPayRate.Text = "Rate";
            this.columnHeaderPayRate.Width = 115;
            // 
            // columnHeaderEffectiveDate
            // 
            this.columnHeaderEffectiveDate.Text = "StartDate";
            this.columnHeaderEffectiveDate.Width = 117;
            // 
            // labelCredentialHistory
            // 
            this.labelCredentialHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCredentialHistory.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelCredentialHistory, 2);
            this.labelCredentialHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredentialHistory.Location = new System.Drawing.Point(491, 6);
            this.labelCredentialHistory.Name = "labelCredentialHistory";
            this.labelCredentialHistory.Size = new System.Drawing.Size(245, 23);
            this.labelCredentialHistory.TabIndex = 2;
            this.labelCredentialHistory.Text = "Credential History";
            this.labelCredentialHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPayHistory
            // 
            this.labelPayHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPayHistory.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelPayHistory, 2);
            this.labelPayHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayHistory.Location = new System.Drawing.Point(247, 6);
            this.labelPayHistory.Name = "labelPayHistory";
            this.labelPayHistory.Size = new System.Drawing.Size(238, 23);
            this.labelPayHistory.TabIndex = 1;
            this.labelPayHistory.Text = "Pay History";
            this.labelPayHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPositionHistory
            // 
            this.labelPositionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPositionHistory.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelPositionHistory, 2);
            this.labelPositionHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositionHistory.Location = new System.Drawing.Point(3, 6);
            this.labelPositionHistory.Name = "labelPositionHistory";
            this.labelPositionHistory.Size = new System.Drawing.Size(238, 23);
            this.labelPositionHistory.TabIndex = 0;
            this.labelPositionHistory.Text = "Position History";
            this.labelPositionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangePosition
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonChangePosition, 2);
            this.buttonChangePosition.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePosition.Location = new System.Drawing.Point(3, 155);
            this.buttonChangePosition.Name = "buttonChangePosition";
            this.buttonChangePosition.Size = new System.Drawing.Size(238, 29);
            this.buttonChangePosition.TabIndex = 3;
            this.buttonChangePosition.Text = "Change Position";
            this.buttonChangePosition.UseVisualStyleBackColor = true;
            this.buttonChangePosition.Click += new System.EventHandler(this.ButtonChangePosition_Click);
            // 
            // buttonChangePayRate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonChangePayRate, 2);
            this.buttonChangePayRate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePayRate.Location = new System.Drawing.Point(247, 155);
            this.buttonChangePayRate.Name = "buttonChangePayRate";
            this.buttonChangePayRate.Size = new System.Drawing.Size(238, 29);
            this.buttonChangePayRate.TabIndex = 4;
            this.buttonChangePayRate.Text = "Change Pay Rate";
            this.buttonChangePayRate.UseVisualStyleBackColor = true;
            this.buttonChangePayRate.Click += new System.EventHandler(this.ButtonChangePayRate_Click);
            // 
            // buttonAddNewCredential
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonAddNewCredential, 2);
            this.buttonAddNewCredential.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewCredential.Location = new System.Drawing.Point(491, 155);
            this.buttonAddNewCredential.Name = "buttonAddNewCredential";
            this.buttonAddNewCredential.Size = new System.Drawing.Size(245, 29);
            this.buttonAddNewCredential.TabIndex = 5;
            this.buttonAddNewCredential.Text = "Add New Credential";
            this.buttonAddNewCredential.UseVisualStyleBackColor = true;
            this.buttonAddNewCredential.Click += new System.EventHandler(this.ButtonAddNewCredential_Click);
            // 
            // listViewPositionHistory
            // 
            this.listViewPositionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPosition,
            this.columnHeaderSchoolYear});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewPositionHistory, 2);
            this.listViewPositionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPositionHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPositionHistory.FullRowSelect = true;
            this.listViewPositionHistory.HideSelection = false;
            this.listViewPositionHistory.Location = new System.Drawing.Point(3, 38);
            this.listViewPositionHistory.Name = "listViewPositionHistory";
            this.listViewPositionHistory.Size = new System.Drawing.Size(238, 111);
            this.listViewPositionHistory.TabIndex = 6;
            this.listViewPositionHistory.UseCompatibleStateImageBehavior = false;
            this.listViewPositionHistory.View = System.Windows.Forms.View.Details;
            this.listViewPositionHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewPositionHistory_MouseClick);
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.Text = "Position";
            this.columnHeaderPosition.Width = 112;
            // 
            // columnHeaderSchoolYear
            // 
            this.columnHeaderSchoolYear.Text = "School Year";
            this.columnHeaderSchoolYear.Width = 120;
            // 
            // contextMenuStripPositionHistory
            // 
            this.contextMenuStripPositionHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPositionHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeletePosition});
            this.contextMenuStripPositionHistory.Name = "contextMenuStripPositionHistory";
            this.contextMenuStripPositionHistory.ShowImageMargin = false;
            this.contextMenuStripPositionHistory.Size = new System.Drawing.Size(205, 28);
            // 
            // toolStripMenuItemDeletePosition
            // 
            this.toolStripMenuItemDeletePosition.Name = "toolStripMenuItemDeletePosition";
            this.toolStripMenuItemDeletePosition.Size = new System.Drawing.Size(204, 24);
            this.toolStripMenuItemDeletePosition.Text = "Delete Position Record";
            this.toolStripMenuItemDeletePosition.Click += new System.EventHandler(this.ToolStripMenuItemDeletePosition_Click);
            // 
            // contextMenuStripPayHistory
            // 
            this.contextMenuStripPayHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPayHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDeletePay});
            this.contextMenuStripPayHistory.Name = "contextMenuStripPayHistory";
            this.contextMenuStripPayHistory.ShowImageMargin = false;
            this.contextMenuStripPayHistory.Size = new System.Drawing.Size(175, 28);
            // 
            // toolStripMenuDeletePay
            // 
            this.toolStripMenuDeletePay.Name = "toolStripMenuDeletePay";
            this.toolStripMenuDeletePay.Size = new System.Drawing.Size(174, 24);
            this.toolStripMenuDeletePay.Text = "Delete Pay Record";
            this.toolStripMenuDeletePay.Click += new System.EventHandler(this.ToolStripMenuDeletePay_Click);
            // 
            // contextMenuStripCredentialHistory
            // 
            this.contextMenuStripCredentialHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripCredentialHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteCredential});
            this.contextMenuStripCredentialHistory.Name = "contextMenuStripCredentialHistory";
            this.contextMenuStripCredentialHistory.ShowImageMargin = false;
            this.contextMenuStripCredentialHistory.Size = new System.Drawing.Size(221, 28);
            // 
            // toolStripMenuItemDeleteCredential
            // 
            this.toolStripMenuItemDeleteCredential.Name = "toolStripMenuItemDeleteCredential";
            this.toolStripMenuItemDeleteCredential.Size = new System.Drawing.Size(220, 24);
            this.toolStripMenuItemDeleteCredential.Text = "Delete Credential Record";
            this.toolStripMenuItemDeleteCredential.Click += new System.EventHandler(this.ToolStripMenuItemDeleteCredential_Click);
            // 
            // ViewTeacherDetailUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewTeacherDetailUserControl";
            this.Size = new System.Drawing.Size(770, 540);
            this.EnabledChanged += new System.EventHandler(this.TeacherViewTeacherDetailUserControl_EnabledChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contextMenuStripPositionHistory.ResumeLayout(false);
            this.contextMenuStripPayHistory.ResumeLayout(false);
            this.contextMenuStripCredentialHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelCredentialHistory;
        private System.Windows.Forms.Label labelPayHistory;
        private System.Windows.Forms.Label labelPositionHistory;
        private System.Windows.Forms.Button buttonChangePosition;
        private System.Windows.Forms.Button buttonChangePayRate;
        private System.Windows.Forms.Button buttonAddNewCredential;
        private System.Windows.Forms.ListView listViewCredentialHistory;
        private System.Windows.Forms.ListView listViewPayHistory;
        private System.Windows.Forms.ListView listViewPositionHistory;
        private System.Windows.Forms.Label labelValueDOB;
        private System.Windows.Forms.Label labelValueSSN;
        private System.Windows.Forms.Label labelValuePhone;
        private System.Windows.Forms.Label labelValueGender;
        private System.Windows.Forms.Label labelValueAddress1;
        private System.Windows.Forms.Label labelValueAddress2;
        private System.Windows.Forms.Label labelValueCity;
        private System.Windows.Forms.Label labelValueState;
        private System.Windows.Forms.Label labelValueZipCode;
        private System.Windows.Forms.Label labelValueStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ColumnHeader columnHeaderSchoolYear;
        private System.Windows.Forms.ColumnHeader columnHeaderCredential;
        private System.Windows.Forms.ColumnHeader columnHeaderExpiration;
        private System.Windows.Forms.ColumnHeader columnHeaderPayRate;
        private System.Windows.Forms.ColumnHeader columnHeaderEffectiveDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPositionHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeletePosition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPayHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeletePay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCredentialHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteCredential;
    }
}
