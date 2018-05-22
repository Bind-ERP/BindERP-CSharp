# IO.Swagger.Model.NewInvoice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyID** | **Guid?** |  | 
**ClientID** | **Guid?** |  | 
**LocationID** | **Guid?** |  | 
**WarehouseID** | **Guid?** |  | 
**CFDIUse** | **int?** |  | 
**InvoiceDate** | **DateTime?** |  | 
**PriceListID** | **Guid?** |  | 
**ExchangeRate** | **double?** |  | [optional] 
**ISRRetRate** | **double?** |  | [optional] 
**VATRetRate** | **double?** |  | [optional] 
**Comments** | **string** |  | [optional] 
**VATRate** | **double?** |  | [optional] 
**DiscountType** | **int?** |  | [optional] 
**DiscountAmount** | **double?** |  | [optional] 
**Products** | [**List&lt;NewInvoiceProduct&gt;**](NewInvoiceProduct.md) |  | [optional] 
**Services** | [**List&lt;NewInvoiceService&gt;**](NewInvoiceService.md) |  | [optional] 
**Emails** | **List&lt;string&gt;** |  | [optional] 
**PurchaseOrder** | **string** |  | [optional] 
**CreditDays** | **int?** |  | [optional] 
**IsFiscalInvoice** | **bool?** |  | [optional] 
**ShowIEPS** | **bool?** |  | [optional] 
**Number** | **long?** |  | [optional] 
**Account** | **string** |  | [optional] 
**Payments** | [**List&lt;NewInvoicePayment&gt;**](NewInvoicePayment.md) |  | [optional] 
**Serie** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

