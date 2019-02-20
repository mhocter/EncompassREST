namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// CustomFieldsRights
    /// </summary>
    public sealed class CustomFieldsRights : ParentAccessRights
    {
        private CustomFieldsTab1Rights _customFieldsTab1;
        private CustomFieldsTab2Rights _customFieldsTab2;
        private CustomFieldsTab3Rights _customFieldsTab3;
        private CustomFieldsTab4Rights _customFieldsTab4;
        private CustomFieldsTab5Rights _customFieldsTab5;

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab1
        /// </summary>
        public CustomFieldsTab1Rights CustomFieldsTab1 { get => GetField(ref _customFieldsTab1); set => SetField(ref _customFieldsTab1, value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab2
        /// </summary>
        public CustomFieldsTab2Rights CustomFieldsTab2 { get => GetField(ref _customFieldsTab2); set => SetField(ref _customFieldsTab2, value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab3
        /// </summary>
        public CustomFieldsTab3Rights CustomFieldsTab3 { get => GetField(ref _customFieldsTab3); set => SetField(ref _customFieldsTab3, value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab4
        /// </summary>
        public CustomFieldsTab4Rights CustomFieldsTab4 { get => GetField(ref _customFieldsTab4); set => SetField(ref _customFieldsTab4, value); }

        /// <summary>
        /// CustomFieldsRights CustomFieldsTab5
        /// </summary>
        public CustomFieldsTab5Rights CustomFieldsTab5 { get => GetField(ref _customFieldsTab5); set => SetField(ref _customFieldsTab5, value); }
    }
}