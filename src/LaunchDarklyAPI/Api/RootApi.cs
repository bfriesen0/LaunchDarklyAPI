/* 
 * LaunchDarkly REST API
 *
 * Build custom integrations with the LaunchDarkly REST API
 *
 * OpenAPI spec version: 2.0.3
 * Contact: support@launchdarkly.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace LaunchDarklyAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRootApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </remarks>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Links</returns>
        Links GetRoot ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </remarks>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Links</returns>
        ApiResponse<Links> GetRootWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </remarks>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Links</returns>
        System.Threading.Tasks.Task<Links> GetRootAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </remarks>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Links)</returns>
        System.Threading.Tasks.Task<ApiResponse<Links>> GetRootAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RootApi : IRootApi
    {
        private LaunchDarklyAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RootApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RootApi(String basePath)
        {
            this.Configuration = new LaunchDarklyAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = LaunchDarklyAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RootApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RootApi(LaunchDarklyAPI.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = LaunchDarklyAPI.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = LaunchDarklyAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public LaunchDarklyAPI.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public LaunchDarklyAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </summary>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Links</returns>
        public Links GetRoot ()
        {
             ApiResponse<Links> localVarResponse = GetRootWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </summary>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Links</returns>
        public ApiResponse< Links > GetRootWithHttpInfo ()
        {

            var localVarPath = "/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoot", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Links>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Links) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Links)));
        }

        /// <summary>
        ///  You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </summary>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Links</returns>
        public async System.Threading.Tasks.Task<Links> GetRootAsync ()
        {
             ApiResponse<Links> localVarResponse = await GetRootAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  You can issue a GET request to the root resource to find all of the resource categories supported by the API.
        /// </summary>
        /// <exception cref="LaunchDarklyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Links)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Links>> GetRootAsyncWithHttpInfo ()
        {

            var localVarPath = "/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRoot", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Links>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Links) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Links)));
        }

    }
}
