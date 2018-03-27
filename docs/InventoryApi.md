# IO.Swagger.Api.InventoryApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryAddInventoryAdjustment**](InventoryApi.md#inventoryaddinventoryadjustment) | **POST** /api/Inventory | Agregar ajuste de inventario.
[**InventoryGetInventoryByWarehouseID**](InventoryApi.md#inventorygetinventorybywarehouseid) | **GET** /api/Inventory | Obtener inventario por almacén.


<a name="inventoryaddinventoryadjustment"></a>
# **InventoryAddInventoryAdjustment**
> void InventoryAddInventoryAdjustment (NewInventoryAdjustment newAdjustment)

Agregar ajuste de inventario.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryAddInventoryAdjustmentExample
    {
        public void main()
        {
            var apiInstance = new InventoryApi();
            var newAdjustment = new NewInventoryAdjustment(); // NewInventoryAdjustment | 

            try
            {
                // Agregar ajuste de inventario.
                apiInstance.InventoryAddInventoryAdjustment(newAdjustment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryAddInventoryAdjustment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newAdjustment** | [**NewInventoryAdjustment**](NewInventoryAdjustment.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventorygetinventorybywarehouseid"></a>
# **InventoryGetInventoryByWarehouseID**
> InventorytPage InventoryGetInventoryByWarehouseID (Guid? warehouseID, string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtener inventario por almacén.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InventoryGetInventoryByWarehouseIDExample
    {
        public void main()
        {
            var apiInstance = new InventoryApi();
            var warehouseID = new Guid?(); // Guid? | 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtener inventario por almacén.
                InventorytPage result = apiInstance.InventoryGetInventoryByWarehouseID(warehouseID, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.InventoryGetInventoryByWarehouseID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseID** | [**Guid?**](Guid?.md)|  | 
 **filter** | **string**| Filters the results, based on a Boolean condition. | [optional] 
 **orderby** | **string**| Sorts the results. | [optional] 
 **top** | **int?**| Returns only the first n results. | [optional] 
 **skip** | **int?**| Skips the first n results. | [optional] 

### Return type

[**InventorytPage**](InventorytPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

