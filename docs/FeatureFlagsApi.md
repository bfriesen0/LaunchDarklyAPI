# LaunchDarklyAPI.Api.FeatureFlagsApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFeatureFlag**](FeatureFlagsApi.md#deletefeatureflag) | **DELETE** /flags/{projectKey}/{featureFlagKey} | Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.
[**GetFeatureFlag**](FeatureFlagsApi.md#getfeatureflag) | **GET** /flags/{projectKey}/{featureFlagKey} | Get a single feature flag by key.
[**GetFeatureFlagStatus**](FeatureFlagsApi.md#getfeatureflagstatus) | **GET** /flag-statuses/{projectKey}/{environmentKey}/{featureFlagKey} | Get the status for a particular feature flag.
[**GetFeatureFlagStatuses**](FeatureFlagsApi.md#getfeatureflagstatuses) | **GET** /flag-statuses/{projectKey}/{environmentKey} | Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.
[**GetFeatureFlags**](FeatureFlagsApi.md#getfeatureflags) | **GET** /flags/{projectKey} | Get a list of all features in the given project.
[**PatchFeatureFlag**](FeatureFlagsApi.md#patchfeatureflag) | **PATCH** /flags/{projectKey}/{featureFlagKey} | Perform a partial update to a feature.
[**PostFeatureFlag**](FeatureFlagsApi.md#postfeatureflag) | **POST** /flags/{projectKey} | Creates a new feature flag.


<a name="deletefeatureflag"></a>
# **DeleteFeatureFlag**
> void DeleteFeatureFlag (string projectKey, string featureFlagKey)

Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class DeleteFeatureFlagExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.

            try
            {
                // Delete a feature flag in all environments. Be careful- - only delete feature flags that are no longer being used by your application.
                apiInstance.DeleteFeatureFlag(projectKey, featureFlagKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.DeleteFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflag"></a>
# **GetFeatureFlag**
> FeatureFlag GetFeatureFlag (string projectKey, string featureFlagKey, string env = null)

Get a single feature flag by key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetFeatureFlagExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var env = env_example;  // string | By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env=production will restrict the returned configurations to just your production environment. (optional) 

            try
            {
                // Get a single feature flag by key.
                FeatureFlag result = apiInstance.GetFeatureFlag(projectKey, featureFlagKey, env);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **env** | **string**| By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;production will restrict the returned configurations to just your production environment. | [optional] 

### Return type

[**FeatureFlag**](FeatureFlag.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagstatus"></a>
# **GetFeatureFlagStatus**
> FeatureFlagStatus GetFeatureFlagStatus (string projectKey, string environmentKey, string featureFlagKey)

Get the status for a particular feature flag.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetFeatureFlagStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.

            try
            {
                // Get the status for a particular feature flag.
                FeatureFlagStatus result = apiInstance.GetFeatureFlagStatus(projectKey, environmentKey, featureFlagKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 

### Return type

[**FeatureFlagStatus**](FeatureFlagStatus.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflagstatuses"></a>
# **GetFeatureFlagStatuses**
> FeatureFlagStatuses GetFeatureFlagStatuses (string projectKey, string environmentKey)

Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetFeatureFlagStatusesExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var environmentKey = environmentKey_example;  // string | The environment key, used to tie together flag configuration and users under one environment so they can be managed together.

            try
            {
                // Get a list of statuses for all feature flags. The status includes the last time the feature flag was requested, as well as the state of the flag.
                FeatureFlagStatuses result = apiInstance.GetFeatureFlagStatuses(projectKey, environmentKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlagStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **environmentKey** | **string**| The environment key, used to tie together flag configuration and users under one environment so they can be managed together. | 

### Return type

[**FeatureFlagStatuses**](FeatureFlagStatuses.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeatureflags"></a>
# **GetFeatureFlags**
> FeatureFlags GetFeatureFlags (string projectKey, string env = null, string tag = null)

Get a list of all features in the given project.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetFeatureFlagsExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var env = env_example;  // string | By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env=production will restrict the returned configurations to just your production environment. (optional) 
            var tag = tag_example;  // string | Filter by tag. A tag can be used to group flags across projects. (optional) 

            try
            {
                // Get a list of all features in the given project.
                FeatureFlags result = apiInstance.GetFeatureFlags(projectKey, env, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.GetFeatureFlags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **env** | **string**| By default, each feature will include configurations for each environment. You can filter environments with the env query parameter. For example, setting env&#x3D;production will restrict the returned configurations to just your production environment. | [optional] 
 **tag** | **string**| Filter by tag. A tag can be used to group flags across projects. | [optional] 

### Return type

[**FeatureFlags**](FeatureFlags.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchfeatureflag"></a>
# **PatchFeatureFlag**
> FeatureFlag PatchFeatureFlag (string projectKey, string featureFlagKey, PatchComment patchComment)

Perform a partial update to a feature.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PatchFeatureFlagExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagKey = featureFlagKey_example;  // string | The feature flag's key. The key identifies the flag in your code.
            var patchComment = new PatchComment(); // PatchComment | Requires a JSON Patch representation of the desired changes to the project, and an optional comment. 'http://jsonpatch.com/' Feature flag patches also support JSON Merge Patch format. 'https://tools.ietf.org/html/rfc7386' The addition of comments is also supported.

            try
            {
                // Perform a partial update to a feature.
                FeatureFlag result = apiInstance.PatchFeatureFlag(projectKey, featureFlagKey, patchComment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PatchFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagKey** | **string**| The feature flag&#39;s key. The key identifies the flag in your code. | 
 **patchComment** | [**PatchComment**](PatchComment.md)| Requires a JSON Patch representation of the desired changes to the project, and an optional comment. &#39;http://jsonpatch.com/&#39; Feature flag patches also support JSON Merge Patch format. &#39;https://tools.ietf.org/html/rfc7386&#39; The addition of comments is also supported. | 

### Return type

[**FeatureFlag**](FeatureFlag.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeatureflag"></a>
# **PostFeatureFlag**
> void PostFeatureFlag (string projectKey, FeatureFlagBody featureFlagBody)

Creates a new feature flag.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PostFeatureFlagExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FeatureFlagsApi();
            var projectKey = projectKey_example;  // string | The project key, used to tie the flags together under one project so they can be managed together.
            var featureFlagBody = new FeatureFlagBody(); // FeatureFlagBody | Create a new feature flag.

            try
            {
                // Creates a new feature flag.
                apiInstance.PostFeatureFlag(projectKey, featureFlagBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.PostFeatureFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectKey** | **string**| The project key, used to tie the flags together under one project so they can be managed together. | 
 **featureFlagBody** | [**FeatureFlagBody**](FeatureFlagBody.md)| Create a new feature flag. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

