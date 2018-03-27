# IO.Swagger.Api.OrdersApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrdersAddOrder**](OrdersApi.md#ordersaddorder) | **POST** /api/Orders | Agregar pedido
[**OrdersDeleteOrder**](OrdersApi.md#ordersdeleteorder) | **DELETE** /api/Orders/{id} | Eliminar pedido
[**OrdersEditOrder**](OrdersApi.md#orderseditorder) | **PUT** /api/Orders | Editar pedido
[**OrdersGetByID**](OrdersApi.md#ordersgetbyid) | **GET** /api/Orders/{id} | Obtiene los detalles de un pedido


<a name="ordersaddorder"></a>
# **OrdersAddOrder**
> Guid? OrdersAddOrder (NewOrder newOrder)

Agregar pedido

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersAddOrderExample
    {
        public void main()
        {
            var apiInstance = new OrdersApi();
            var newOrder = new NewOrder(); // NewOrder | 

            try
            {
                // Agregar pedido
                Guid? result = apiInstance.OrdersAddOrder(newOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersAddOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newOrder** | [**NewOrder**](NewOrder.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersdeleteorder"></a>
# **OrdersDeleteOrder**
> void OrdersDeleteOrder (Guid? id)

Eliminar pedido

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersDeleteOrderExample
    {
        public void main()
        {
            var apiInstance = new OrdersApi();
            var id = new Guid?(); // Guid? | ID

            try
            {
                // Eliminar pedido
                apiInstance.OrdersDeleteOrder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersDeleteOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderseditorder"></a>
# **OrdersEditOrder**
> void OrdersEditOrder (EditOrder order)

Editar pedido

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersEditOrderExample
    {
        public void main()
        {
            var apiInstance = new OrdersApi();
            var order = new EditOrder(); // EditOrder | 

            try
            {
                // Editar pedido
                apiInstance.OrdersEditOrder(order);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersEditOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**EditOrder**](EditOrder.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordersgetbyid"></a>
# **OrdersGetByID**
> OrderDetails OrdersGetByID (Guid? id)

Obtiene los detalles de un pedido

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrdersGetByIDExample
    {
        public void main()
        {
            var apiInstance = new OrdersApi();
            var id = new Guid?(); // Guid? | ID

            try
            {
                // Obtiene los detalles de un pedido
                OrderDetails result = apiInstance.OrdersGetByID(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.OrdersGetByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| ID | 

### Return type

[**OrderDetails**](OrderDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

