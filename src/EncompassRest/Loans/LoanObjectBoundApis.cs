﻿namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Apis with optional support to reflect Api calls to the associated loan object.
    /// </summary>
    public sealed class LoanObjectBoundApis : LoanApis
    {
        /// <summary>
        /// The associated loan object.
        /// </summary>
        public Loan Loan { get; }

        /// <summary>
        /// Indicates if Api calls should reflect in the associated loan object.
        /// </summary>
        public bool ReflectToLoanObject { get; set; }

        internal LoanObjectBoundApis(EncompassRestClient client, Loan loan)
            : base(client, loan.EncompassId)
        {
            Loan = loan;
        }
    }
}