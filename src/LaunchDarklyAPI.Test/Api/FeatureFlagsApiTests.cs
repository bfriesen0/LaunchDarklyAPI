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
    ///  Class for testing FeatureFlagsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FeatureFlagsApiTests
    {
        private FeatureFlagsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FeatureFlagsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeatureFlagsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FeatureFlagsApi
            //Assert.IsInstanceOfType(typeof(FeatureFlagsApi), instance, "instance is a FeatureFlagsApi");
        }

        
        /// <summary>
        /// Test DeleteFeatureFlag
        /// </summary>
        [Test]
        public void DeleteFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string featureFlagKey = null;
            //instance.DeleteFeatureFlag(projectKey, featureFlagKey);
            
        }
        
        /// <summary>
        /// Test GetFeatureFlag
        /// </summary>
        [Test]
        public void GetFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string featureFlagKey = null;
            //string env = null;
            //var response = instance.GetFeatureFlag(projectKey, featureFlagKey, env);
            //Assert.IsInstanceOf<FeatureFlag> (response, "response is FeatureFlag");
        }
        
        /// <summary>
        /// Test GetFeatureFlagStatus
        /// </summary>
        [Test]
        public void GetFeatureFlagStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //string featureFlagKey = null;
            //var response = instance.GetFeatureFlagStatus(projectKey, environmentKey, featureFlagKey);
            //Assert.IsInstanceOf<FeatureFlagStatus> (response, "response is FeatureFlagStatus");
        }
        
        /// <summary>
        /// Test GetFeatureFlagStatuses
        /// </summary>
        [Test]
        public void GetFeatureFlagStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string environmentKey = null;
            //var response = instance.GetFeatureFlagStatuses(projectKey, environmentKey);
            //Assert.IsInstanceOf<FeatureFlagStatuses> (response, "response is FeatureFlagStatuses");
        }
        
        /// <summary>
        /// Test GetFeatureFlags
        /// </summary>
        [Test]
        public void GetFeatureFlagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string env = null;
            //string tag = null;
            //var response = instance.GetFeatureFlags(projectKey, env, tag);
            //Assert.IsInstanceOf<FeatureFlags> (response, "response is FeatureFlags");
        }
        
        /// <summary>
        /// Test PatchFeatureFlag
        /// </summary>
        [Test]
        public void PatchFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //string featureFlagKey = null;
            //PatchComment patchComment = null;
            //var response = instance.PatchFeatureFlag(projectKey, featureFlagKey, patchComment);
            //Assert.IsInstanceOf<FeatureFlag> (response, "response is FeatureFlag");
        }
        
        /// <summary>
        /// Test PostFeatureFlag
        /// </summary>
        [Test]
        public void PostFeatureFlagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectKey = null;
            //FeatureFlagBody featureFlagBody = null;
            //instance.PostFeatureFlag(projectKey, featureFlagBody);
            
        }
        
    }

}
