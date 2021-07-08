﻿using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    [TestClass]
    public class ClockRecordControllerWhenClockOut
    {
        private ClockRecordController clockRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordController = new ClockRecordController();
        }

        [TestMethod]
        public void ShouldUpdateRecordWithOutDateTimeForEmployee()
        {
            int employeeId = 2;
            List<ClockRecord> recordsBefore = this.clockRecordController.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, recordsBefore.Count);
            ClockRecord inTestRecord = recordsBefore[0];
            ClockRecord outTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = inTestRecord.InDateTime,
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            this.clockRecordController.ClockOut(inTestRecord, outTestRecord);
            List<ClockRecord> recordsAfter = this.clockRecordController.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, recordsAfter.Count);
            Assert.AreEqual("7/5/2021 8:00:00 AM", recordsAfter[0].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:30:00 PM", recordsAfter[0].OutDateTime.ToString());
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenClockInRecordNull()
        {
            int employeeId = 2;
            ClockRecord inTestRecord = null;
            ClockRecord outTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = new DateTime(2021, 7, 5, 8, 00, 0),
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            Assert.ThrowsException<System.ArgumentNullException>(() => this.clockRecordController.ClockOut(inTestRecord, outTestRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenClockOutRecordNull()
        {
            int employeeId = 2;
            ClockRecord outTestRecord = null;
            ClockRecord inTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = new DateTime(2021, 7, 5, 8, 00, 0),
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            Assert.ThrowsException<System.ArgumentNullException>(() => this.clockRecordController.ClockOut(inTestRecord, outTestRecord));
        }
    }
}
