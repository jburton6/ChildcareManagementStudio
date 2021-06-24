﻿using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    public partial class AddNewClassroomForm : Form
    {
        ViewClassroomListUserControl referringUserControl;

        public AddNewClassroomForm(ViewClassroomListUserControl referringUserControl)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.Close();
        }
    }
}
