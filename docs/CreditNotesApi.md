# IO.Swagger.Api.CreditNotesApi

All URIs are relative to *http://api.bind.com.mx*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreditNotesAddCreditNote**](CreditNotesApi.md#creditnotesaddcreditnote) | **POST** /api/CreditNotes | Agregar Nota de Crédito


<a name="creditnotesaddcreditnote"></a>
# **CreditNotesAddCreditNote**
> Guid? CreditNotesAddCreditNote (NewCreditNote newCreditNote)

Agregar Nota de Crédito

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreditNotesAddCreditNoteExample
    {
        public void main()
        {
            var apiInstance = new CreditNotesApi();
            var newCreditNote = new NewCreditNote(); // NewCreditNote | 

            try
            {
                // Agregar Nota de Crédito
                Guid? result = apiInstance.CreditNotesAddCreditNote(newCreditNote);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreditNotesAddCreditNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newCreditNote** | [**NewCreditNote**](NewCreditNote.md)|  | 

### Return type

**Guid?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

