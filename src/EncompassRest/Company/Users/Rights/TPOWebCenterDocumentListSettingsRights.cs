namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TPOWebCenterDocumentListSettingsRights
    /// </summary>
    public sealed class TPOWebCenterDocumentListSettingsRights : ParentAccessRights
    {
        private TPOWebCenterDocumentListSettingsEditDocumentRights _editDocument;

        /// <summary>
        /// TPOWebCenterDocumentListSettingsRights EditDocument
        /// </summary>
        public TPOWebCenterDocumentListSettingsEditDocumentRights EditDocument { get => GetField(ref _editDocument); set => SetField(ref _editDocument, value); }
    }
}