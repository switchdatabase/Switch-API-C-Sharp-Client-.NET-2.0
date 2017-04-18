# IO.Swagger..AuthorizationApi

All URIs are relative to *http://tr02.switchapi.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokenGet**](AuthorizationApi.md#tokenget) | **GET** /Token | Generate Access Token


<a name="tokenget"></a>
# **TokenGet**
> string TokenGet (string aPIKey, string signature, long? expire)

Generate Access Token

For generating Access Token, you need API Key and API Secret parameters that are provided from the developer portal. At the request, API Key that will be sent by using header is generated as portal API Key and Signature parameter is generated as md5(APISecret + ExpireTimestamp) format. At Expire parameter, token's expire date and time information must be proper to ISO 8601 standarts and Unix Time format with msec information. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TokenGetExample
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var aPIKey = aPIKey_example;  // string | Your Switch API Key.
            var signature = signature_example;  // string | Signature parameter is generated as md5(APISecret + ExpireTimestamp) format.
            var expire = 789;  // long? | Expire parameter, token's expire date and time information must be proper to ISO 8601 standarts and Unix Time format with msec information.

            try
            {
                // Generate Access Token
                string result = apiInstance.TokenGet(aPIKey, signature, expire);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.TokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aPIKey** | **string**| Your Switch API Key. | 
 **signature** | **string**| Signature parameter is generated as md5(APISecret + ExpireTimestamp) format. | 
 **expire** | **long?**| Expire parameter, token&#39;s expire date and time information must be proper to ISO 8601 standarts and Unix Time format with msec information. | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

