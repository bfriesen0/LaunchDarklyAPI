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
    ///  Class for testing UserSegmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserSegmentsApiTests
    {
        private UserSegmentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserSegmentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserSegmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserSegmentsApi
            //Assert.IsInstanceOfType(typeof(UserSegmentsApi), instance, "instance is a UserSegmentsApi");
        }

        
        /// <summary>
        /// Test DeleteUserSegment
        /// </summary>
        [Test]
        public void DeleteUserSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //string userSegmentKey = null;
            //instance.DeleteUserSegment(projectKey, environmentKey, userSegmentKey);
            
        }
        
        /// <summary>
        /// Test GetUserSegment
        /// </summary>
        [Test]
        public void GetUserSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //string userSegmentKey = null;
            //var response = instance.GetUserSegment(projectKey, environmentKey, userSegmentKey);
            //Assert.IsInstanceOf<UserSegment> (response, "response is UserSegment");
        }
        
        /// <summary>
        /// Test GetUserSegments
        /// </summary>
        [Test]
        public void GetUserSegmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //string tag = null;
            //var response = instance.GetUserSegments(projectKey, environmentKey, tag);
            //Assert.IsInstanceOf<UserSegments> (response, "response is UserSegments");
        }
        
        /// <summary>
        /// Test PatchUserSegment
        /// </summary>
        [Test]
        public void PatchUserSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //string userSegmentKey = null;
            //List<PatchOperation> patchOnly = null;
            //var response = instance.PatchUserSegment(projectKey, environmentKey, userSegmentKey, patchOnly);
            //Assert.IsInstanceOf<UserSegment> (response, "response is UserSegment");
        }
        
        /// <summary>
        /// Test PostUserSegment
        /// </summary>
        [Test]
        public void PostUserSegmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //UserSegmentBody userSegmentBody = null;
            //instance.PostUserSegment(projectKey, environmentKey, userSegmentBody);
            
        }
        
    }

}
