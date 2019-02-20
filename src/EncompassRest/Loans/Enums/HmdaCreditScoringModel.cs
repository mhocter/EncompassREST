using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HmdaCreditScoringModel
    /// </summary>
    public enum HmdaCreditScoringModel
    {
        /// <summary>
        /// 1. Equifax Beacon 5.0
        /// </summary>
        [Description("1. Equifax Beacon 5.0")]
        [EnumMember(Value = "Equifax Beacon 5.0")]
        EquifaxBeacon50 = 0,
        /// <summary>
        /// 2. Experian Fair Isaac
        /// </summary>
        [Description("2. Experian Fair Isaac")]
        [EnumMember(Value = "Experian Fair Isaac")]
        ExperianFairIsaac = 1,
        /// <summary>
        /// 3. FICO Risk Score Classic 04
        /// </summary>
        [Description("3. FICO Risk Score Classic 04")]
        [EnumMember(Value = "FICO Risk Score Classic 04")]
        FICORiskScoreClassic04 = 2,
        /// <summary>
        /// 4. FICO Risk Score Classic 98
        /// </summary>
        [Description("4. FICO Risk Score Classic 98")]
        [EnumMember(Value = "FICO Risk Score Classic 98")]
        FICORiskScoreClassic98 = 3,
        /// <summary>
        /// 5. VantageScore 2.0
        /// </summary>
        [Description("5. VantageScore 2.0")]
        [EnumMember(Value = "VantageScore 2.0")]
        VantageScore20 = 4,
        /// <summary>
        /// 6. VantageScore 3.0
        /// </summary>
        [Description("6. VantageScore 3.0")]
        [EnumMember(Value = "VantageScore 3.0")]
        VantageScore30 = 5,
        /// <summary>
        /// 7. More than one credit scoring model
        /// </summary>
        [Description("7. More than one credit scoring model")]
        [EnumMember(Value = "More than one credit scoring model")]
        MoreThanOneCreditScoringModel = 6,
        /// <summary>
        /// 8. Other credit scoring model
        /// </summary>
        [Description("8. Other credit scoring model")]
        [EnumMember(Value = "Other credit scoring model")]
        OtherCreditScoringModel = 7,
        /// <summary>
        /// 9. Not applicable
        /// </summary>
        [Description("9. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 8,
        /// <summary>
        /// 1111 Partially Exempt
        /// </summary>
        [Description("1111 Partially Exempt")]
        [EnumMember(Value = "Partially Exempt")]
        PartiallyExempt = 9
    }
}