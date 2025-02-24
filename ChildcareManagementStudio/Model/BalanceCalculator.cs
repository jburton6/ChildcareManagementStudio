﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class that can be used to calculate an account holder's balance,
    /// given a list of tuition rate records and a list of payments.
    /// </summary>
    public class BalanceCalculator
    {
        private List<TuitionRateRecord> tuitionRateRecords;
        private List<Payment> payments;

        /// <summary>
        /// Constructor for the BalanceCalculator class.
        /// </summary>
        /// <param name="tuitionRateRecords">A list of tuition rate records associated with the account holder.</param>
        /// <param name="payments">A list of payments associated with the account holder.</param>
        public BalanceCalculator(List<TuitionRateRecord> tuitionRateRecords, List<Payment> payments)
        {
            if (tuitionRateRecords == null)
            {
                throw new ArgumentNullException("tuitionRateRecords", "The tuition rate records cannot be null.");
            }

            if (payments == null)
            {
                throw new ArgumentNullException("payments", "The payments cannot be null.");
            }

            if (tuitionRateRecords.Count == 0)
            {
                throw new ArgumentException("A balance cannot be calculated if there are no tuition rate records.", "tuitionRateRecords");
            }

            this.tuitionRateRecords = tuitionRateRecords;
            this.payments = payments;
        }

        /// <summary>
        /// Method that returns the total amount of tuition for all of the tuition rate records.
        /// </summary>
        /// <returns>The total amount of tuition for all of the tuition rate records.</returns>
        public double GetTuitionTotal()
        {
            double tuitionTotal = 0;

            foreach (TuitionRateRecord currentTuitionRateRecord in tuitionRateRecords)
            {
                double currentTuition = currentTuitionRateRecord.DailyRate * currentTuitionRateRecord.NumberOfWeekdaysInRange;
                tuitionTotal += currentTuition;
            }

            return tuitionTotal;
        }

        /// <summary>
        /// Method that returns the total amount of payments.
        /// </summary>
        /// <returns>The total amount of payments.</returns>
        public double GetPaymentTotal()
        {
            double paymentTotal = 0;

            foreach (Payment currentPayment in payments)
            {
                paymentTotal += currentPayment.Amount;
            }

            return paymentTotal;
        }

        /// <summary>
        /// Method that returns a Balance object based on the instance variables.
        /// </summary>
        /// <returns>A Balance object representing the account holder's balance.</returns>
        public Balance GetBalance()
        {
            AccountHolder accountHolder = tuitionRateRecords[0].AccountHolder;
            double tuitionTotal = this.GetTuitionTotal();
            double paymentTotal = this.GetPaymentTotal();
            double balanceAmount = tuitionTotal - paymentTotal;
            Balance balance = new Balance()
            {
                AccountHolder = accountHolder,
                Amount = balanceAmount
            };
            return balance;
        }
    }
}