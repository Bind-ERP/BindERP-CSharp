# IO.Swagger.Api.CommentsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommentsAddComment**](CommentsApi.md#commentsaddcomment) | **POST** /api/Comments | Agregar comentario
[**CommentsGet**](CommentsApi.md#commentsget) | **GET** /api/Comments | Listar comentarios por external ID


<a name="commentsaddcomment"></a>
# **CommentsAddComment**
> void CommentsAddComment (NewComment newComment)

Agregar comentario

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommentsAddCommentExample
    {
        public void main()
        {
            var apiInstance = new CommentsApi();
            var newComment = new NewComment(); // NewComment | 

            try
            {
                // Agregar comentario
                apiInstance.CommentsAddComment(newComment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.CommentsAddComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newComment** | [**NewComment**](NewComment.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="commentsget"></a>
# **CommentsGet**
> CommentPage CommentsGet (string filter = null, string orderby = null, int? top = null, int? skip = null)

Listar comentarios por external ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CommentsGetExample
    {
        public void main()
        {
            var apiInstance = new CommentsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Listar comentarios por external ID
                CommentPage result = apiInstance.CommentsGet(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.CommentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filters the results, based on a Boolean condition. | [optional] 
 **orderby** | **string**| Sorts the results. | [optional] 
 **top** | **int?**| Returns only the first n results. | [optional] 
 **skip** | **int?**| Skips the first n results. | [optional] 

### Return type

[**CommentPage**](CommentPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

