﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Token
{
    /// <summary>
    /// The access token and related Apis.
    /// </summary>
    public sealed class AccessToken : ApiObject
    {
        private HttpClient _tokenClient;
        private readonly string _apiClientId;
        private readonly string _apiClientSecret;

        #region Properties
        /// <summary>
        /// The access token.
        /// </summary>
        public string Token { get; internal set; }

        /// <summary>
        /// The access token type.
        /// </summary>
        public string Type => "Bearer";

        internal HttpClient TokenClient
        {
            get
            {
                var tokenClient = _tokenClient;
                if (tokenClient == null)
                {
                    tokenClient = new HttpClient(new EncompassRestClient.RetryHandler(Client, false))
                    {
                        Timeout = Client.Timeout
                    };
                    tokenClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{WebUtility.UrlEncode(_apiClientId)}:{WebUtility.UrlEncode(_apiClientSecret)}")));
                    tokenClient = Interlocked.CompareExchange(ref _tokenClient, tokenClient, null) ?? tokenClient;
                }
                return tokenClient;
            }
        }
        #endregion

        internal AccessToken(string apiClientId, string apiClientSecret, EncompassRestClient client)
            : base(client, "oauth2/v1/token")
        {
            _apiClientId = apiClientId;
            _apiClientSecret = apiClientSecret;
        }

        #region Public Methods
        /// <summary>
        /// Checks the status of the access token and retrieves the associated metadata.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<TokenIntrospectionResponse> IntrospectAsync(CancellationToken cancellationToken = default) => PostAsync("introspection", null, CreateAccessTokenContent(), nameof(IntrospectAsync), Token, cancellationToken, response => response.IsSuccessStatusCode ? response.Content.ReadAsAsync<TokenIntrospectionResponse>() : Task.FromResult<TokenIntrospectionResponse>(null), false);

        /// <summary>
        /// Checks the status of the access token and retrieves the associated metadata as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> IntrospectRawAsync(string queryString = null, CancellationToken cancellationToken = default) => PostAsync("introspection", queryString, CreateAccessTokenContent(), nameof(IntrospectRawAsync), Token, cancellationToken, response => response.IsSuccessStatusCode ? response.Content.ReadAsStringAsync() : Task.FromResult<string>(null), false);

        /// <summary>
        /// Revokes the access token.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> RevokeAsync(CancellationToken cancellationToken = default) => PostAsync("revocation", null, CreateAccessTokenContent(), nameof(RevokeAsync), Token, cancellationToken, IsSuccessStatusCodeFunc, false);

        /// <summary>
        /// Returns the string representation of the access token.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Type} {Token}";

        internal void Dispose() => _tokenClient?.Dispose();

        internal Task<string> GetTokenFromUserCredentialsAsync(string instanceId, string userId, string password, string methodName, CancellationToken cancellationToken) => GetTokenAsync(new[]
            {
                KeyValuePair.Create("grant_type", "password"),
                KeyValuePair.Create("username", $"{userId}@encompass:{instanceId}"),
                KeyValuePair.Create("password", password)
            }, methodName, cancellationToken);

        internal Task<string> GetTokenFromAuthorizationCodeAsync(string redirectUri, string authorizationCode, string methodName, CancellationToken cancellationToken) => GetTokenAsync(new[]
            {
                KeyValuePair.Create("grant_type", "authorization_code"),
                KeyValuePair.Create("redirect_uri", redirectUri),
                KeyValuePair.Create("code", authorizationCode)
            }, methodName, cancellationToken);

        private async Task<string> GetTokenAsync(IEnumerable<KeyValuePair<string, string>> nameValueCollection, string methodName, CancellationToken cancellationToken)
        {
            var tokenResponse = await PostAsync<TokenResponse>(null, null, new FormUrlEncodedContent(nameValueCollection), methodName, null, cancellationToken).ConfigureAwait(false);
            return tokenResponse.AccessToken;
        }

        private FormUrlEncodedContent CreateAccessTokenContent() => new FormUrlEncodedContent(new[] { KeyValuePair.Create("token", Token) });

        internal override HttpClient GetHttpClient() => TokenClient;

        [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy), ItemRequired = Required.Always)]
        private sealed class TokenResponse
        {
            public string AccessToken { get; set; }
        }
        #endregion
    }
}