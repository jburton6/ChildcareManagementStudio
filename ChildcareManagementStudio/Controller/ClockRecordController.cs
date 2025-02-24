﻿using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    public class ClockRecordController
    {
        private readonly ClockRecordDAL clockRecordDAL;

        public ClockRecordController()
        {
            this.clockRecordDAL = new ClockRecordDAL();
        }

        /// <summary>
        /// Returns a list of ClockRecord objects matching the provided employeeId
        /// </summary>
        /// <param name="employeeId">theemployeeId for which to return a list of ClockRecord objects</param>
        /// <returns></returns>
        public List<ClockRecord> GetAllClockRecordsForEmployee(int employeeId)
        {
            return this.clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
        }

        /// <summary>
        /// Returns a ClockRecord object matching the provided employeeId with 
        /// empty clock-out time or null if not open record exists
        /// </summary>
        /// <param name="employeeId">theemployeeId for which to return a list of ClockRecord objects</param>
        /// <returns>a ClockRecord object matching the provided employeeId with 
        /// empty clock-out time or null if not open record exists</returns>
        public ClockRecord GetOpenClockRecord(int employeeId)
        {
            return this.clockRecordDAL.GetOpenClockRecord(employeeId);
        }

        /// <summary>
        /// Adds a new ClockRecord entry into the DAL with the clocked-in date time for an employee
        /// </summary>
        /// <param name="clockRecord">the clock record object to insert into the DB</param>
        public void ClockIn(ClockRecord clockRecord)
        {
             this.clockRecordDAL.ClockIn(clockRecord);
        }

        /// <summary>
        /// Edit ClockRecord in DB to add OutDateTime
        /// </summary>
        /// <param name="clockInRecord">original ClockRecord object</param>
        /// <param name="clockOutRecord">revised ClockRecord object</param>
        public void ClockOut(ClockRecord clockInRecord, ClockRecord clockOutRecord)
        {
            this.clockRecordDAL.ClockOut(clockInRecord, clockOutRecord);
        }

        /// <summary>
        /// Method used to delete record.  This is primarily used in test classes to preserve
        /// the DB state for subsequent tests
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="certificationRecord"></param>
        public void DeleteClockRecord(ClockRecord clockRecord)
        {
            this.clockRecordDAL.DeleteClockRecord(clockRecord);
        }

    }
}
