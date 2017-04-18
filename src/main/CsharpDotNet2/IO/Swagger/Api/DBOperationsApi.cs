using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDBOperationsApi
    {
        /// <summary>
        /// Add is used for adding a data object to the list created at Switch DB. You can choose the list that will be added tha data set to with List parameter that will be sent to Header. It&#39;s equal to INSERT query at the relational databases model. The data set that will be added to the database is transmited at request body. For versions upper than v1.2.1, if the data sent is an array, all items in the array are added one by one, so they are added as a whole. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param>
        /// <param name="accessToken">Your Access Token.</param>
        /// <param name="list">Your data list name.</param>
        /// <param name="body">Your new value JSON.</param>
        /// <returns>AddResponse</returns>
        AddResponse AddPost (string aPIKey, string accessToken, string list, string body);
        /// <summary>
        /// It&#39;s used for listing a data added before. List parameter sent remarks the list that will be do listing work on at Header. It&#39;s equal to SELECT query at relational databases. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param>
        /// <param name="accessToken">Your Access Token.</param>
        /// <param name="list">Your data list name.</param>
        /// <param name="body">Your Switch DB Query.</param>
        /// <returns></returns>
        void ListPost (string aPIKey, string accessToken, string list, Body body);
        /// <summary>
        /// It&#39;s used for deleting a data added before at Switch DB. List parameter sent remarks the list that will be deleted data from at Header and ListItemId parameter remarks the ID consisted by Switch DB for the data that will be deleted. It&#39;s equal to DELETE query at relational databases. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param>
        /// <param name="accessToken">Your Access Token.</param>
        /// <param name="list">Your data list name.</param>
        /// <param name="listItemId">Your list item id.</param>
        /// <returns>SetResponse</returns>
        SetResponse SetDelete (string aPIKey, string accessToken, string list, string listItemId);
        /// <summary>
        /// It&#39;s used for updating a data object that is already added to Switch DB. In order to UPDATE a object, Listname and ListItemId parameters should be sent in the Header of the REQUEST as \&quot;List\&quot;, \&quot;ListItemId\&quot;, respectively, as shown in the example below. It&#39;s equal to UPDATE query at relational databases. The data set that will be edited is transmited to the database at request body. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param>
        /// <param name="accessToken">Your Access Token.</param>
        /// <param name="list">Your data list name.</param>
        /// <param name="listItemId">Your list item id.</param>
        /// <param name="body">Your new value JSON.</param>
        /// <returns>SetResponse</returns>
        SetResponse SetPost (string aPIKey, string accessToken, string list, string listItemId, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DBOperationsApi : IDBOperationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBOperationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DBOperationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DBOperationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DBOperationsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Add is used for adding a data object to the list created at Switch DB. You can choose the list that will be added tha data set to with List parameter that will be sent to Header. It&#39;s equal to INSERT query at the relational databases model. The data set that will be added to the database is transmited at request body. For versions upper than v1.2.1, if the data sent is an array, all items in the array are added one by one, so they are added as a whole. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param> 
        /// <param name="accessToken">Your Access Token.</param> 
        /// <param name="list">Your data list name.</param> 
        /// <param name="body">Your new value JSON.</param> 
        /// <returns>AddResponse</returns>            
        public AddResponse AddPost (string aPIKey, string accessToken, string list, string body)
        {
            
            // verify the required parameter 'aPIKey' is set
            if (aPIKey == null) throw new ApiException(400, "Missing required parameter 'aPIKey' when calling AddPost");
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling AddPost");
            
            // verify the required parameter 'list' is set
            if (list == null) throw new ApiException(400, "Missing required parameter 'list' when calling AddPost");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddPost");
            
    
            var path = "/Add";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (aPIKey != null) headerParams.Add("APIKey", ApiClient.ParameterToString(aPIKey)); // header parameter
 if (accessToken != null) headerParams.Add("AccessToken", ApiClient.ParameterToString(accessToken)); // header parameter
 if (list != null) headerParams.Add("List", ApiClient.ParameterToString(list)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AddResponse) ApiClient.Deserialize(response.Content, typeof(AddResponse), response.Headers);
        }
    
        /// <summary>
        /// It&#39;s used for listing a data added before. List parameter sent remarks the list that will be do listing work on at Header. It&#39;s equal to SELECT query at relational databases. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param> 
        /// <param name="accessToken">Your Access Token.</param> 
        /// <param name="list">Your data list name.</param> 
        /// <param name="body">Your Switch DB Query.</param> 
        /// <returns></returns>            
        public void ListPost (string aPIKey, string accessToken, string list, Body body)
        {
            
            // verify the required parameter 'aPIKey' is set
            if (aPIKey == null) throw new ApiException(400, "Missing required parameter 'aPIKey' when calling ListPost");
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling ListPost");
            
            // verify the required parameter 'list' is set
            if (list == null) throw new ApiException(400, "Missing required parameter 'list' when calling ListPost");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ListPost");
            
    
            var path = "/List";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (aPIKey != null) headerParams.Add("APIKey", ApiClient.ParameterToString(aPIKey)); // header parameter
 if (accessToken != null) headerParams.Add("AccessToken", ApiClient.ParameterToString(accessToken)); // header parameter
 if (list != null) headerParams.Add("List", ApiClient.ParameterToString(list)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// It&#39;s used for deleting a data added before at Switch DB. List parameter sent remarks the list that will be deleted data from at Header and ListItemId parameter remarks the ID consisted by Switch DB for the data that will be deleted. It&#39;s equal to DELETE query at relational databases. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param> 
        /// <param name="accessToken">Your Access Token.</param> 
        /// <param name="list">Your data list name.</param> 
        /// <param name="listItemId">Your list item id.</param> 
        /// <returns>SetResponse</returns>            
        public SetResponse SetDelete (string aPIKey, string accessToken, string list, string listItemId)
        {
            
            // verify the required parameter 'aPIKey' is set
            if (aPIKey == null) throw new ApiException(400, "Missing required parameter 'aPIKey' when calling SetDelete");
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling SetDelete");
            
            // verify the required parameter 'list' is set
            if (list == null) throw new ApiException(400, "Missing required parameter 'list' when calling SetDelete");
            
            // verify the required parameter 'listItemId' is set
            if (listItemId == null) throw new ApiException(400, "Missing required parameter 'listItemId' when calling SetDelete");
            
    
            var path = "/Set";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (aPIKey != null) headerParams.Add("APIKey", ApiClient.ParameterToString(aPIKey)); // header parameter
 if (accessToken != null) headerParams.Add("AccessToken", ApiClient.ParameterToString(accessToken)); // header parameter
 if (list != null) headerParams.Add("List", ApiClient.ParameterToString(list)); // header parameter
 if (listItemId != null) headerParams.Add("ListItemId", ApiClient.ParameterToString(listItemId)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SetResponse) ApiClient.Deserialize(response.Content, typeof(SetResponse), response.Headers);
        }
    
        /// <summary>
        /// It&#39;s used for updating a data object that is already added to Switch DB. In order to UPDATE a object, Listname and ListItemId parameters should be sent in the Header of the REQUEST as \&quot;List\&quot;, \&quot;ListItemId\&quot;, respectively, as shown in the example below. It&#39;s equal to UPDATE query at relational databases. The data set that will be edited is transmited to the database at request body. 
        /// </summary>
        /// <param name="aPIKey">Your Switch API Key.</param> 
        /// <param name="accessToken">Your Access Token.</param> 
        /// <param name="list">Your data list name.</param> 
        /// <param name="listItemId">Your list item id.</param> 
        /// <param name="body">Your new value JSON.</param> 
        /// <returns>SetResponse</returns>            
        public SetResponse SetPost (string aPIKey, string accessToken, string list, string listItemId, string body)
        {
            
            // verify the required parameter 'aPIKey' is set
            if (aPIKey == null) throw new ApiException(400, "Missing required parameter 'aPIKey' when calling SetPost");
            
            // verify the required parameter 'accessToken' is set
            if (accessToken == null) throw new ApiException(400, "Missing required parameter 'accessToken' when calling SetPost");
            
            // verify the required parameter 'list' is set
            if (list == null) throw new ApiException(400, "Missing required parameter 'list' when calling SetPost");
            
            // verify the required parameter 'listItemId' is set
            if (listItemId == null) throw new ApiException(400, "Missing required parameter 'listItemId' when calling SetPost");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetPost");
            
    
            var path = "/Set";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (aPIKey != null) headerParams.Add("APIKey", ApiClient.ParameterToString(aPIKey)); // header parameter
 if (accessToken != null) headerParams.Add("AccessToken", ApiClient.ParameterToString(accessToken)); // header parameter
 if (list != null) headerParams.Add("List", ApiClient.ParameterToString(list)); // header parameter
 if (listItemId != null) headerParams.Add("ListItemId", ApiClient.ParameterToString(listItemId)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SetResponse) ApiClient.Deserialize(response.Content, typeof(SetResponse), response.Headers);
        }
    
    }
}
