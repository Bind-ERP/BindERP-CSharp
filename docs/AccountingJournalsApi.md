# IO.Swagger.Api.AccountingJournalsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountingJournalsAddAccountingJournal**](AccountingJournalsApi.md#accountingjournalsaddaccountingjournal) | **POST** /api/AccountingJournals | Agregar póliza contable
[**AccountingJournalsDeleteAccountingJournal**](AccountingJournalsApi.md#accountingjournalsdeleteaccountingjournal) | **DELETE** /api/AccountingJournals | Eliminar póliza contable
[**AccountingJournalsEditAccountingJournal**](AccountingJournalsApi.md#accountingjournalseditaccountingjournal) | **PUT** /api/AccountingJournals | Editar póliza contable
[**AccountingJournalsGet**](AccountingJournalsApi.md#accountingjournalsget) | **GET** /api/AccountingJournals | Obtiene la lista de pólizas contables.


<a name="accountingjournalsaddaccountingjournal"></a>
# **AccountingJournalsAddAccountingJournal**
> Guid? AccountingJournalsAddAccountingJournal (NewAccountingJournal newAccountingJournal)

Agregar póliza contable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountingJournalsAddAccountingJournalExample
    {
        public void main()
        {
            var apiInstance = new AccountingJournalsApi();
            var newAccountingJournal = new NewAccountingJournal(); // NewAccountingJournal | 

            try
            {
                // Agregar póliza contable
                Guid? result = apiInstance.AccountingJournalsAddAccountingJournal(newAccountingJournal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingJournalsApi.AccountingJournalsAddAccountingJournal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newAccountingJournal** | [**NewAccountingJournal**](NewAccountingJournal.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountingjournalsdeleteaccountingjournal"></a>
# **AccountingJournalsDeleteAccountingJournal**
> void AccountingJournalsDeleteAccountingJournal (List<Guid?> idList)

Eliminar póliza contable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountingJournalsDeleteAccountingJournalExample
    {
        public void main()
        {
            var apiInstance = new AccountingJournalsApi();
            var idList = ;  // List<Guid?> | 

            try
            {
                // Eliminar póliza contable
                apiInstance.AccountingJournalsDeleteAccountingJournal(idList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingJournalsApi.AccountingJournalsDeleteAccountingJournal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idList** | **List&lt;Guid?&gt;**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountingjournalseditaccountingjournal"></a>
# **AccountingJournalsEditAccountingJournal**
> Guid? AccountingJournalsEditAccountingJournal (EditAccountingJournal accountingJournal)

Editar póliza contable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountingJournalsEditAccountingJournalExample
    {
        public void main()
        {
            var apiInstance = new AccountingJournalsApi();
            var accountingJournal = new EditAccountingJournal(); // EditAccountingJournal | 

            try
            {
                // Editar póliza contable
                Guid? result = apiInstance.AccountingJournalsEditAccountingJournal(accountingJournal);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingJournalsApi.AccountingJournalsEditAccountingJournal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountingJournal** | [**EditAccountingJournal**](EditAccountingJournal.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountingjournalsget"></a>
# **AccountingJournalsGet**
> AccountingJournalPage AccountingJournalsGet (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de pólizas contables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountingJournalsGetExample
    {
        public void main()
        {
            var apiInstance = new AccountingJournalsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de pólizas contables.
                AccountingJournalPage result = apiInstance.AccountingJournalsGet(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountingJournalsApi.AccountingJournalsGet: " + e.Message );
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

[**AccountingJournalPage**](AccountingJournalPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

