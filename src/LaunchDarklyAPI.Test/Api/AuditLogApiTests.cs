/* 
 * LaunchDarkly REST API
 *
 * Build custom integrations with the LaunchDarkly REST API
 *
 * OpenAPI spec version: 2.0.3
 * Contact: support@launchdarkly.com
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

using LaunchDarklyAPI.Client;
using LaunchDarklyAPI.Api;
using LaunchDarklyAPI.Model;

namespace LaunchDarklyAPI.Test
{
    /// <summary>
    ///  Class for testing AuditLogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuditLogApiTests
    {
        private AuditLogApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuditLogApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuditLogApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuditLogApi
            //Assert.IsInstanceOfType(typeof(AuditLogApi), instance, "instance is a AuditLogApi");
        }

        
        /// <summary>
        /// Test GetAuditLogEntries
        /// </summary>
        [Test]
        public void GetAuditLogEntriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? before = null;
            //decimal? after = null;
            //string q = null;
            //decimal? limit = null;
            //string spec = null;
            //var response = instance.GetAuditLogEntries(before, after, q, limit, spec);
            //Assert.IsInstanceOf<AuditLogEntries> (response, "response is AuditLogEntries");
        }
        
        /// <summary>
        /// Test GetAuditLogEntry
        /// </summary>
        [Test]
        public void GetAuditLogEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string resourceId = null;
            //var response = instance.GetAuditLogEntry(resourceId);
            //Assert.IsInstanceOf<AuditLogEntry> (response, "response is AuditLogEntry");
        }
        
    }

}
