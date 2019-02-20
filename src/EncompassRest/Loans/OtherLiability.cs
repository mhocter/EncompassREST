using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OtherLiability
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class OtherLiability : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _altId;
        private DirtyValue<string> _attention;
        private DirtyValue<StringEnumValue<Owner>> _borrowerType;
        private DirtyValue<EntityReference> _contact;
        private DirtyValue<DateTime?> _depositoryRequestDate;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<string> _holderAddressCity;
        private DirtyValue<string> _holderAddressPostalCode;
        private DirtyValue<StringEnumValue<State>> _holderAddressState;
        private DirtyValue<string> _holderAddressStreetLine1;
        private DirtyValue<string> _holderEmail;
        private DirtyValue<string> _holderFax;
        private DirtyValue<string> _holderName;
        private DirtyValue<string> _holderPhone;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<LiabilityOrExpenseType>> _liabilityOrExpenseType;
        private DirtyValue<decimal?> _monthlyPayment;
        private DirtyValue<string> _otherDescription;
        private DirtyValue<bool?> _printAttachmentIndicator;
        private DirtyValue<bool?> _printUserJobTitleIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;

        /// <summary>
        /// Other Liabilities ID [URLAROLNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// OtherLiability Attention
        /// </summary>
        public string Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Other Liabilities Borrower Type [URLAROLNN01]
        /// </summary>
        public StringEnumValue<Owner> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

        /// <summary>
        /// OtherLiability Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Depository Request Date [URLAROLNN98]
        /// </summary>
        public DateTime? DepositoryRequestDate { get => _depositoryRequestDate; set => SetField(ref _depositoryRequestDate, value); }

        /// <summary>
        /// OtherLiability EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Depository Attention City [URLAROLNN08]
        /// </summary>
        public string HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

        /// <summary>
        /// Depository Attention Zipcode [URLAROLNN10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

        /// <summary>
        /// Depository Attention State [URLAROLNN09]
        /// </summary>
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

        /// <summary>
        /// Depository Address [URLAROLNN07]
        /// </summary>
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

        /// <summary>
        /// Depository Email [URLAROLNN13]
        /// </summary>
        public string HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

        /// <summary>
        /// Depository Fax [URLAROLNN12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

        /// <summary>
        /// Depository Name [URLAROLNN05]
        /// </summary>
        public string HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// Depository Phone [URLAROLNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

        /// <summary>
        /// OtherLiability Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Other Liabilities Liability or Expense Type [URLAROLNN02]
        /// </summary>
        public StringEnumValue<LiabilityOrExpenseType> LiabilityOrExpenseType { get => _liabilityOrExpenseType; set => SetField(ref _liabilityOrExpenseType, value); }

        /// <summary>
        /// Other Liabilities Monthly Paymen [URLAROLNN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

        /// <summary>
        /// Other Liabilities Other Description [URLAROLNN04]
        /// </summary>
        public string OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

        /// <summary>
        /// Depository Print - See Attached Authorization [URLAROLNN18]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Depository Print User Job Title [URLAROLNN64]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Print user's job title\"}")]
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Depository Print User Name as Title [URLAROLNN15]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Depository From Title [URLAROLNN14]
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Depository From Fax [URLAROLNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Depository From Phone [URLAROLNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}