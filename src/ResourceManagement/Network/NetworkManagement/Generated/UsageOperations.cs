// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// Operations for listing usage.
    /// </summary>
    internal partial class UsageOperations : IServiceOperations<NetworkResourceProviderClient>, IUsageOperations
    {
        /// <summary>
        /// Initializes a new instance of the UsageOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal UsageOperations(NetworkResourceProviderClient client)
        {
            this._client = client;
        }
        
        private NetworkResourceProviderClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Network.NetworkResourceProviderClient.
        /// </summary>
        public NetworkResourceProviderClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Lists compute usages for a subscription.
        /// </summary>
        /// <param name='location'>
        /// Required. The location upon which resource usage is queried.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Usages operation response.
        /// </returns>
        public async Task<UsagesListResponse> ListAsync(string location, CancellationToken cancellationToken)
        {
            // Validate
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            if (location != null && location.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("location");
            }
            if (Regex.IsMatch(location, "^[-\\w\\._]+$") == false)
            {
                throw new ArgumentOutOfRangeException("location");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("location", location);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/";
            url = url + "Microsoft.Network";
            url = url + "/locations/";
            url = url + Uri.EscapeDataString(location);
            url = url + "/usages";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-05-01-preview");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    UsagesListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new UsagesListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    Usage usageInstance = new Usage();
                                    result.Usages.Add(usageInstance);
                                    
                                    JToken unitValue = valueValue["unit"];
                                    if (unitValue != null && unitValue.Type != JTokenType.Null)
                                    {
                                        string unitInstance = ((string)unitValue);
                                        usageInstance.Unit = unitInstance;
                                    }
                                    
                                    JToken currentValueValue = valueValue["currentValue"];
                                    if (currentValueValue != null && currentValueValue.Type != JTokenType.Null)
                                    {
                                        int currentValueInstance = ((int)currentValueValue);
                                        usageInstance.CurrentValue = currentValueInstance;
                                    }
                                    
                                    JToken limitValue = valueValue["limit"];
                                    if (limitValue != null && limitValue.Type != JTokenType.Null)
                                    {
                                        uint limitInstance = ((uint)limitValue);
                                        usageInstance.Limit = limitInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        UsageName nameInstance = new UsageName();
                                        usageInstance.Name = nameInstance;
                                        
                                        JToken valueValue2 = nameValue["value"];
                                        if (valueValue2 != null && valueValue2.Type != JTokenType.Null)
                                        {
                                            string valueInstance = ((string)valueValue2);
                                            nameInstance.Value = valueInstance;
                                        }
                                        
                                        JToken localizedValueValue = nameValue["localizedValue"];
                                        if (localizedValueValue != null && localizedValueValue.Type != JTokenType.Null)
                                        {
                                            string localizedValueInstance = ((string)localizedValueValue);
                                            nameInstance.LocalizedValue = localizedValueInstance;
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
