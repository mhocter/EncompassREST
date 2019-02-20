﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// LoanAttachment
    /// </summary>
    public sealed class LoanAttachment : DirtyExtensibleObject, IIdentifiable
    {
        private NeverSerializeValue<string> _attachmentId;
        private DirtyValue<DateTime?> _dateCreated;
        private DirtyValue<string> _createdBy;
        private DirtyValue<string> _createdByName;
        private DirtyValue<AttachmentCreateReason?> _createReason;
        private DirtyValue<AttachmentType?> _attachmentType;
        private DirtyValue<long?> _fileSize;
        private DirtyValue<bool?> _isActive;
        private DirtyList<PageImage> _pages;
        private DirtyValue<int?> _rotation;
        private DirtyValue<string> _title;
        private DirtyValue<string> _fileWithExtension;
        private DirtyValue<EntityReference> _document;
        private NeverSerializeValue<string> _mediaUrl;

        /// <summary>
        /// The unique identifier assigned to the attachment.
        /// </summary>
        public string AttachmentId { get => _attachmentId; set => SetField(ref _attachmentId, value); }

        /// <summary>
        /// Date the attachment or page annotation was created.
        /// </summary>
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        /// <summary>
        /// UserID of the user who created the attachment or annotation.
        /// </summary>
        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        /// <summary>
        /// User Name of the user who created the attachment.
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// The attachment create reason.
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentCreateReason? CreateReason { get => _createReason; set => SetField(ref _createReason, value); }

        /// <summary>
        /// LoanAttachment AttachmentType
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentType? AttachmentType { get => _attachmentType; set => SetField(ref _attachmentType, value); }

        /// <summary>
        /// The size of the image file.
        /// </summary>
        public long? FileSize { get => _fileSize; set => SetField(ref _fileSize, value); }

        /// <summary>
        /// Indicates the attachment is the active attachment on the document.
        /// </summary>
        public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }

        /// <summary>
        /// LoanAttachment Pages
        /// </summary>
        public IList<PageImage> Pages { get => GetField(ref _pages); set => SetField(ref _pages, value); }

        /// <summary>
        /// The rotation of the image.
        /// </summary>
        public int? Rotation { get => _rotation; set => SetField(ref _rotation, value); }

        /// <summary>
        /// The title of the attachment.
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// The attachment's file name and extension.
        /// </summary>
        public string FileWithExtension { get => _fileWithExtension; set => SetField(ref _fileWithExtension, value); }

        /// <summary>
        /// LoanAttachment Document
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Document { get => _document; set => SetField(ref _document, value); }

        /// <summary>
        /// The location or path where the media attachment is located.
        /// </summary>
        public string MediaUrl { get => _mediaUrl; set => SetField(ref _mediaUrl, value); }

        [IdPropertyName(nameof(AttachmentId))]
        string IIdentifiable.Id { get => AttachmentId; set => AttachmentId = value; }

        internal LoanAttachments Attachments;

        /// <summary>
        /// Loan attachment creation constructor.
        /// </summary>
        /// <param name="title">The title of the attachment.</param>
        /// <param name="fileWithExtension">The attachment's file name and extension.</param>
        /// <param name="createReason">The attachment create reason.</param>
        public LoanAttachment(string title, string fileWithExtension, AttachmentCreateReason createReason)
        {
            Preconditions.NotNullOrEmpty(title, nameof(title));
            Preconditions.NotNullOrEmpty(fileWithExtension, nameof(fileWithExtension));

            Title = title;
            FileWithExtension = fileWithExtension;
            CreateReason = createReason;
        }

        /// <summary>
        /// Loan attachment update constructor.
        /// </summary>
        /// <param name="attachmentId">The unique identifier assigned to the attachment.</param>
        public LoanAttachment(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            AttachmentId = attachmentId;
        }

        /// <summary>
        /// Loan attachment deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public LoanAttachment()
        {
        }

        /// <summary>
        /// Downloads the attachment's file contents as a byte array. Uses <see cref="MediaUrl"/> if populated from using the generateUrl option on getting the attachment, otherwise falls back to getting the download url first to get the file contents.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<byte[]> DownloadAsync(CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(AttachmentId, nameof(AttachmentId));

            var mediaUrl = MediaUrl;
            if (string.IsNullOrEmpty(mediaUrl))
            {
                mediaUrl = (await Attachments.GetDownloadAttachmentUrlAsync(AttachmentId, cancellationToken).ConfigureAwait(false)).MediaUrl;
                MediaUrl = mediaUrl;
            }
            return await Attachments.DownloadAttachmentFromMediaUrlAsync(mediaUrl, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Downloads the attachment's file contents as a stream. Uses <see cref="MediaUrl"/> if populated from using the generateUrl option on getting the attachment, otherwise falls back to getting the download url first to get the file contents.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<Stream> DownloadStreamAsync(CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(AttachmentId, nameof(AttachmentId));

            var mediaUrl = MediaUrl;
            if (string.IsNullOrEmpty(mediaUrl))
            {
                mediaUrl = (await Attachments.GetDownloadAttachmentUrlAsync(AttachmentId, cancellationToken).ConfigureAwait(false)).MediaUrl;
                MediaUrl = mediaUrl;
            }
            return await Attachments.DownloadAttachmentStreamFromMediaUrlAsync(mediaUrl, cancellationToken).ConfigureAwait(false);
        }
    }
}