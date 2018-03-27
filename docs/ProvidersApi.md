# IO.Swagger.Api.ProvidersApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProvidersAddProvider**](ProvidersApi.md#providersaddprovider) | **POST** /api/Providers | Agregar Proveedor
[**ProvidersDeleteByID**](ProvidersApi.md#providersdeletebyid) | **DELETE** /api/Providers/{id} | Borrar Proveedor
[**ProvidersEditProvider**](ProvidersApi.md#providerseditprovider) | **PUT** /api/Providers | Editar Proveedor
[**ProvidersGetProviders**](ProvidersApi.md#providersgetproviders) | **GET** /api/Providers | Obtiene la lista de proveedores.


<a name="providersaddprovider"></a>
# **ProvidersAddProvider**
> Guid? ProvidersAddProvider (NewProvider newProvider)

Agregar Proveedor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProvidersAddProviderExample
    {
        public void main()
        {
            var apiInstance = new ProvidersApi();
            var newProvider = new NewProvider(); // NewProvider | 

            try
            {
                // Agregar Proveedor
                Guid? result = apiInstance.ProvidersAddProvider(newProvider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersAddProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newProvider** | [**NewProvider**](NewProvider.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="providersdeletebyid"></a>
# **ProvidersDeleteByID**
> void ProvidersDeleteByID (Guid? id)

Borrar Proveedor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProvidersDeleteByIDExample
    {
        public void main()
        {
            var apiInstance = new ProvidersApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Borrar Proveedor
                apiInstance.ProvidersDeleteByID(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersDeleteByID: " + e.Message );
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

<a name="providerseditprovider"></a>
# **ProvidersEditProvider**
> void ProvidersEditProvider (EditProvider provider)

Editar Proveedor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProvidersEditProviderExample
    {
        public void main()
        {
            var apiInstance = new ProvidersApi();
            var provider = new EditProvider(); // EditProvider | 

            try
            {
                // Editar Proveedor
                apiInstance.ProvidersEditProvider(provider);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersEditProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **provider** | [**EditProvider**](EditProvider.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="providersgetproviders"></a>
# **ProvidersGetProviders**
> ProviderListItemPage ProvidersGetProviders (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de proveedores.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProvidersGetProvidersExample
    {
        public void main()
        {
            var apiInstance = new ProvidersApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de proveedores.
                ProviderListItemPage result = apiInstance.ProvidersGetProviders(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersGetProviders: " + e.Message );
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

[**ProviderListItemPage**](ProviderListItemPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

