﻿using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing tuition rate records from the database.
    /// </summary>
    public class TuitionRateRecordDAL
    {
        private readonly AccountHolderDAL accountHolderDAL;
        private readonly StudentDAL studentDAL;

        /// <summary>
        /// Constructor for the TuitionRateRecordDAL class.
        /// </summary>
        public TuitionRateRecordDAL()
        {
            accountHolderDAL = new AccountHolderDAL();
            studentDAL = new StudentDAL();
        }

        /// <summary>
        /// Method that returns all of the tuition rate records associated with the specified student.
        /// </summary>
        /// <param name="student">The student being searched for.</param>
        /// <returns>All of the tuition rate records associated with the specified student.</returns>
        public List<TuitionRateRecord> GetTuitionRateRecords(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "The student cannot be null.");
            }

            List<TuitionRateRecord> tuitionRateRecords = new List<TuitionRateRecord>();

            string selectStatement =
                "SELECT startDate, endDate, dailyRate, accountHolderId " +
                "FROM TuitionRateRecord " +
                "WHERE studentId = $studentId " +
                "ORDER BY startDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$studentId", student.StudentId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int startDateOrdinal = reader.GetOrdinal("startDate");
                        int endDateOrdinal = reader.GetOrdinal("endDate");
                        int dailyRateOrdinal = reader.GetOrdinal("dailyRate");
                        int accountHolderIdOrdinal = reader.GetOrdinal("accountHolderId");
                        while (reader.Read())
                        {
                            DateTime endDate = new DateTime();
                            DateTime startDate = reader.GetDateTime(startDateOrdinal);
                            if (!reader.IsDBNull(endDateOrdinal)) { endDate = reader.GetDateTime(endDateOrdinal); }
                            double dailyRate = reader.GetDouble(dailyRateOrdinal);
                            int accountHolderId = reader.GetInt32(accountHolderIdOrdinal);

                            AccountHolder accountHolder = accountHolderDAL.GetAccountHolder(accountHolderId);

                            TuitionRateRecord currentTuitionRateRecord = new TuitionRateRecord
                            {
                                AccountHolder = accountHolder,
                                Student = student,
                                StartDate = startDate,
                                DailyRate = dailyRate
                            };

                            if (!reader.IsDBNull(endDateOrdinal)) { currentTuitionRateRecord.EndDate = endDate; }

                            tuitionRateRecords.Add(currentTuitionRateRecord);
                        }
                    }
                }
            }

            return tuitionRateRecords;
        }

        /// <summary>
        /// Method that returns all of the tuition rate records associated with the specified account holder.
        /// </summary>
        /// <param name="accountHolder">The account holder being searched for.</param>
        /// <returns>All of the tuition rate records associated with the specified account holder.</returns>
        public List<TuitionRateRecord> GetTuitionRateRecords(AccountHolder accountHolder)
        {
            if (accountHolder == null)
            {
                throw new ArgumentNullException("accountHolder", "The account holder cannot be null.");
            }

            List<TuitionRateRecord> tuitionRateRecords = new List<TuitionRateRecord>();

            string selectStatement =
                "SELECT startDate, endDate, dailyRate, studentId " +
                "FROM TuitionRateRecord " +
                "WHERE accountHolderId = $accountHolderId " +
                "ORDER BY startDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$accountHolderId", accountHolder.AccountHolderId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int startDateOrdinal = reader.GetOrdinal("startDate");
                        int endDateOrdinal = reader.GetOrdinal("endDate");
                        int dailyRateOrdinal = reader.GetOrdinal("dailyRate");
                        int studentIdOrdinal = reader.GetOrdinal("studentId");
                        while (reader.Read())
                        {
                            DateTime endDate = new DateTime();
                            DateTime startDate = reader.GetDateTime(startDateOrdinal);
                            if (!reader.IsDBNull(endDateOrdinal)) { endDate = reader.GetDateTime(endDateOrdinal); }
                            double dailyRate = reader.GetDouble(dailyRateOrdinal);
                            int studentId = reader.GetInt32(studentIdOrdinal);

                            Student student = studentDAL.GetStudent(studentId);

                            TuitionRateRecord currentTuitionRateRecord = new TuitionRateRecord
                            {
                                AccountHolder = accountHolder,
                                Student = student,
                                StartDate = startDate,
                                DailyRate = dailyRate
                            };

                            if (!reader.IsDBNull(endDateOrdinal)) { currentTuitionRateRecord.EndDate = endDate; }

                            tuitionRateRecords.Add(currentTuitionRateRecord);
                        }
                    }
                }
            }

            return tuitionRateRecords;
        }

        /// <summary>
        /// Method that returns all of the tuition rate records in the database.
        /// </summary>
        /// <returns>All of the tuition rate records in the database.</returns>
        public List<TuitionRateRecord> GetAllTuitionRateRecords()
        {
            List<TuitionRateRecord> tuitionRateRecords = new List<TuitionRateRecord>();

            string selectStatement =
                "SELECT studentId, startDate, endDate, dailyRate, accountHolderId " +
                "FROM TuitionRateRecord " +
                "ORDER BY startDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int studentIdOrdinal = reader.GetOrdinal("studentId");
                        int startDateOrdinal = reader.GetOrdinal("startDate");
                        int endDateOrdinal = reader.GetOrdinal("endDate");
                        int dailyRateOrdinal = reader.GetOrdinal("dailyRate");
                        int accountHolderIdOrdinal = reader.GetOrdinal("accountHolderId");
                        while (reader.Read())
                        {
                            DateTime endDate = new DateTime();
                            int studentId = reader.GetInt32(studentIdOrdinal);
                            DateTime startDate = reader.GetDateTime(startDateOrdinal);
                            if (!reader.IsDBNull(endDateOrdinal)) { endDate = reader.GetDateTime(endDateOrdinal); }
                            double dailyRate = reader.GetDouble(dailyRateOrdinal);
                            int accountHolderId = reader.GetInt32(accountHolderIdOrdinal);

                            AccountHolder accountHolder = accountHolderDAL.GetAccountHolder(accountHolderId);
                            Student student = studentDAL.GetStudent(studentId);

                            TuitionRateRecord currentTuitionRateRecord = new TuitionRateRecord
                            {
                                AccountHolder = accountHolder,
                                Student = student,
                                StartDate = startDate,
                                DailyRate = dailyRate
                            };

                            if (!reader.IsDBNull(endDateOrdinal)) { currentTuitionRateRecord.EndDate = endDate; }

                            tuitionRateRecords.Add(currentTuitionRateRecord);
                        }
                    }
                }
            }

            return tuitionRateRecords;
        }
    }
}