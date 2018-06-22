# LaunchDarklyAPI.Api.CustomRolesApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomRole**](CustomRolesApi.md#deletecustomrole) | **DELETE** /roles/{customRoleKey} | Delete a custom role by key.
[**GetCustomRole**](CustomRolesApi.md#getcustomrole) | **GET** /roles/{customRoleKey} | Get one custom role by key.
[**GetCustomRoles**](CustomRolesApi.md#getcustomroles) | **GET** /roles | Return a complete list of custom roles.
[**PatchCustomRole**](CustomRolesApi.md#patchcustomrole) | **PATCH** /roles/{customRoleKey} | Modify a custom role by key.
[**PostCustomRole**](CustomRolesApi.md#postcustomrole) | **POST** /roles | Create a new custom role.


<a name="deletecustomrole"></a>
# **DeleteCustomRole**
> void DeleteCustomRole (string customRoleKey)

Delete a custom role by key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class DeleteCustomRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRolesApi();
            var customRoleKey = customRoleKey_example;  // string | The custom role key.

            try
            {
                // Delete a custom role by key.
                apiInstance.DeleteCustomRole(customRoleKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRolesApi.DeleteCustomRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRoleKey** | **string**| The custom role key. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomrole"></a>
# **GetCustomRole**
> CustomRole GetCustomRole (string customRoleKey)

Get one custom role by key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetCustomRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRolesApi();
            var customRoleKey = customRoleKey_example;  // string | The custom role key.

            try
            {
                // Get one custom role by key.
                CustomRole result = apiInstance.GetCustomRole(customRoleKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRolesApi.GetCustomRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRoleKey** | **string**| The custom role key. | 

### Return type

[**CustomRole**](CustomRole.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomroles"></a>
# **GetCustomRoles**
> CustomRoles GetCustomRoles ()

Return a complete list of custom roles.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetCustomRolesExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRolesApi();

            try
            {
                // Return a complete list of custom roles.
                CustomRoles result = apiInstance.GetCustomRoles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRolesApi.GetCustomRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CustomRoles**](CustomRoles.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomrole"></a>
# **PatchCustomRole**
> CustomRole PatchCustomRole (string customRoleKey, List<PatchOperation> patchDelta)

Modify a custom role by key.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PatchCustomRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRolesApi();
            var customRoleKey = customRoleKey_example;  // string | The custom role key.
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify a custom role by key.
                CustomRole result = apiInstance.PatchCustomRole(customRoleKey, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRolesApi.PatchCustomRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRoleKey** | **string**| The custom role key. | 
 **patchDelta** | [**List&lt;PatchOperation&gt;**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**CustomRole**](CustomRole.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcustomrole"></a>
# **PostCustomRole**
> void PostCustomRole (CustomRoleBody customRoleBody)

Create a new custom role.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PostCustomRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRolesApi();
            var customRoleBody = new CustomRoleBody(); // CustomRoleBody | New role or roles to create.

            try
            {
                // Create a new custom role.
                apiInstance.PostCustomRole(customRoleBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRolesApi.PostCustomRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRoleBody** | [**CustomRoleBody**](CustomRoleBody.md)| New role or roles to create. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

