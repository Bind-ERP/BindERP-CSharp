# IO.Swagger.Api.AccountsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsAddClient**](AccountsApi.md#accountsaddclient) | **POST** /api/Accounts | Agregar Cuenta Contable
[**AccountsDeleteAccount**](AccountsApi.md#accountsdeleteaccount) | **DELETE** /api/Accounts/{id} | Borrar Cuenta Contable
[**AccountsGetAccountCategories**](AccountsApi.md#accountsgetaccountcategories) | **GET** /api/AccountCategories | Obtiene las categorías de cuentas contables.
[**AccountsGetPriceLists**](AccountsApi.md#accountsgetpricelists) | **GET** /api/Accounts | Obtiene la lista de cuentas contables.


<a name="accountsaddclient"></a>
# **AccountsAddClient**
> Guid? AccountsAddClient (NewAccount newAccount)

Agregar Cuenta Contable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsAddClientExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var newAccount = new NewAccount(); // NewAccount | 

            try
            {
                // Agregar Cuenta Contable
                Guid? result = apiInstance.AccountsAddClient(newAccount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsAddClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newAccount** | [**NewAccount**](NewAccount.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsdeleteaccount"></a>
# **AccountsDeleteAccount**
> void AccountsDeleteAccount (Guid? id, Guid? replacementID = null)

Borrar Cuenta Contable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsDeleteAccountExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var id = new Guid?(); // Guid? | 
            var replacementID = new Guid?(); // Guid? |  (optional) 

            try
            {
                // Borrar Cuenta Contable
                apiInstance.AccountsDeleteAccount(id, replacementID);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsDeleteAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **replacementID** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetaccountcategories"></a>
# **AccountsGetAccountCategories**
> AccountCategories AccountsGetAccountCategories ()

Obtiene las categorías de cuentas contables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetAccountCategoriesExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();

            try
            {
                // Obtiene las categorías de cuentas contables.
                AccountCategories result = apiInstance.AccountsGetAccountCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetAccountCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountCategories**](AccountCategories.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsgetpricelists"></a>
# **AccountsGetPriceLists**
> AccountPage AccountsGetPriceLists (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de cuentas contables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountsGetPriceListsExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de cuentas contables.
                AccountPage result = apiInstance.AccountsGetPriceLists(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsGetPriceLists: " + e.Message );
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

[**AccountPage**](AccountPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

