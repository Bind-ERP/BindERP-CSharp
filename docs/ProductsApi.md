# IO.Swagger.Api.ProductsApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductsAddProduct**](ProductsApi.md#productsaddproduct) | **POST** /api/Products | Agregar Producto
[**ProductsDeleteByID**](ProductsApi.md#productsdeletebyid) | **DELETE** /api/Products/{id} | Borrar Producto
[**ProductsEditProduct**](ProductsApi.md#productseditproduct) | **PUT** /api/Products | Editar Producto
[**ProductsGet**](ProductsApi.md#productsget) | **GET** /api/Products | Obtiene la lista de productos.
[**ProductsGetDetail**](ProductsApi.md#productsgetdetail) | **GET** /api/Products/{id} | Obtiene los detalles de un producto.
[**ProductsGetImage**](ProductsApi.md#productsgetimage) | **GET** /api/Products/{id}/image | Obtiene la imagen del producto.


<a name="productsaddproduct"></a>
# **ProductsAddProduct**
> Guid? ProductsAddProduct (NewProduct newProduct)

Agregar Producto

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsAddProductExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var newProduct = new NewProduct(); // NewProduct | 

            try
            {
                // Agregar Producto
                Guid? result = apiInstance.ProductsAddProduct(newProduct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsAddProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newProduct** | [**NewProduct**](NewProduct.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsdeletebyid"></a>
# **ProductsDeleteByID**
> void ProductsDeleteByID (Guid? id)

Borrar Producto

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsDeleteByIDExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Borrar Producto
                apiInstance.ProductsDeleteByID(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsDeleteByID: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productseditproduct"></a>
# **ProductsEditProduct**
> void ProductsEditProduct (EditProduct product)

Editar Producto

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsEditProductExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var product = new EditProduct(); // EditProduct | 

            try
            {
                // Editar Producto
                apiInstance.ProductsEditProduct(product);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsEditProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | [**EditProduct**](EditProduct.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsget"></a>
# **ProductsGet**
> ProductPage ProductsGet (string filter = null, string orderby = null, int? top = null, int? skip = null)

Obtiene la lista de productos.

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
    public class ProductsGetExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var filter = filter_example;  // string | Filters the results, based on a Boolean condition. (optional) 
            var orderby = orderby_example;  // string | Sorts the results. (optional) 
            var top = 56;  // int? | Returns only the first n results. (optional) 
            var skip = 56;  // int? | Skips the first n results. (optional) 

            try
            {
                // Obtiene la lista de productos.
                ProductPage result = apiInstance.ProductsGet(filter, orderby, top, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsGet: " + e.Message );
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

[**ProductPage**](ProductPage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsgetdetail"></a>
# **ProductsGetDetail**
> ProductDetails ProductsGetDetail (Guid? id)

Obtiene los detalles de un producto.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsGetDetailExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Obtiene los detalles de un producto.
                ProductDetails result = apiInstance.ProductsGetDetail(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsGetDetail: " + e.Message );
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

[**ProductDetails**](ProductDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsgetimage"></a>
# **ProductsGetImage**
> string ProductsGetImage (Guid? id)

Obtiene la imagen del producto.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProductsGetImageExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // Obtiene la imagen del producto.
                string result = apiInstance.ProductsGetImage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsGetImage: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

