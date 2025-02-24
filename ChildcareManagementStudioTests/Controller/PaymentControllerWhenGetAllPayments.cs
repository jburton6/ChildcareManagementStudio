﻿using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllPayments method of the PaymentController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PaymentControllerWhenGetAllPayments
    {
        [TestMethod]
        public void ShouldGetAllPayments()
        {
            PaymentController paymentController = new PaymentController();
            List<Payment> payments = paymentController.GetAllPayments();

            Assert.AreEqual(1, payments.Count);
            Payment firstPayment = payments[0];

            Assert.AreEqual(2, firstPayment.PaymentId);
            Assert.AreEqual(new DateTime(2021, 7, 8), firstPayment.PaymentDate);
            Assert.AreEqual(125.00, firstPayment.Amount);
            Assert.AreEqual(PaymentType.Cash, firstPayment.PaymentType);
        }
    }
}