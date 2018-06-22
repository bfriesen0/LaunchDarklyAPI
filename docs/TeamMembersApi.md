# LaunchDarklyAPI.Api.TeamMembersApi

All URIs are relative to *https://app.launchdarkly.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMember**](TeamMembersApi.md#deletemember) | **DELETE** /members/{memberId} | Delete a team member by ID.
[**GetMember**](TeamMembersApi.md#getmember) | **GET** /members/{memberId} | Get a single team member by ID.
[**GetMembers**](TeamMembersApi.md#getmembers) | **GET** /members | Returns a list of all members in the account.
[**PatchMember**](TeamMembersApi.md#patchmember) | **PATCH** /members/{memberId} | Modify a team member by ID.
[**PostMembers**](TeamMembersApi.md#postmembers) | **POST** /members | Invite new members.


<a name="deletemember"></a>
# **DeleteMember**
> void DeleteMember (string memberId)

Delete a team member by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class DeleteMemberExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var memberId = memberId_example;  // string | The member ID.

            try
            {
                // Delete a team member by ID.
                apiInstance.DeleteMember(memberId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.DeleteMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **string**| The member ID. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmember"></a>
# **GetMember**
> Member GetMember (string memberId)

Get a single team member by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetMemberExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var memberId = memberId_example;  // string | The member ID.

            try
            {
                // Get a single team member by ID.
                Member result = apiInstance.GetMember(memberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.GetMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **string**| The member ID. | 

### Return type

[**Member**](Member.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembers"></a>
# **GetMembers**
> Members GetMembers ()

Returns a list of all members in the account.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class GetMembersExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();

            try
            {
                // Returns a list of all members in the account.
                Members result = apiInstance.GetMembers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.GetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Members**](Members.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchmember"></a>
# **PatchMember**
> Member PatchMember (string memberId, List<PatchOperation> patchDelta)

Modify a team member by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PatchMemberExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var memberId = memberId_example;  // string | The member ID.
            var patchDelta = new List<PatchOperation>(); // List<PatchOperation> | Requires a JSON Patch representation of the desired changes to the project. 'http://jsonpatch.com/'

            try
            {
                // Modify a team member by ID.
                Member result = apiInstance.PatchMember(memberId, patchDelta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.PatchMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberId** | **string**| The member ID. | 
 **patchDelta** | [**List&lt;PatchOperation&gt;**](PatchOperation.md)| Requires a JSON Patch representation of the desired changes to the project. &#39;http://jsonpatch.com/&#39; | 

### Return type

[**Member**](Member.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmembers"></a>
# **PostMembers**
> void PostMembers (List<MembersBody> membersBody)

Invite new members.

### Example
```csharp
using System;
using System.Diagnostics;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Model;

namespace Example
{
    public class PostMembersExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var membersBody = new List<MembersBody>(); // List<MembersBody> | New members to invite.

            try
            {
                // Invite new members.
                apiInstance.PostMembers(membersBody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.PostMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membersBody** | [**List&lt;MembersBody&gt;**](MembersBody.md)| New members to invite. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

