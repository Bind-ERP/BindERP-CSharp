# IO.Swagger.Api.ServicesApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServicesAddProduct**](ServicesApi.md#servicesaddproduct) | **POST** /api/Services | Agregar Concepto de Venta
[**ServicesDeleteByID**](ServicesApi.md#servicesdeletebyid) | **DELETE** /api/Services/{id} | Borrar Servicio
[**ServicesEditProduct**](ServicesApi.md#serviceseditproduct) | **PUT** /api/Services | Editar Concepto de Venta
[**ServicesGetServices**](ServicesApi.md#servicesgetservices) | **GET** /api/Services | Obtiene la lista de conceptos de venta.


<a name="servicesaddproduct"></a>
# **ServicesAddProduct**
> Guid? ServicesAddProduct (NewService newService)

Agregar Concepto de Venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServicesAddProductExample
    {
        public void main()
        {
            var apiInstance = new ServicesApi();
            var newService = new NewService(); // NewService | 

            try
            {
                // Agregar Concepto de Venta
                Guid? result = apiInstance.ServicesAddProduct(newService);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.ServicesAddProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newService** | [**NewService**](NewService.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicesdeletebyid"></a>
# **ServicesDeleteByID**
> void ServicesDeleteByID (Guid? id)

Borrar Servicio

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServicesDeleteByIDExample
    {
        public void main()
        {
            var apiInstance = new ServicesApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Borrar Servicio
                apiInstance.ServicesDeleteByID(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.ServicesDeleteByID: " + e.Message );
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

<a name="serviceseditproduct"></a>
# **ServicesEditProduct**
> void ServicesEditProduct (EditService service)

Editar Concepto de Venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServicesEditProductExample
    {
        public void main()
        {
            var apiInstance = new ServicesApi();
            var service = new EditService(); // EditService | 

            try
            {
                // Editar Concepto de Venta
                apiInstance.ServicesEditProduct(service);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.ServicesEditProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | [**EditService**](EditService.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servicesgetservices"></a>
# **ServicesGetServices**
> ServicesPage ServicesGetServices (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de conceptos de venta.

El filtro es opcional

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServicesGetServicesExample
    {
        public void main()
        {
            var apiInstance = new ServicesApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de conceptos de venta.
                ServicesPage result = apiInstance.ServicesGetServices(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServicesApi.ServicesGetServices: " + e.Message );
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

[**ServicesPage**](ServicesPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

