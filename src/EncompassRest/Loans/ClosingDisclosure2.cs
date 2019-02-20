using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure2
    /// </summary>
    public sealed partial class ClosingDisclosure2 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _borrowerClosingCostAtClosing;
        private DirtyValue<decimal?> _borrowerClosingCostBeforeClosing;
        private DirtyValue<decimal?> _closingCostLenderCredits;
        private DirtyValue<decimal?> _closingCostPaidByOthers;
        private DirtyValue<decimal?> _discloseLenderCredits;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _initialEscrowSubTotal;
        private DirtyValue<decimal?> _lastDisclosedLenderCredits;
        private DirtyValue<decimal?> _lastDisclosedLoanCosts;
        private DirtyValue<decimal?> _lastDisclosedOtherCosts;
        private DirtyValue<decimal?> _lCAtClosing;
        private DirtyValue<decimal?> _originationChargesSubTotal;
        private DirtyValue<decimal?> _otherSubTotal;
        private DirtyValue<decimal?> _prepaidsSubTotal;
        private DirtyValue<decimal?> _sellerClosingCostAtClosing;
        private DirtyValue<decimal?> _sellerClosingCostBeforeClosing;
        private DirtyValue<decimal?> _servicesDidNotShopSubTotal;
        private DirtyValue<decimal?> _servicesDidShopSubTotal;
        private DirtyValue<decimal?> _taxesGovermentFeesSubTotal;
        private DirtyValue<decimal?> _totalBorrowerPaidAtClosing;
        private DirtyValue<decimal?> _totalBorrowerPaidBeforeClosing;
        private DirtyValue<decimal?> _totalClosingCost;
        private DirtyValue<decimal?> _totalLoanCost;
        private DirtyValue<decimal?> _totalOtherCost;
        private DirtyValue<decimal?> _totalOtherCostAtClosing;
        private DirtyValue<decimal?> _totalOtherCostBeforeClosing;

        /// <summary>
        /// Closing disclosure - Borrower Paid Closing Cost At Closing [CD2.XBCCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BorrowerClosingCostAtClosing { get => _borrowerClosingCostAtClosing; set => SetField(ref _borrowerClosingCostAtClosing, value); }

        /// <summary>
        /// Closing disclosure - Borrower Paid Closing Cost Before Closing [CD2.XBCCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BorrowerClosingCostBeforeClosing { get => _borrowerClosingCostBeforeClosing; set => SetField(ref _borrowerClosingCostBeforeClosing, value); }

        /// <summary>
        /// Lender Credits [CD2.XSTLC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ClosingCostLenderCredits { get => _closingCostLenderCredits; set => SetField(ref _closingCostLenderCredits, value); }

        /// <summary>
        /// Closing disclosure - Closing Cost Paid by Others [CD2.XCCBO]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ClosingCostPaidByOthers { get => _closingCostPaidByOthers; set => SetField(ref _closingCostPaidByOthers, value); }

        /// <summary>
        /// Disclose Lender Credits applied [CD2.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscloseLenderCredits { get => _discloseLenderCredits; set => SetField(ref _discloseLenderCredits, value); }

        /// <summary>
        /// ClosingDisclosure2 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Closing disclosure - G. Initial Escrow Payment at Closing [CD2.XSTG]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialEscrowSubTotal { get => _initialEscrowSubTotal; set => SetField(ref _initialEscrowSubTotal, value); }

        /// <summary>
        /// CD Last Disclosed Lender Credits [CD2.XLDLCR]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LastDisclosedLenderCredits { get => _lastDisclosedLenderCredits; set => SetField(ref _lastDisclosedLenderCredits, value); }

        /// <summary>
        /// CD Last Disclosed Loan Costs [CD2.XLDLC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LastDisclosedLoanCosts { get => _lastDisclosedLoanCosts; set => SetField(ref _lastDisclosedLoanCosts, value); }

        /// <summary>
        /// CD Last Disclosed Other Costs [CD2.XLDOC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LastDisclosedOtherCosts { get => _lastDisclosedOtherCosts; set => SetField(ref _lastDisclosedOtherCosts, value); }

        /// <summary>
        /// Closing disclosure Lender Credits At closing [CD2.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LCAtClosing { get => _lCAtClosing; set => SetField(ref _lCAtClosing, value); }

        /// <summary>
        /// Closing disclosure - A. Origination Charges [CD2.XSTA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginationChargesSubTotal { get => _originationChargesSubTotal; set => SetField(ref _originationChargesSubTotal, value); }

        /// <summary>
        /// Closing disclosure - H. Other [CD2.XSTH]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherSubTotal { get => _otherSubTotal; set => SetField(ref _otherSubTotal, value); }

        /// <summary>
        /// Closing disclosure - F. Prepaids [CD2.XSTF]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PrepaidsSubTotal { get => _prepaidsSubTotal; set => SetField(ref _prepaidsSubTotal, value); }

        /// <summary>
        /// Closing disclosure - Seller Paid Closing Cost At Closing [CD2.XSCCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SellerClosingCostAtClosing { get => _sellerClosingCostAtClosing; set => SetField(ref _sellerClosingCostAtClosing, value); }

        /// <summary>
        /// Closing disclosure - Seller Paid Closing Cost Before Closing [CD2.XSCCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SellerClosingCostBeforeClosing { get => _sellerClosingCostBeforeClosing; set => SetField(ref _sellerClosingCostBeforeClosing, value); }

        /// <summary>
        /// Closing disclosure - B. Services Borrower Did Not Shop For [CD2.XSTB]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ServicesDidNotShopSubTotal { get => _servicesDidNotShopSubTotal; set => SetField(ref _servicesDidNotShopSubTotal, value); }

        /// <summary>
        /// Closing disclosure - C. Services Borrower Did Shop For [CD2.XSTC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ServicesDidShopSubTotal { get => _servicesDidShopSubTotal; set => SetField(ref _servicesDidShopSubTotal, value); }

        /// <summary>
        /// Closing disclosure - E.Taxes and Other Government Fees [CD2.XSTE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TaxesGovermentFeesSubTotal { get => _taxesGovermentFeesSubTotal; set => SetField(ref _taxesGovermentFeesSubTotal, value); }

        /// <summary>
        /// Closing disclosure - Total Borrower Paid At Closing [CD2.XLCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalBorrowerPaidAtClosing { get => _totalBorrowerPaidAtClosing; set => SetField(ref _totalBorrowerPaidAtClosing, value); }

        /// <summary>
        /// Closing disclosure - Total Borrower Paid Before Closing [CD2.XLCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalBorrowerPaidBeforeClosing { get => _totalBorrowerPaidBeforeClosing; set => SetField(ref _totalBorrowerPaidBeforeClosing, value); }

        /// <summary>
        /// Closing disclosure - J. Total Closing Costs (BORROWER Paid) [CD2.XSTJ]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalClosingCost { get => _totalClosingCost; set => SetField(ref _totalClosingCost, value); }

        /// <summary>
        /// Loan Costs [CD2.XSTD]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalLoanCost { get => _totalLoanCost; set => SetField(ref _totalLoanCost, value); }

        /// <summary>
        /// Other Costs [CD2.XSTI]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherCost { get => _totalOtherCost; set => SetField(ref _totalOtherCost, value); }

        /// <summary>
        /// Closing disclosure - Total Other Cost At Closing [CD2.XOCAC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherCostAtClosing { get => _totalOtherCostAtClosing; set => SetField(ref _totalOtherCostAtClosing, value); }

        /// <summary>
        /// Closing disclosure - Total Other Costs Before Closing [CD2.XOCBC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherCostBeforeClosing { get => _totalOtherCostBeforeClosing; set => SetField(ref _totalOtherCostBeforeClosing, value); }
    }
}