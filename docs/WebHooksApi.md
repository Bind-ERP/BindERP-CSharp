# IO.Swagger.Api.WebHooksApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebHooksAddWebHookSubscriptions**](WebHooksApi.md#webhooksaddwebhooksubscriptions) | **POST** /api/WebHookSubscriptions | Suscribirse a un WebHook
[**WebHooksDeleteWebHookSubscriptionByID**](WebHooksApi.md#webhooksdeletewebhooksubscriptionbyid) | **DELETE** /api/WebHookSubscriptions | Borrar suscripción a WebHook
[**WebHooksEditWebHookSubscription**](WebHooksApi.md#webhookseditwebhooksubscription) | **PUT** /api/WebHookSubscriptions | Editar suscripción a WebHook
[**WebHooksGetWebHookSampleData**](WebHooksApi.md#webhooksgetwebhooksampledata) | **GET** /api/WebHooks/{eventID} | Obtiene un ejemplo del modelo de datos que envía el WebHook.
[**WebHooksGetWebHookSubscriptions**](WebHooksApi.md#webhooksgetwebhooksubscriptions) | **GET** /api/WebHookSubscriptions | Obtiene la lista de su suscripciones a WebHooks
[**WebHooksGetWebHooks**](WebHooksApi.md#webhooksgetwebhooks) | **GET** /api/WebHooks | Obtiene la lista de WebHooks disponibles.


<a name="webhooksaddwebhooksubscriptions"></a>
# **WebHooksAddWebHookSubscriptions**
> Object WebHooksAddWebHookSubscriptions (NewWebHookSubscription newWebHookSubscription)

Suscribirse a un WebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHooksAddWebHookSubscriptionsExample
    {
        public void main()
        {
            var apiInstance = new WebHooksApi();
            var newWebHookSubscription = new NewWebHookSubscription(); // NewWebHookSubscription | 

            try
            {
                // Suscribirse a un WebHook
                Object result = apiInstance.WebHooksAddWebHookSubscriptions(newWebHookSubscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHooksApi.WebHooksAddWebHookSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newWebHookSubscription** | [**NewWebHookSubscription**](NewWebHookSubscription.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksdeletewebhooksubscriptionbyid"></a>
# **WebHooksDeleteWebHookSubscriptionByID**
> void WebHooksDeleteWebHookSubscriptionByID (string id)

Borrar suscripción a WebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHooksDeleteWebHookSubscriptionByIDExample
    {
        public void main()
        {
            var apiInstance = new WebHooksApi();
            var id = id_example;  // string | 

            try
            {
                // Borrar suscripción a WebHook
                apiInstance.WebHooksDeleteWebHookSubscriptionByID(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHooksApi.WebHooksDeleteWebHookSubscriptionByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookseditwebhooksubscription"></a>
# **WebHooksEditWebHookSubscription**
> void WebHooksEditWebHookSubscription (EditWebHookSubscription webHookSubscription)

Editar suscripción a WebHook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHooksEditWebHookSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new WebHooksApi();
            var webHookSubscription = new EditWebHookSubscription(); // EditWebHookSubscription | 

            try
            {
                // Editar suscripción a WebHook
                apiInstance.WebHooksEditWebHookSubscription(webHookSubscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHooksApi.WebHooksEditWebHookSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webHookSubscription** | [**EditWebHookSubscription**](EditWebHookSubscription.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksgetwebhooksampledata"></a>
# **WebHooksGetWebHookSampleData**
> Object WebHooksGetWebHookSampleData (string eventID)

Obtiene un ejemplo del modelo de datos que envía el WebHook.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHooksGetWebHookSampleDataExample
    {
        public void main()
        {
            var apiInstance = new WebHooksApi();
            var eventID = eventID_example;  // string | 

            try
            {
                // Obtiene un ejemplo del modelo de datos que envía el WebHook.
                Object result = apiInstance.WebHooksGetWebHookSampleData(eventID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHooksApi.WebHooksGetWebHookSampleData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventID** | **string**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksgetwebhooksubscriptions"></a>
# **WebHooksGetWebHookSubscriptions**
> WebHookSubscriptionPage WebHooksGetWebHookSubscriptions (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de su suscripciones a WebHooks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHooksGetWebHookSubscriptionsExample
    {
        public void main()
        {
            var apiInstance = new WebHooksApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de su suscripciones a WebHooks
                WebHookSubscriptionPage result = apiInstance.WebHooksGetWebHookSubscriptions(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHooksApi.WebHooksGetWebHookSubscriptions: " + e.Message );
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

[**WebHookSubscriptionPage**](WebHookSubscriptionPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksgetwebhooks"></a>
# **WebHooksGetWebHooks**
> WebHookPage WebHooksGetWebHooks (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de WebHooks disponibles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebHooksGetWebHooksExample
    {
        public void main()
        {
            var apiInstance = new WebHooksApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de WebHooks disponibles.
                WebHookPage result = apiInstance.WebHooksGetWebHooks(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebHooksApi.WebHooksGetWebHooks: " + e.Message );
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

[**WebHookPage**](WebHookPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

