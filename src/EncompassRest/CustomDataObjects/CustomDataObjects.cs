﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.CustomDataObjects
{
    /// <summary>
    /// Base Custom Data Objects Apis.
    /// </summary>
    public abstract class CustomDataObjects : ApiObject
    {
        internal CustomDataObjects(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        /// <summary>
        /// Provides a list of names of custom data objects.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<string>> GetCustomDataObjectsAsync(CancellationToken cancellationToken = default) => GetAsync<List<string>>(null, null, nameof(GetCustomDataObjectsAsync), null, cancellationToken);

        /// <summary>
        /// Provides a list of names of custom data objects as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetCustomDataObjectsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetCustomDataObjectsRawAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves the contents of a custom data object. Contents are retrieved as a Base64 string.
        /// </summary>
        /// <param name="objectName">The name of the custom data object to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<CustomDataObject> GetCustomDataObjectAsync(string objectName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return GetAsync<CustomDataObject>(objectName, null, nameof(GetCustomDataObjectAsync), objectName, cancellationToken);
        }

        /// <summary>
        /// Retrieves the contents of a custom data object as raw json. Contents are retrieved as a Base64 string.
        /// </summary>
        /// <param name="objectName">The name of the custom data object to retrieve.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetCustomDataObjectRawAsync(string objectName, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return GetRawAsync(objectName, queryString, nameof(GetCustomDataObjectRawAsync), objectName, cancellationToken);
        }

        /// <summary>
        /// Creates or replaces a custom data object.
        /// </summary>
        /// <param name="cdo">The custom data object to create or replace.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task CreateOrReplaceCustomDataObjectAsync(CustomDataObject cdo, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(cdo, nameof(cdo));
            Preconditions.NotNullOrEmpty(cdo.Name, $"{nameof(cdo)}.{nameof(cdo.Name)}");

            return PutAsync(cdo.Name, null, JsonStreamContent.Create(cdo), nameof(CreateOrReplaceCustomDataObjectAsync), cdo.Name, cancellationToken);
        }

        /// <summary>
        /// Creates or replaces a custom data object from raw json.
        /// </summary>
        /// <param name="objectName">Name to assign to the custom data object. Or, the name of an existing custom data object to replace.</param>
        /// <param name="cdo">The custom data object to create or replace as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateOrReplaceCustomDataObjectRawAsync(string objectName, string cdo, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));
            Preconditions.NotNullOrEmpty(cdo, nameof(cdo));

            return PutRawAsync(objectName, queryString, new JsonStringContent(cdo), nameof(CreateOrReplaceCustomDataObjectRawAsync), objectName, cancellationToken);
        }

        /// <summary>
        /// Removes a custom data object.
        /// </summary>
        /// <param name="objectName">Name of the custom data object to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteCustomDataObjectAsync(string objectName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return DeleteAsync(objectName, null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified custom data object. This call adds the data provided in the body to the end of the dataObject.
        /// </summary>
        /// <param name="cdo">The custom data object to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, CancellationToken cancellationToken = default) => AppendToCustomDataObjectAsync(cdo, false, cancellationToken);

        /// <summary>
        /// Updates the specified custom data object. This call adds the data provided in the body to the end of the dataObject. Optionally populates the custom data object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="cdo">The custom data object to update.</param>
        /// <param name="populate">Indicates if the custom data object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(cdo, nameof(cdo));
            Preconditions.NotNullOrEmpty(cdo.Name, $"{nameof(cdo)}.{nameof(cdo.Name)}");

            return PatchPopulateDirtyAsync(cdo.Name, JsonStreamContent.Create(cdo), nameof(AppendToCustomDataObjectAsync), cdo.Name, cdo, populate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified custom data object from raw json. This call adds the data provided in the body to the end of the dataObject.
        /// </summary>
        /// <param name="objectName">Name of the custom data object to update.</param>
        /// <param name="cdo">The custom data object to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));
            Preconditions.NotNullOrEmpty(cdo, nameof(cdo));

            return PatchRawAsync(objectName, queryString, new JsonStringContent(cdo), nameof(AppendToCustomDataObjectRawAsync), objectName, cancellationToken);
        }
    }
}