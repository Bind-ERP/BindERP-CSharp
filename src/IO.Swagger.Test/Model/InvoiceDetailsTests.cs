/* 
 * Bind ERP API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing InvoiceDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InvoiceDetailsTests
    {
        // TODO uncomment below to declare an instance variable for InvoiceDetails
        //private InvoiceDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvoiceDetails
            //instance = new InvoiceDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoiceDetails
        /// </summary>
        [Test]
        public void InvoiceDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvoiceDetails
            //Assert.IsInstanceOfType<InvoiceDetails> (instance, "variable 'instance' is a InvoiceDetails");
        }


        /// <summary>
        /// Test the property 'ID'
        /// </summary>
        [Test]
        public void IDTest()
        {
            // TODO unit test for the property 'ID'
        }
        /// <summary>
        /// Test the property 'UUID'
        /// </summary>
        [Test]
        public void UUIDTest()
        {
            // TODO unit test for the property 'UUID'
        }
        /// <summary>
        /// Test the property 'Series'
        /// </summary>
        [Test]
        public void SeriesTest()
        {
            // TODO unit test for the property 'Series'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'ClientID'
        /// </summary>
        [Test]
        public void ClientIDTest()
        {
            // TODO unit test for the property 'ClientID'
        }
        /// <summary>
        /// Test the property 'ClientName'
        /// </summary>
        [Test]
        public void ClientNameTest()
        {
            // TODO unit test for the property 'ClientName'
        }
        /// <summary>
        /// Test the property 'PaymentTerms'
        /// </summary>
        [Test]
        public void PaymentTermsTest()
        {
            // TODO unit test for the property 'PaymentTerms'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'StatusCode'
        /// </summary>
        [Test]
        public void StatusCodeTest()
        {
            // TODO unit test for the property 'StatusCode'
        }
        /// <summary>
        /// Test the property 'ClientPhoneNumber'
        /// </summary>
        [Test]
        public void ClientPhoneNumberTest()
        {
            // TODO unit test for the property 'ClientPhoneNumber'
        }
        /// <summary>
        /// Test the property 'ClientContact'
        /// </summary>
        [Test]
        public void ClientContactTest()
        {
            // TODO unit test for the property 'ClientContact'
        }
        /// <summary>
        /// Test the property 'RFC'
        /// </summary>
        [Test]
        public void RFCTest()
        {
            // TODO unit test for the property 'RFC'
        }
        /// <summary>
        /// Test the property 'CreatedByID'
        /// </summary>
        [Test]
        public void CreatedByIDTest()
        {
            // TODO unit test for the property 'CreatedByID'
        }
        /// <summary>
        /// Test the property 'CreatedByName'
        /// </summary>
        [Test]
        public void CreatedByNameTest()
        {
            // TODO unit test for the property 'CreatedByName'
        }
        /// <summary>
        /// Test the property 'CreationDate'
        /// </summary>
        [Test]
        public void CreationDateTest()
        {
            // TODO unit test for the property 'CreationDate'
        }
        /// <summary>
        /// Test the property 'ApplicationDate'
        /// </summary>
        [Test]
        public void ApplicationDateTest()
        {
            // TODO unit test for the property 'ApplicationDate'
        }
        /// <summary>
        /// Test the property 'PriceListID'
        /// </summary>
        [Test]
        public void PriceListIDTest()
        {
            // TODO unit test for the property 'PriceListID'
        }
        /// <summary>
        /// Test the property 'PriceListName'
        /// </summary>
        [Test]
        public void PriceListNameTest()
        {
            // TODO unit test for the property 'PriceListName'
        }
        /// <summary>
        /// Test the property 'LocationID'
        /// </summary>
        [Test]
        public void LocationIDTest()
        {
            // TODO unit test for the property 'LocationID'
        }
        /// <summary>
        /// Test the property 'LocationName'
        /// </summary>
        [Test]
        public void LocationNameTest()
        {
            // TODO unit test for the property 'LocationName'
        }
        /// <summary>
        /// Test the property 'WarehouseID'
        /// </summary>
        [Test]
        public void WarehouseIDTest()
        {
            // TODO unit test for the property 'WarehouseID'
        }
        /// <summary>
        /// Test the property 'WarehouseName'
        /// </summary>
        [Test]
        public void WarehouseNameTest()
        {
            // TODO unit test for the property 'WarehouseName'
        }
        /// <summary>
        /// Test the property 'CFDIPaymentMethod'
        /// </summary>
        [Test]
        public void CFDIPaymentMethodTest()
        {
            // TODO unit test for the property 'CFDIPaymentMethod'
        }
        /// <summary>
        /// Test the property 'CFDIPaymentTerm'
        /// </summary>
        [Test]
        public void CFDIPaymentTermTest()
        {
            // TODO unit test for the property 'CFDIPaymentTerm'
        }
        /// <summary>
        /// Test the property 'CFDIAccountNumber'
        /// </summary>
        [Test]
        public void CFDIAccountNumberTest()
        {
            // TODO unit test for the property 'CFDIAccountNumber'
        }
        /// <summary>
        /// Test the property 'CurrencyName'
        /// </summary>
        [Test]
        public void CurrencyNameTest()
        {
            // TODO unit test for the property 'CurrencyName'
        }
        /// <summary>
        /// Test the property 'ExchangeRate'
        /// </summary>
        [Test]
        public void ExchangeRateTest()
        {
            // TODO unit test for the property 'ExchangeRate'
        }
        /// <summary>
        /// Test the property 'PurchaseOrder'
        /// </summary>
        [Test]
        public void PurchaseOrderTest()
        {
            // TODO unit test for the property 'PurchaseOrder'
        }
        /// <summary>
        /// Test the property 'FiscalID'
        /// </summary>
        [Test]
        public void FiscalIDTest()
        {
            // TODO unit test for the property 'FiscalID'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'Comments'
        /// </summary>
        [Test]
        public void CommentsTest()
        {
            // TODO unit test for the property 'Comments'
        }
        /// <summary>
        /// Test the property 'Subtotal'
        /// </summary>
        [Test]
        public void SubtotalTest()
        {
            // TODO unit test for the property 'Subtotal'
        }
        /// <summary>
        /// Test the property 'Discount'
        /// </summary>
        [Test]
        public void DiscountTest()
        {
            // TODO unit test for the property 'Discount'
        }
        /// <summary>
        /// Test the property 'VAT'
        /// </summary>
        [Test]
        public void VATTest()
        {
            // TODO unit test for the property 'VAT'
        }
        /// <summary>
        /// Test the property 'IEPS'
        /// </summary>
        [Test]
        public void IEPSTest()
        {
            // TODO unit test for the property 'IEPS'
        }
        /// <summary>
        /// Test the property 'VATRet'
        /// </summary>
        [Test]
        public void VATRetTest()
        {
            // TODO unit test for the property 'VATRet'
        }
        /// <summary>
        /// Test the property 'ISRRet'
        /// </summary>
        [Test]
        public void ISRRetTest()
        {
            // TODO unit test for the property 'ISRRet'
        }
        /// <summary>
        /// Test the property 'Payments'
        /// </summary>
        [Test]
        public void PaymentsTest()
        {
            // TODO unit test for the property 'Payments'
        }
        /// <summary>
        /// Test the property 'CreditNotes'
        /// </summary>
        [Test]
        public void CreditNotesTest()
        {
            // TODO unit test for the property 'CreditNotes'
        }
        /// <summary>
        /// Test the property 'Products'
        /// </summary>
        [Test]
        public void ProductsTest()
        {
            // TODO unit test for the property 'Products'
        }
        /// <summary>
        /// Test the property 'Services'
        /// </summary>
        [Test]
        public void ServicesTest()
        {
            // TODO unit test for the property 'Services'
        }

    }

}
