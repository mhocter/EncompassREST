using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PipelineAndLoansRights
    /// </summary>
    public sealed class PipelineAndLoansRights : ParentAccessRights
    {
        private AccessToFeesRights _accessToFees;
        private AccessToProductPricingRights _accessToProductPricing;
        private DirtyValue<bool?> _generateDisclosures;
        private DirtyValue<bool?> _submitForPurchase;
        private DirtyValue<bool?> _viewPurchaseAdvice;
        private DirtyValue<bool?> _viewMessages;

        /// <summary>
        /// PipelineAndLoansRights AccessToFees
        /// </summary>
        public AccessToFeesRights AccessToFees { get => GetField(ref _accessToFees); set => SetField(ref _accessToFees, value); }

        /// <summary>
        /// PipelineAndLoansRights AccessToProductPricing
        /// </summary>
        [JsonProperty("accessToProduct&Pricing")]
        public AccessToProductPricingRights AccessToProductPricing { get => GetField(ref _accessToProductPricing); set => SetField(ref _accessToProductPricing, value); }

        /// <summary>
        /// PipelineAndLoansRights GenerateDisclosures
        /// </summary>
        public bool? GenerateDisclosures { get => _generateDisclosures; set => SetField(ref _generateDisclosures, value); }

        /// <summary>
        /// PipelineAndLoansRights SubmitForPurchase
        /// </summary>
        public bool? SubmitForPurchase { get => _submitForPurchase; set => SetField(ref _submitForPurchase, value); }

        /// <summary>
        /// PipelineAndLoansRights ViewPurchaseAdvice
        /// </summary>
        [JsonProperty("view Purchase Advice")]
        public bool? ViewPurchaseAdvice { get => _viewPurchaseAdvice; set => SetField(ref _viewPurchaseAdvice, value); }

        /// <summary>
        /// PipelineAndLoansRights ViewMessages
        /// </summary>
        public bool? ViewMessages { get => _viewMessages; set => SetField(ref _viewMessages, value); }
    }
}