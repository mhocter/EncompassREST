using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PurchaseCredit
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class PurchaseCredit : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<PurchaseCreditType>> _purchaseCreditType;

        /// <summary>
        /// PurchaseCredit Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// PurchaseCredit Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PurchaseCredit PurchaseCreditType
        /// </summary>
        public StringEnumValue<PurchaseCreditType> PurchaseCreditType { get => _purchaseCreditType; set => SetField(ref _purchaseCreditType, value); }
    }
}