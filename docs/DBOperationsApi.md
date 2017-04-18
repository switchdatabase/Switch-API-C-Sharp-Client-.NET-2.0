# IO.Swagger..DBOperationsApi

All URIs are relative to *http://tr02.switchapi.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPost**](DBOperationsApi.md#addpost) | **POST** /Add | Add is used for adding a data object to the list created at Switch DB.
[**ListPost**](DBOperationsApi.md#listpost) | **POST** /List | It&#39;s used for listing a data added before.
[**SetDelete**](DBOperationsApi.md#setdelete) | **DELETE** /Set | It&#39;s used for deleting a data added before at Switch DB.
[**SetPost**](DBOperationsApi.md#setpost) | **POST** /Set | It&#39;s used for updating a data object that is already added to Switch DB.


<a name="addpost"></a>
# **AddPost**
> AddResponse AddPost (string aPIKey, string accessToken, string list, string body)

Add is used for adding a data object to the list created at Switch DB.

You can choose the list that will be added tha data set to with List parameter that will be sent to Header. It's equal to INSERT query at the relational databases model. The data set that will be added to the database is transmited at request body. For versions upper than v1.2.1, if the data sent is an array, all items in the array are added one by one, so they are added as a whole. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPostExample
    {
        public void main()
        {
            
            var apiInstance = new DBOperationsApi();
            var aPIKey = aPIKey_example;  // string | Your Switch API Key.
            var accessToken = accessToken_example;  // string | Your Access Token.
            var list = list_example;  // string | Your data list name.
            var body = body_example;  // string | Your new value JSON.

            try
            {
                // Add is used for adding a data object to the list created at Switch DB.
                AddResponse result = apiInstance.AddPost(aPIKey, accessToken, list, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DBOperationsApi.AddPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aPIKey** | **string**| Your Switch API Key. | 
 **accessToken** | **string**| Your Access Token. | 
 **list** | **string**| Your data list name. | 
 **body** | **string**| Your new value JSON. | 

### Return type

[**AddResponse**](AddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpost"></a>
# **ListPost**
> void ListPost (string aPIKey, string accessToken, string list, Body body)

It's used for listing a data added before.

List parameter sent remarks the list that will be do listing work on at Header. It's equal to SELECT query at relational databases. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPostExample
    {
        public void main()
        {
            
            var apiInstance = new DBOperationsApi();
            var aPIKey = aPIKey_example;  // string | Your Switch API Key.
            var accessToken = accessToken_example;  // string | Your Access Token.
            var list = list_example;  // string | Your data list name.
            var body = new Body(); // Body | Your Switch DB Query.

            try
            {
                // It's used for listing a data added before.
                apiInstance.ListPost(aPIKey, accessToken, list, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DBOperationsApi.ListPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aPIKey** | **string**| Your Switch API Key. | 
 **accessToken** | **string**| Your Access Token. | 
 **list** | **string**| Your data list name. | 
 **body** | [**Body**](Body.md)| Your Switch DB Query. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdelete"></a>
# **SetDelete**
> SetResponse SetDelete (string aPIKey, string accessToken, string list, string listItemId)

It's used for deleting a data added before at Switch DB.

List parameter sent remarks the list that will be deleted data from at Header and ListItemId parameter remarks the ID consisted by Switch DB for the data that will be deleted. It's equal to DELETE query at relational databases. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new DBOperationsApi();
            var aPIKey = aPIKey_example;  // string | Your Switch API Key.
            var accessToken = accessToken_example;  // string | Your Access Token.
            var list = list_example;  // string | Your data list name.
            var listItemId = listItemId_example;  // string | Your list item id.

            try
            {
                // It's used for deleting a data added before at Switch DB.
                SetResponse result = apiInstance.SetDelete(aPIKey, accessToken, list, listItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DBOperationsApi.SetDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aPIKey** | **string**| Your Switch API Key. | 
 **accessToken** | **string**| Your Access Token. | 
 **list** | **string**| Your data list name. | 
 **listItemId** | **string**| Your list item id. | 

### Return type

[**SetResponse**](SetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpost"></a>
# **SetPost**
> SetResponse SetPost (string aPIKey, string accessToken, string list, string listItemId, string body)

It's used for updating a data object that is already added to Switch DB.

In order to UPDATE a object, Listname and ListItemId parameters should be sent in the Header of the REQUEST as \"List\", \"ListItemId\", respectively, as shown in the example below. It's equal to UPDATE query at relational databases. The data set that will be edited is transmited to the database at request body. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetPostExample
    {
        public void main()
        {
            
            var apiInstance = new DBOperationsApi();
            var aPIKey = aPIKey_example;  // string | Your Switch API Key.
            var accessToken = accessToken_example;  // string | Your Access Token.
            var list = list_example;  // string | Your data list name.
            var listItemId = listItemId_example;  // string | Your list item id.
            var body = body_example;  // string | Your new value JSON.

            try
            {
                // It's used for updating a data object that is already added to Switch DB.
                SetResponse result = apiInstance.SetPost(aPIKey, accessToken, list, listItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DBOperationsApi.SetPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aPIKey** | **string**| Your Switch API Key. | 
 **accessToken** | **string**| Your Access Token. | 
 **list** | **string**| Your data list name. | 
 **listItemId** | **string**| Your list item id. | 
 **body** | **string**| Your new value JSON. | 

### Return type

[**SetResponse**](SetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

