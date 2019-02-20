namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ExternalSettingsRights
    /// </summary>
    public sealed class ExternalSettingsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _allTPOContactInformation;
        private CompanyDetailsRights _companyDetails;
        private DirtyValue<bool?> _tPOConnectSiteManagement;
        private DirtyValue<bool?> _tPOCustomFields;
        private DirtyValue<bool?> _tPODisclosureSettings;
        private TPOFeesRights _tPOFees;
        private DirtyValue<bool?> _tPOGlobalLenderContacts;
        private DirtyValue<bool?> _tPOReassignment;
        private DirtyValue<bool?> _tPOSettings;
        private TPOWebCenterDocumentListSettingsRights _tPOWebCenterDocumentListSettings;

        /// <summary>
        /// ExternalSettingsRights AllTPOContactInformation
        /// </summary>
        public bool? AllTPOContactInformation { get => _allTPOContactInformation; set => SetField(ref _allTPOContactInformation, value); }

        /// <summary>
        /// ExternalSettingsRights CompanyDetails
        /// </summary>
        public CompanyDetailsRights CompanyDetails { get => GetField(ref _companyDetails); set => SetField(ref _companyDetails, value); }

        /// <summary>
        /// ExternalSettingsRights TPOConnectSiteManagement
        /// </summary>
        public bool? TPOConnectSiteManagement { get => _tPOConnectSiteManagement; set => SetField(ref _tPOConnectSiteManagement, value); }

        /// <summary>
        /// ExternalSettingsRights TPOCustomFields
        /// </summary>
        public bool? TPOCustomFields { get => _tPOCustomFields; set => SetField(ref _tPOCustomFields, value); }

        /// <summary>
        /// ExternalSettingsRights TPODisclosureSettings
        /// </summary>
        public bool? TPODisclosureSettings { get => _tPODisclosureSettings; set => SetField(ref _tPODisclosureSettings, value); }

        /// <summary>
        /// ExternalSettingsRights TPOFees
        /// </summary>
        public TPOFeesRights TPOFees { get => GetField(ref _tPOFees); set => SetField(ref _tPOFees, value); }

        /// <summary>
        /// ExternalSettingsRights TPOGlobalLenderContacts
        /// </summary>
        public bool? TPOGlobalLenderContacts { get => _tPOGlobalLenderContacts; set => SetField(ref _tPOGlobalLenderContacts, value); }

        /// <summary>
        /// ExternalSettingsRights TPOReassignment
        /// </summary>
        public bool? TPOReassignment { get => _tPOReassignment; set => SetField(ref _tPOReassignment, value); }

        /// <summary>
        /// ExternalSettingsRights TPOSettings
        /// </summary>
        public bool? TPOSettings { get => _tPOSettings; set => SetField(ref _tPOSettings, value); }

        /// <summary>
        /// ExternalSettingsRights TPOWebCenterDocumentListSettings
        /// </summary>
        public TPOWebCenterDocumentListSettingsRights TPOWebCenterDocumentListSettings { get => GetField(ref _tPOWebCenterDocumentListSettings); set => SetField(ref _tPOWebCenterDocumentListSettings, value); }
    }
}