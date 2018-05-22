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
    ///  Class for testing BankAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BankAccountsApiTests
    {
        private BankAccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BankAccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BankAccountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BankAccountsApi
            //Assert.IsInstanceOfType(typeof(BankAccountsApi), instance, "instance is a BankAccountsApi");
        }

        
        /// <summary>
        /// Test BankAccountsGet
        /// </summary>
        [Test]
        public void BankAccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.BankAccountsGet(filter, orderby, top, skip);
            //Assert.IsInstanceOf<BankAccountPage> (response, "response is BankAccountPage");
        }
        
    }

}
