# IO.Swagger.Api.ClientsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientsAddClient**](ClientsApi.md#clientsaddclient) | **POST** /api/Clients | Agregar Cliente
[**ClientsDeleteByID**](ClientsApi.md#clientsdeletebyid) | **DELETE** /api/Clients/{id} | Borrar Cliente
[**ClientsEditClient**](ClientsApi.md#clientseditclient) | **PUT** /api/Clients | Editar Cliente
[**ClientsGet**](ClientsApi.md#clientsget) | **GET** /api/Clients | Obtiene la lista de clientes.
[**ClientsGetDetails**](ClientsApi.md#clientsgetdetails) | **GET** /api/Clients/{id} | Obtiene los detalles de un cliente.


<a name="clientsaddclient"></a>
# **ClientsAddClient**
> Guid? ClientsAddClient (NewClient newClient)

Agregar Cliente

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClientsAddClientExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var newClient = new NewClient(); // NewClient | 

            try
            {
                // Agregar Cliente
                Guid? result = apiInstance.ClientsAddClient(newClient);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsAddClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newClient** | [**NewClient**](NewClient.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsdeletebyid"></a>
# **ClientsDeleteByID**
> void ClientsDeleteByID (Guid? id)

Borrar Cliente

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClientsDeleteByIDExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Borrar Cliente
                apiInstance.ClientsDeleteByID(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsDeleteByID: " + e.Message );
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

<a name="clientseditclient"></a>
# **ClientsEditClient**
> void ClientsEditClient (EditClient _client)

Editar Cliente

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClientsEditClientExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var _client = new EditClient(); // EditClient | 

            try
            {
                // Editar Cliente
                apiInstance.ClientsEditClient(_client);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsEditClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_client** | [**EditClient**](EditClient.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsget"></a>
# **ClientsGet**
> ClientListItemPage ClientsGet (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de clientes.

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
    public class ClientsGetExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de clientes.
                ClientListItemPage result = apiInstance.ClientsGet(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsGet: " + e.Message );
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

[**ClientListItemPage**](ClientListItemPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsgetdetails"></a>
# **ClientsGetDetails**
> ClientDetails ClientsGetDetails (Guid? id)

Obtiene los detalles de un cliente.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClientsGetDetailsExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Obtiene los detalles de un cliente.
                ClientDetails result = apiInstance.ClientsGetDetails(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsGetDetails: " + e.Message );
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

[**ClientDetails**](ClientDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

