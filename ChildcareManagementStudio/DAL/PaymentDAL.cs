﻿using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing payment information from the child care database.
    /// </summary>
    public class PaymentDAL
    {
        private AccountHolderDAL accountHolderDAL;

        /// <summary>
        /// Constructor for the PaymentDAL class.
        /// </summary>
        public PaymentDAL()
        {
            accountHolderDAL = new AccountHolderDAL();
        }

        /// <summary>
        /// Method that returns all of the payments made by the specified account holder.
        /// </summary>
        /// <param name="accountHolder">The account holder in question.</param>
        /// <returns>A list of Payment objects representing all of the payments made by the specified account holder.</returns>
        public List<Payment> GetPayments(AccountHolder accountHolder)
        {
            if (accountHolder == null)
            {
                throw new ArgumentNullException("accountHolder", "The account holder cannot be null.");
            }

            List<Payment> payments = new List<Payment>();

            string selectStatement =
                "SELECT paymentId, date, amount, type " +
                "FROM Payment " +
                "WHERE accountHolderId = $accountHolderId " +
                "ORDER BY date";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$accountHolderId", accountHolder.AccountHolderId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int paymentIdOrdinal = reader.GetOrdinal("paymentId");
                        int dateOrdinal = reader.GetOrdinal("date");
                        int amountOrdinal = reader.GetOrdinal("amount");
                        int typeOrdinal = reader.GetOrdinal("type");
                        while (reader.Read())
                        {
                            int paymentId = reader.GetInt32(paymentIdOrdinal);
                            DateTime date = reader.GetDateTime(dateOrdinal);
                            double amount = reader.GetDouble(amountOrdinal);
                            string typeString = reader.GetString(typeOrdinal).Replace(" ", "");
                            PaymentType paymentType = (PaymentType) Enum.Parse(typeof(PaymentType), typeString);

                            Payment currentPayment = new Payment
                            {
                                AccountHolder = accountHolder,
                                PaymentId = paymentId,
                                PaymentDate = date,
                                Amount = amount,
                                PaymentType = paymentType
                            };

                            payments.Add(currentPayment);
                        }
                    }
                }
            }

            return payments;
        }

        /// <summary>
        /// Method that adds a payment record to the database.
        /// </summary>
        /// <param name="payment">The payment being added.</param>
        public void AddPayment(Payment payment)
        {
            if (payment.PaymentId != default)
            {
                throw new ArgumentNullException("payment", "The payment cannot be null.");
            }

            if (payment.PaymentId != default)
            {
                throw new ArgumentException("The PaymentId property cannot be filled out because it will be assigned by the database.", "payment");
            }

            string paymentTypeString;
            if (payment.PaymentType == PaymentType.CreditCard)
            {
                paymentTypeString = "Credit Card";
            }
            else
            {
                paymentTypeString = payment.PaymentType.ToString();
            }

            string insertStatement =
                "INSERT INTO Payment (accountHolderId, date, amount, type) " +
                "VALUES ($accountHolderId, $date, $amount, $type)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$accountHolderId", payment.AccountHolder.AccountHolderId);
                    insertCommand.Parameters.AddWithValue("$date", payment.PaymentDate.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("$amount", payment.Amount);
                    insertCommand.Parameters.AddWithValue("$type", paymentTypeString);
                    insertCommand.ExecuteNonQuery();
                }

                using (SqliteCommand selectCommand = new SqliteCommand("SELECT last_insert_rowid()", connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            payment.PaymentId = reader.GetInt32(0);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method that returns a list of all the payments in the database.
        /// </summary>
        /// <returns>A list of all the payments in the database.</returns>
        public List<Payment> GetAllPayments()
        {
            List<Payment> payments = new List<Payment>();

            string selectStatement =
                "SELECT paymentId, accountHolderId, date, amount, type " +
                "FROM Payment " +
                "ORDER BY date";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int paymentIdOrdinal = reader.GetOrdinal("paymentId");
                        int accountHolderIdOrdinal = reader.GetOrdinal("accountHolderId");
                        int dateOrdinal = reader.GetOrdinal("date");
                        int amountOrdinal = reader.GetOrdinal("amount");
                        int typeOrdinal = reader.GetOrdinal("type");
                        while (reader.Read())
                        {
                            int paymentId = reader.GetInt32(paymentIdOrdinal);
                            int accountHolderId = reader.GetInt32(accountHolderIdOrdinal);
                            DateTime date = reader.GetDateTime(dateOrdinal);
                            double amount = reader.GetDouble(amountOrdinal);
                            string typeString = reader.GetString(typeOrdinal).Replace(" ", "");
                            PaymentType paymentType = (PaymentType)Enum.Parse(typeof(PaymentType), typeString);
                            AccountHolder accountHolder = accountHolderDAL.GetAccountHolder(accountHolderId);

                            Payment currentPayment = new Payment
                            {
                                AccountHolder = accountHolder,
                                PaymentId = paymentId,
                                PaymentDate = date,
                                Amount = amount,
                                PaymentType = paymentType
                            };

                            payments.Add(currentPayment);
                        }
                    }
                }
            }

            return payments;
        }

        /// <summary>
        /// Method that deletes a payment from the database.
        /// </summary>
        /// <param name="payment">The payment being deleted.</param>
        public void DeletePayment(Payment payment)
        {
            string deleteStatement =
                "DELETE FROM Payment " +
                "WHERE paymentId = $paymentId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand deleteCommand = new SqliteCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("$paymentId", payment.PaymentId);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}