# IO.Swagger.Api.ProspectsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProspectsAddProspect**](ProspectsApi.md#prospectsaddprospect) | **POST** /api/Prospects | Agregar Prospecto
[**ProspectsDeleteByID**](ProspectsApi.md#prospectsdeletebyid) | **DELETE** /api/Prospects/{id} | Borrar Prospecto
[**ProspectsEditClient**](ProspectsApi.md#prospectseditclient) | **PUT** /api/Prospects | Editar Prospecto
[**ProspectsGet**](ProspectsApi.md#prospectsget) | **GET** /api/Prospects/{id} | Obtiene los detalles de un prospecto.
[**ProspectsGetProspects**](ProspectsApi.md#prospectsgetprospects) | **GET** /api/Prospects | Obtiene la lista de prospectos.


<a name="prospectsaddprospect"></a>
# **ProspectsAddProspect**
<<<<<<< HEAD
> Object ProspectsAddProspect (NewProspect newProspect)
=======
> Guid? ProspectsAddProspect (NewProspect newProspect)
>>>>>>> 00a0f02ad3caf59a4284f6cc77ac538a3fc20070

Agregar Prospecto

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProspectsAddProspectExample
    {
        public void main()
        {
            var apiInstance = new ProspectsApi();
            var newProspect = new NewProspect(); // NewProspect | 

            try
            {
                // Agregar Prospecto
                Object result = apiInstance.ProspectsAddProspect(newProspect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProspectsApi.ProspectsAddProspect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newProspect** | [**NewProspect**](NewProspect.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prospectsdeletebyid"></a>
# **ProspectsDeleteByID**
> void ProspectsDeleteByID (Guid? id)

Borrar Prospecto

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProspectsDeleteByIDExample
    {
        public void main()
        {
            var apiInstance = new ProspectsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Borrar Prospecto
                apiInstance.ProspectsDeleteByID(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProspectsApi.ProspectsDeleteByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prospectseditclient"></a>
# **ProspectsEditClient**
> void ProspectsEditClient (EditProspect prospect)

Editar Prospecto

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProspectsEditClientExample
    {
        public void main()
        {
            var apiInstance = new ProspectsApi();
            var prospect = new EditProspect(); // EditProspect | 

            try
            {
                // Editar Prospecto
                apiInstance.ProspectsEditClient(prospect);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProspectsApi.ProspectsEditClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prospect** | [**EditProspect**](EditProspect.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prospectsget"></a>
# **ProspectsGet**
> ProspectDetails ProspectsGet (Guid? id)

Obtiene los detalles de un prospecto.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProspectsGetExample
    {
        public void main()
        {
            var apiInstance = new ProspectsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Obtiene los detalles de un prospecto.
                ProspectDetails result = apiInstance.ProspectsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProspectsApi.ProspectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**ProspectDetails**](ProspectDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prospectsgetprospects"></a>
# **ProspectsGetProspects**
> ProspectListItemPage ProspectsGetProspects (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de prospectos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProspectsGetProspectsExample
    {
        public void main()
        {
            var apiInstance = new ProspectsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de prospectos.
                ProspectListItemPage result = apiInstance.ProspectsGetProspects(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProspectsApi.ProspectsGetProspects: " + e.Message );
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

[**ProspectListItemPage**](ProspectListItemPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

