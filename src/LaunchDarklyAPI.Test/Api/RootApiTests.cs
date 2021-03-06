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
    ///  Class for testing RootApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RootApiTests
    {
        private RootApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RootApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RootApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RootApi
            //Assert.IsInstanceOfType(typeof(RootApi), instance, "instance is a RootApi");
        }

        
        /// <summary>
        /// Test GetRoot
        /// </summary>
        [Test]
        public void GetRootTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoot();
            //Assert.IsInstanceOf<Links> (response, "response is Links");
        }
        
    }

}
