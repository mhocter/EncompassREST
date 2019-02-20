using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Shipping
    /// </summary>
    public sealed partial class Shipping : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _actualShipDate;
        private DirtyValue<string> _carrierName;
        private DirtyValue<decimal?> _downPaymentAmount;
        private DirtyValue<string> _id;
        private DirtyValue<DateTime?> _investorDeliveryDate;
        private DirtyValue<string> _packageTrackingNumber;
        private DirtyValue<string> _physicalFileStorageComments;
        private DirtyValue<string> _physicalFileStorageId;
        private DirtyValue<string> _physicalFileStorageLocation;
        private DirtyValue<string> _poolID;
        private DirtyValue<string> _poolNumber;
        private DirtyValue<string> _recordingNumber;
        private DirtyValue<string> _shipmentMethod;
        private DirtyValue<string> _shipperName;
        private DirtyList<ShippingContact> _shippingContacts;
        private DirtyValue<DateTime?> _targetDeliveryDate;

        /// <summary>
        /// Shipping Actual Shipping Date [2014]
        /// </summary>
        public DateTime? ActualShipDate { get => _actualShipDate; set => SetField(ref _actualShipDate, value); }

        /// <summary>
        /// Shipping Carrier Name [2017]
        /// </summary>
        public string CarrierName { get => _carrierName; set => SetField(ref _carrierName, value); }

        /// <summary>
        /// Shipping DownPaymentAmount
        /// </summary>
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => SetField(ref _downPaymentAmount, value); }

        /// <summary>
        /// Shipping Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Shipping Investor Delivery Date [2012]
        /// </summary>
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => SetField(ref _investorDeliveryDate, value); }

        /// <summary>
        /// Shipping Pkg Tracking Number [2018]
        /// </summary>
        public string PackageTrackingNumber { get => _packageTrackingNumber; set => SetField(ref _packageTrackingNumber, value); }

        /// <summary>
        /// Shipping File Storage Comments [2022]
        /// </summary>
        public string PhysicalFileStorageComments { get => _physicalFileStorageComments; set => SetField(ref _physicalFileStorageComments, value); }

        /// <summary>
        /// Shipping File Storage ID [2021]
        /// </summary>
        public string PhysicalFileStorageId { get => _physicalFileStorageId; set => SetField(ref _physicalFileStorageId, value); }

        /// <summary>
        /// Shipping File Storage Location [2020]
        /// </summary>
        public string PhysicalFileStorageLocation { get => _physicalFileStorageLocation; set => SetField(ref _physicalFileStorageLocation, value); }

        /// <summary>
        /// Shipping Pool ID [4020]
        /// </summary>
        public string PoolID { get => _poolID; set => SetField(ref _poolID, value); }

        /// <summary>
        /// Shipping Pool Number [4021]
        /// </summary>
        public string PoolNumber { get => _poolNumber; set => SetField(ref _poolNumber, value); }

        /// <summary>
        /// Shipping Recording Number [2015]
        /// </summary>
        public string RecordingNumber { get => _recordingNumber; set => SetField(ref _recordingNumber, value); }

        /// <summary>
        /// Shipping Shipment Method [2016]
        /// </summary>
        public string ShipmentMethod { get => _shipmentMethod; set => SetField(ref _shipmentMethod, value); }

        /// <summary>
        /// Shipping Shipper Name [2019]
        /// </summary>
        public string ShipperName { get => _shipperName; set => SetField(ref _shipperName, value); }

        /// <summary>
        /// Shipping ShippingContacts
        /// </summary>
        public IList<ShippingContact> ShippingContacts { get => GetField(ref _shippingContacts); set => SetField(ref _shippingContacts, value); }

        /// <summary>
        /// Shipping Target Delivery Date [2013]
        /// </summary>
        public DateTime? TargetDeliveryDate { get => _targetDeliveryDate; set => SetField(ref _targetDeliveryDate, value); }
    }
}