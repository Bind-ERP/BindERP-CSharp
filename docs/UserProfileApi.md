# IO.Swagger.Api.UserProfileApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserProfileGet**](UserProfileApi.md#userprofileget) | **GET** /api/UserProfile | Obtiene la lista de cuentas contables.


<a name="userprofileget"></a>
# **UserProfileGet**
> UserProfile UserProfileGet ()

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
    public class UserProfileGetExample
    {
        public void main()
        {
            var apiInstance = new UserProfileApi();

            try
            {
                // Obtiene la lista de cuentas contables.
                UserProfile result = apiInstance.UserProfileGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.UserProfileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

