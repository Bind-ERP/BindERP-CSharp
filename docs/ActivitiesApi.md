# IO.Swagger.Api.ActivitiesApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivitiesAddActivity**](ActivitiesApi.md#activitiesaddactivity) | **POST** /api/Activities | Agregar actividad


<a name="activitiesaddactivity"></a>
# **ActivitiesAddActivity**
> void ActivitiesAddActivity (NewActivity newActivity)

Agregar actividad

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActivitiesAddActivityExample
    {
        public void main()
        {
            var apiInstance = new ActivitiesApi();
            var newActivity = new NewActivity(); // NewActivity | 

            try
            {
                // Agregar actividad
                apiInstance.ActivitiesAddActivity(newActivity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivitiesApi.ActivitiesAddActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newActivity** | [**NewActivity**](NewActivity.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

