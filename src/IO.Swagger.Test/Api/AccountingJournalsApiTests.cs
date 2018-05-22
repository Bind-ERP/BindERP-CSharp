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
    ///  Class for testing AccountingJournalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountingJournalsApiTests
    {
        private AccountingJournalsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountingJournalsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountingJournalsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountingJournalsApi
            //Assert.IsInstanceOfType(typeof(AccountingJournalsApi), instance, "instance is a AccountingJournalsApi");
        }

        
        /// <summary>
        /// Test AccountingJournalsAddAccountingJournal
        /// </summary>
        [Test]
        public void AccountingJournalsAddAccountingJournalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewAccountingJournal newAccountingJournal = null;
            //var response = instance.AccountingJournalsAddAccountingJournal(newAccountingJournal);
            //Assert.IsInstanceOf<Guid?> (response, "response is Guid?");
        }
        
        /// <summary>
        /// Test AccountingJournalsDeleteAccountingJournal
        /// </summary>
        [Test]
        public void AccountingJournalsDeleteAccountingJournalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid?> idList = null;
            //instance.AccountingJournalsDeleteAccountingJournal(idList);
            
        }
        
        /// <summary>
        /// Test AccountingJournalsEditAccountingJournal
        /// </summary>
        [Test]
        public void AccountingJournalsEditAccountingJournalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EditAccountingJournal accountingJournal = null;
            //var response = instance.AccountingJournalsEditAccountingJournal(accountingJournal);
            //Assert.IsInstanceOf<Guid?> (response, "response is Guid?");
        }
        
        /// <summary>
        /// Test AccountingJournalsGet
        /// </summary>
        [Test]
        public void AccountingJournalsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderby = null;
            //int? top = null;
            //int? skip = null;
            //var response = instance.AccountingJournalsGet(filter, orderby, top, skip);
            //Assert.IsInstanceOf<AccountingJournalPage> (response, "response is AccountingJournalPage");
        }
        
    }

}
