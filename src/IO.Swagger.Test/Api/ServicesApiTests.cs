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
    ///  Class for testing ServicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ServicesApiTests
    {
        private ServicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ServicesApi
            //Assert.IsInstanceOfType(typeof(ServicesApi), instance, "instance is a ServicesApi");
        }

        
        /// <summary>
        /// Test ServicesAddProduct
        /// </summary>
        [Test]
        public void ServicesAddProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewService newService = null;
            //var response = instance.ServicesAddProduct(newService);
            //Assert.IsInstanceOf<Guid?> (response, "response is Guid?");
        }
        
        /// <summary>
        /// Test ServicesDeleteByID
        /// </summary>
        [Test]
        public void ServicesDeleteByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //instance.ServicesDeleteByID(id);
            
        }
        
        /// <summary>
        /// Test ServicesEditProduct
        /// </summary>
        [Test]
        public void ServicesEditProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EditService service = null;
            //instance.ServicesEditProduct(service);
            
        }
        
        /// <summary>
        /// Test ServicesGetDetail
        /// </summary>
        [Test]
        public void ServicesGetDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //var response = instance.ServicesGetDetail(id);
            //Assert.IsInstanceOf<ServiceDetails> (response, "response is ServiceDetails");
        }
        
        /// <summary>
        /// Test ServicesGetServices
        /// </summary>
        [Test]
        public void ServicesGetServicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.ServicesGetServices(filter, orderby, top, skip);
            //Assert.IsInstanceOf<ServicesPage> (response, "response is ServicesPage");
        }
        
    }

}
