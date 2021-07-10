﻿using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    /// <summary>
    /// User control for viewing payments made by account holders.
    /// </summary>
    public partial class ViewPaymentsUserControl : UserControl
    {
        private readonly PaymentController paymentController;
        private readonly AccountHolderController accountHolderController;
        private List<AccountHolder> accountHolders;

        /// <summary>
        /// Constructor for the user control.
        /// </summary>
        public ViewPaymentsUserControl()
        {
            InitializeComponent();
            paymentController = new PaymentController();
            accountHolderController = new AccountHolderController();
            this.Refresh();
        }

        /// <summary>
        /// Method that can be called to refresh the user control.
        /// </summary>
        public void RefreshPaymentsUserControl()
        {
            accountHolders = accountHolderController.GetAllAccountHolders();
            comboParentName.DataSource = accountHolders;
            comboParentName.DisplayMember = "FullName";
        }

        private void ComboParentName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.listViewPaymentRecords.Items.Clear();
            AccountHolder accountHolder = accountHolders[comboParentName.SelectedIndex];
            List<Payment> payments = paymentController.GetPayments(accountHolder);
            foreach (Payment currentPayment in payments)
            {
                ListViewItem item = new ListViewItem(currentPayment.PaymentDate.ToShortDateString());
                item.SubItems.Add(currentPayment.Amount.ToString("$#,##0.00"));
                this.listViewPaymentRecords.Items.Add(item);
            }
        }
    }
}
