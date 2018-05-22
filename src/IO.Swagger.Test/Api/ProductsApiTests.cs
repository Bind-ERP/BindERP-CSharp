/* 
 * Bind ERP API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductsApiTests
    {
        private ProductsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductsApi
            //Assert.IsInstanceOfType(typeof(ProductsApi), instance, "instance is a ProductsApi");
        }

        
        /// <summary>
        /// Test ProductsAddProduct
        /// </summary>
        [Test]
        public void ProductsAddProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewProduct newProduct = null;
            //var response = instance.ProductsAddProduct(newProduct);
            //Assert.IsInstanceOf<Guid?> (response, "response is Guid?");
        }
        
        /// <summary>
        /// Test ProductsDeleteByID
        /// </summary>
        [Test]
        public void ProductsDeleteByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //instance.ProductsDeleteByID(id);
            
        }
        
        /// <summary>
        /// Test ProductsEditProduct
        /// </summary>
        [Test]
        public void ProductsEditProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EditProduct product = null;
            //instance.ProductsEditProduct(product);
            
        }
        
        /// <summary>
        /// Test ProductsGet
        /// </summary>
        [Test]
        public void ProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.ProductsGet(filter, orderby, top, skip);
            //Assert.IsInstanceOf<ProductPage> (response, "response is ProductPage");
        }
        
        /// <summary>
        /// Test ProductsGetDetail
        /// </summary>
        [Test]
        public void ProductsGetDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //var response = instance.ProductsGetDetail(id);
            //Assert.IsInstanceOf<ProductDetails> (response, "response is ProductDetails");
        }
        
        /// <summary>
        /// Test ProductsGetImage
        /// </summary>
        [Test]
        public void ProductsGetImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //var response = instance.ProductsGetImage(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
