# LaunchDarklyAPI.Api.WebhooksApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{resourceId} | Delete a webhook by ID.
[**GetWebhook**](WebhooksApi.md#getwebhook) | **GET** /webhooks/{resourceId} | Get a webhook by ID.
[**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /webhooks | Fetch a list of all webhooks.
[**PatchWebhook**](WebhooksApi.md#patchwebhook) | **PATCH** /webhooks/{resourceId} | Modify a webhook by ID.
[**PostWebhook**](WebhooksApi.md#postwebhook) | **POST** /webhooks | Create a webhook.


<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (string resourceId)

Delete a webhook by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var resourceId = resourceId_example;  // string | The resource ID.

            try
            {
                // Delete a webhook by ID.
                apiInstance.DeleteWebhook(resourceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| The resource ID. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhook"></a>
# **GetWebhook**
> Webhook GetWebhook (string resourceId)

Get a webhook by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var resourceId = resourceId_example;  // string | The resource ID.

            try
            {
                // Get a webhook by ID.
                Webhook result = apiInstance.GetWebhook(resourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| The resource ID. | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> Webhooks GetWebhooks ()

Fetch a list of all webhooks.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();

            try
            {
                // Fetch a list of all webhooks.
                Webhooks result = apiInstance.GetWebhooks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Webhooks**](Webhooks.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchwebhook"></a>
# **PatchWebhook**
> Webhook PatchWebhook (string resourceId, List<PatchOperation> patchDelta)

Modify a webhook by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PatchWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var resourceId = resourceId_example;  // string | The resource ID.
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify a webhook by ID.
                Webhook result = apiInstance.PatchWebhook(resourceId, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.PatchWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceId** | **string**| The resource ID. | 
 **patchDelta** | [**List&lt;PatchOperation&gt;**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**Webhook**](Webhook.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwebhook"></a>
# **PostWebhook**
> void PostWebhook (WebhookBody webhookBody)

Create a webhook.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PostWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var webhookBody = new WebhookBody(); // WebhookBody | New webhook.

            try
            {
                // Create a webhook.
                apiInstance.PostWebhook(webhookBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.PostWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookBody** | [**WebhookBody**](WebhookBody.md)| New webhook. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

