# IO.Swagger.Api.InvoicesApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoicesAddInvoice**](InvoicesApi.md#invoicesaddinvoice) | **POST** /api/Invoices | Agregar Venta
[**InvoicesAddPayment**](InvoicesApi.md#invoicesaddpayment) | **POST** /api/Invoices/Payment | Registrar pago a venta
[**InvoicesDeleteInvoice**](InvoicesApi.md#invoicesdeleteinvoice) | **DELETE** /api/Invoices/{idOrNumber} | Eliminar factura
[**InvoicesGet**](InvoicesApi.md#invoicesget) | **GET** /api/Invoices | Obtiene la lista de ventas.
[**InvoicesGetByNumber**](InvoicesApi.md#invoicesgetbynumber) | **GET** /api/Invoices/{idOrNumber} | Obtiene los detalles de una venta por número
[**InvoicesGetPDF**](InvoicesApi.md#invoicesgetpdf) | **GET** /api/Invoices/{id}/pdf | Obtener el PDF de una venta
[**InvoicesGetPayment**](InvoicesApi.md#invoicesgetpayment) | **GET** /api/Invoices/Payment/{invoiceID} | Obtener pagos de una factura.
[**InvoicesGetXML**](InvoicesApi.md#invoicesgetxml) | **GET** /api/Invoices/{id}/xml | Obtener el XML de una venta


<a name="invoicesaddinvoice"></a>
# **InvoicesAddInvoice**
> Guid? InvoicesAddInvoice (NewInvoice newInvoice)

Agregar Venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesAddInvoiceExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var newInvoice = new NewInvoice(); // NewInvoice | 

            try
            {
                // Agregar Venta
                Guid? result = apiInstance.InvoicesAddInvoice(newInvoice);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesAddInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newInvoice** | [**NewInvoice**](NewInvoice.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesaddpayment"></a>
# **InvoicesAddPayment**
> void InvoicesAddPayment (NewPayment newPayment)

Registrar pago a venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesAddPaymentExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var newPayment = new NewPayment(); // NewPayment | 

            try
            {
                // Registrar pago a venta
                apiInstance.InvoicesAddPayment(newPayment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesAddPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newPayment** | [**NewPayment**](NewPayment.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesdeleteinvoice"></a>
# **InvoicesDeleteInvoice**
> void InvoicesDeleteInvoice (string idOrNumber)

Eliminar factura

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesDeleteInvoiceExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var idOrNumber = idOrNumber_example;  // string | 

            try
            {
                // Eliminar factura
                apiInstance.InvoicesDeleteInvoice(idOrNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesDeleteInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idOrNumber** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesget"></a>
# **InvoicesGet**
> InvoiceListItemPage InvoicesGet (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de ventas.

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
    public class InvoicesGetExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de ventas.
                InvoiceListItemPage result = apiInstance.InvoicesGet(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesGet: " + e.Message );
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

[**InvoiceListItemPage**](InvoiceListItemPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesgetbynumber"></a>
# **InvoicesGetByNumber**
> InvoiceDetails InvoicesGetByNumber (string idOrNumber)

Obtiene los detalles de una venta por número

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesGetByNumberExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var idOrNumber = idOrNumber_example;  // string | 

            try
            {
                // Obtiene los detalles de una venta por número
                InvoiceDetails result = apiInstance.InvoicesGetByNumber(idOrNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesGetByNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idOrNumber** | **string**|  | 

### Return type

[**InvoiceDetails**](InvoiceDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesgetpdf"></a>
# **InvoicesGetPDF**
> System.IO.Stream InvoicesGetPDF (Guid? id)

Obtener el PDF de una venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesGetPDFExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = new Guid?(); // Guid? | ID

            try
            {
                // Obtener el PDF de una venta
                System.IO.Stream result = apiInstance.InvoicesGetPDF(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesGetPDF: " + e.Message );
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

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesgetpayment"></a>
# **InvoicesGetPayment**
> PaymentListItemPage InvoicesGetPayment (Guid? invoiceID, string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtener pagos de una factura.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesGetPaymentExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var invoiceID = new Guid?(); // Guid? | 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtener pagos de una factura.
                PaymentListItemPage result = apiInstance.InvoicesGetPayment(invoiceID, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesGetPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoiceID** | [**Guid?**](Guid?.md)|  | 
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

<a name="invoicesgetxml"></a>
# **InvoicesGetXML**
> string InvoicesGetXML (Guid? id)

Obtener el XML de una venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesGetXMLExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = new Guid?(); // Guid? | ID

            try
            {
                // Obtener el XML de una venta
                string result = apiInstance.InvoicesGetXML(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesGetXML: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

