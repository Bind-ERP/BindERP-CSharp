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
    ///  Class for testing CatalogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CatalogsApiTests
    {
        private CatalogsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CatalogsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CatalogsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CatalogsApi
            //Assert.IsInstanceOfType(typeof(CatalogsApi), instance, "instance is a CatalogsApi");
        }

        
        /// <summary>
        /// Test CatalogsGetBanks
        /// </summary>
        [Test]
        public void CatalogsGetBanksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetBanks(filter, orderby, top, skip);
            //Assert.IsInstanceOf<BankPage> (response, "response is BankPage");
        }
        
        /// <summary>
        /// Test CatalogsGetCategories
        /// </summary>
        [Test]
        public void CatalogsGetCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CatalogsGetCategories();
            //Assert.IsInstanceOf<List<Category1>> (response, "response is List<Category1>");
        }
        
        /// <summary>
        /// Test CatalogsGetCities
        /// </summary>
        [Test]
        public void CatalogsGetCitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? stateID = null;
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetCities(stateID, filter, orderby, top, skip);
            //Assert.IsInstanceOf<CityPage> (response, "response is CityPage");
        }
        
        /// <summary>
        /// Test CatalogsGetCurrencies
        /// </summary>
        [Test]
        public void CatalogsGetCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetCurrencies(filter, orderby, top, skip);
            //Assert.IsInstanceOf<CurrencyPage> (response, "response is CurrencyPage");
        }
        
        /// <summary>
        /// Test CatalogsGetLocations
        /// </summary>
        [Test]
        public void CatalogsGetLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetLocations(filter, orderby, top, skip);
            //Assert.IsInstanceOf<LocationPage> (response, "response is LocationPage");
        }
        
        /// <summary>
        /// Test CatalogsGetPriceLists
        /// </summary>
        [Test]
        public void CatalogsGetPriceListsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetPriceLists(filter, orderby, top, skip);
            //Assert.IsInstanceOf<PriceListPage> (response, "response is PriceListPage");
        }
        
        /// <summary>
        /// Test CatalogsGetSeries
        /// </summary>
        [Test]
        public void CatalogsGetSeriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? docType = null;
            //var response = instance.CatalogsGetSeries(docType);
            //Assert.IsInstanceOf<List<Series>> (response, "response is List<Series>");
        }
        
        /// <summary>
        /// Test CatalogsGetStates
        /// </summary>
        [Test]
        public void CatalogsGetStatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetStates(filter, orderby, top, skip);
            //Assert.IsInstanceOf<StatePage> (response, "response is StatePage");
        }
        
        /// <summary>
        /// Test CatalogsGetUsers
        /// </summary>
        [Test]
        public void CatalogsGetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.CatalogsGetUsers(filter, orderby, top, skip);
            //Assert.IsInstanceOf<UserPage> (response, "response is UserPage");
        }
        
    }

}
