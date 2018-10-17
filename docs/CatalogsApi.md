# IO.Swagger.Api.CatalogsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CatalogsGetBanks**](CatalogsApi.md#catalogsgetbanks) | **GET** /api/Banks | Obtiene la lista de bancos.
[**CatalogsGetCategories**](CatalogsApi.md#catalogsgetcategories) | **GET** /api/Categories | Obtiene la lista de Categorias.
[**CatalogsGetCities**](CatalogsApi.md#catalogsgetcities) | **GET** /api/Cities | Obtiene la lista de Ciudades por estado.
[**CatalogsGetCurrencies**](CatalogsApi.md#catalogsgetcurrencies) | **GET** /api/Currencies | Obtiene la lista de monedas.
[**CatalogsGetLocations**](CatalogsApi.md#catalogsgetlocations) | **GET** /api/Locations | Obtiene la lista de sucursales.
[**CatalogsGetPriceLists**](CatalogsApi.md#catalogsgetpricelists) | **GET** /api/PriceLists | Obtiene la lista de precios.
[**CatalogsGetSeries**](CatalogsApi.md#catalogsgetseries) | **GET** /api/Series | Obtiene la lista de Series.
[**CatalogsGetStates**](CatalogsApi.md#catalogsgetstates) | **GET** /api/States | Obtiene la lista de Estados.
[**CatalogsGetUsers**](CatalogsApi.md#catalogsgetusers) | **GET** /api/Users | Obtiene la lista de usuarios.


<a name="catalogsgetbanks"></a>
# **CatalogsGetBanks**
> BankPage CatalogsGetBanks (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de bancos.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetBanksExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de bancos.
                BankPage result = apiInstance.CatalogsGetBanks(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetBanks: " + e.Message );
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

[**BankPage**](BankPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetcategories"></a>
# **CatalogsGetCategories**
> List<Category1> CatalogsGetCategories ()

Obtiene la lista de Categorias.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetCategoriesExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();

            try
            {
                // Obtiene la lista de Categorias.
                List&lt;Category1&gt; result = apiInstance.CatalogsGetCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Category1>**](Category1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetcities"></a>
# **CatalogsGetCities**
> CityPage CatalogsGetCities (Guid? stateID, string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de Ciudades por estado.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetCitiesExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var stateID = new Guid?(); // Guid? | 
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de Ciudades por estado.
                CityPage result = apiInstance.CatalogsGetCities(stateID, filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetCities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stateID** | [**Guid?**](Guid?.md)|  | 
 **filter** | **string**| Filters the results, based on a Boolean condition. | [optional] 
 **orderby** | **string**| Sorts the results. | [optional] 
 **top** | **int?**| Returns only the first n results. | [optional] 
 **skip** | **int?**| Skips the first n results. | [optional] 

### Return type

[**CityPage**](CityPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetcurrencies"></a>
# **CatalogsGetCurrencies**
> CurrencyPage CatalogsGetCurrencies (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de monedas.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetCurrenciesExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de monedas.
                CurrencyPage result = apiInstance.CatalogsGetCurrencies(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetCurrencies: " + e.Message );
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

[**CurrencyPage**](CurrencyPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetlocations"></a>
# **CatalogsGetLocations**
> LocationPage CatalogsGetLocations (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de sucursales.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetLocationsExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de sucursales.
                LocationPage result = apiInstance.CatalogsGetLocations(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetLocations: " + e.Message );
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

[**LocationPage**](LocationPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetpricelists"></a>
# **CatalogsGetPriceLists**
> PriceListPage CatalogsGetPriceLists (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de precios.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetPriceListsExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de precios.
                PriceListPage result = apiInstance.CatalogsGetPriceLists(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetPriceLists: " + e.Message );
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

[**PriceListPage**](PriceListPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetseries"></a>
# **CatalogsGetSeries**
> List<Series> CatalogsGetSeries (int? docType)

Obtiene la lista de Series.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetSeriesExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var docType = 56;  // int? | 

            try
            {
                // Obtiene la lista de Series.
                List&lt;Series&gt; result = apiInstance.CatalogsGetSeries(docType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetSeries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **docType** | **int?**|  | 

### Return type

[**List<Series>**](Series.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetstates"></a>
# **CatalogsGetStates**
> StatePage CatalogsGetStates (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de Estados.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetStatesExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de Estados.
                StatePage result = apiInstance.CatalogsGetStates(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetStates: " + e.Message );
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

[**StatePage**](StatePage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsgetusers"></a>
# **CatalogsGetUsers**
> UserPage CatalogsGetUsers (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de usuarios.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogsGetUsersExample
    {
        public void main()
        {
            var apiInstance = new CatalogsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de usuarios.
                UserPage result = apiInstance.CatalogsGetUsers(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsApi.CatalogsGetUsers: " + e.Message );
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

[**UserPage**](UserPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

