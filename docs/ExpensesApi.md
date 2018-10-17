# IO.Swagger.Api.ExpensesApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExpensesGetDetail**](ExpensesApi.md#expensesgetdetail) | **GET** /api/Expenses/{id} | Obtiene los detalles de una orden de gasto.
[**ExpensesGetPayment**](ExpensesApi.md#expensesgetpayment) | **GET** /api/Expenses/Payment/{expenseID} | Obtener pagos de una orden de gasto.


<a name="expensesgetdetail"></a>
# **ExpensesGetDetail**
> ExpenseDetails ExpensesGetDetail (Guid? id)

Obtiene los detalles de una orden de gasto.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpensesGetDetailExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Obtiene los detalles de una orden de gasto.
                ExpenseDetails result = apiInstance.ExpensesGetDetail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.ExpensesGetDetail: " + e.Message );
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

[**ExpenseDetails**](ExpenseDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expensesgetpayment"></a>
# **ExpensesGetPayment**
> PaymentListItemPage ExpensesGetPayment (Guid? expenseID, string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtener pagos de una orden de gasto.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpensesGetPaymentExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var expenseID = new Guid?(); // Guid? | 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtener pagos de una orden de gasto.
                PaymentListItemPage result = apiInstance.ExpensesGetPayment(expenseID, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.ExpensesGetPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expenseID** | [**Guid?**](Guid?.md)|  | 
 **filter** | **string**| Filters the results, based on a Boolean condition. | [optional] 
 **orderby** | **string**| Sorts the results. | [optional] 
 **top** | **int?**| Returns only the first n results. | [optional] 
 **skip** | **int?**| Skips the first n results. | [optional] 

### Return type

[**PaymentListItemPage**](PaymentListItemPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

