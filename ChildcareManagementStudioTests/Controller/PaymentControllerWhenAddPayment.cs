﻿using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddPayment method of the PaymentController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PaymentControllerWhenAddPayment
    {
        [TestMethod]
        public void ShouldAddValidRecord()
        {
            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            DateTime paymentDate = new DateTime(2021, 7, 8);

            double amount = 125;

            PaymentType paymentType = PaymentType.Cash;

            Payment payment = new Payment()
            {
                AccountHolder = accountHolder,
                PaymentDate = paymentDate,
                Amount = amount,
                PaymentType = paymentType
            };

            PaymentController paymentController = new PaymentController();

            paymentController.AddPayment(payment);

            List<Payment> payments = paymentController.GetPayments(accountHolder);
            Payment paymentFromDatabase = payments[1];

            Assert.AreEqual(2, payments.Count);
            Assert.AreEqual(2, paymentFromDatabase.PaymentId);
            Assert.AreEqual(accountHolder.AccountHolderId, paymentFromDatabase.AccountHolder.AccountHolderId);
            Assert.AreEqual(paymentDate, paymentFromDatabase.PaymentDate);
            Assert.AreEqual(amount, paymentFromDatabase.Amount);
            Assert.AreEqual(paymentType, paymentFromDatabase.PaymentType);
        }
    }
}