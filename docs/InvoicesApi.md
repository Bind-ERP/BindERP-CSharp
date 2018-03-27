# IO.Swagger.Api.InvoicesApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoicesAddInvoice**](InvoicesApi.md#invoicesaddinvoice) | **POST** /api/Invoices | Agregar factura
[**InvoicesAddPayment**](InvoicesApi.md#invoicesaddpayment) | **POST** /api/Invoices/Payment | Registrar pago a factura
[**InvoicesDeleteInvoice**](InvoicesApi.md#invoicesdeleteinvoice) | **DELETE** /api/Invoices/{id} | Eliminar factura
[**InvoicesGetByID**](InvoicesApi.md#invoicesgetbyid) | **GET** /api/Invoices/{id} | Obtiene los detalles de una venta
[**InvoicesGetByNumber**](InvoicesApi.md#invoicesgetbynumber) | **GET** /api/Invoices | Obtiene los detalles de una venta
[**InvoicesGetPDF**](InvoicesApi.md#invoicesgetpdf) | **GET** /api/Invoices/{id}/pdf | Obtener el PDF de una venta
[**InvoicesGetXML**](InvoicesApi.md#invoicesgetxml) | **GET** /api/Invoices/{id}/xml | Obtener el XML de una venta


<a name="invoicesaddinvoice"></a>
# **InvoicesAddInvoice**
> Guid? InvoicesAddInvoice (NewInvoice newInvoice)

Agregar factura

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
                // Agregar factura
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

Registrar pago a factura

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
                // Registrar pago a factura
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
> void InvoicesDeleteInvoice (Guid? id)

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
            var id = new Guid?(); // Guid? | ID

            try
            {
                // Eliminar factura
                apiInstance.InvoicesDeleteInvoice(id);
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
 **id** | [**Guid?**](Guid?.md)| ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesgetbyid"></a>
# **InvoicesGetByID**
> InvoiceDetails InvoicesGetByID (Guid? id)

Obtiene los detalles de una venta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicesGetByIDExample
    {
        public void main()
        {
            var apiInstance = new InvoicesApi();
            var id = new Guid?(); // Guid? | ID

            try
            {
                // Obtiene los detalles de una venta
                InvoiceDetails result = apiInstance.InvoicesGetByID(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesGetByID: " + e.Message );
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

[**InvoiceDetails**](InvoiceDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicesgetbynumber"></a>
# **InvoicesGetByNumber**
> InvoiceDetails InvoicesGetByNumber (string number)

Obtiene los detalles de una venta

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
            var number = number_example;  // string | Serie y Número

            try
            {
                // Obtiene los detalles de una venta
                InvoiceDetails result = apiInstance.InvoicesGetByNumber(number);
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
 **number** | **string**| Serie y Número | 

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
> Object InvoicesGetPDF (Guid? id)

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
                Object result = apiInstance.InvoicesGetPDF(id);
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

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

