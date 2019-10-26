/* 
 * Known Pose API
 *
 * Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
 *
 * OpenAPI spec version: 1.1.0
 * Contact: Kai.Waelti@dfki.de
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
    ///  Class for testing Position
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PositionTests
    {
        // TODO uncomment below to declare an instance variable for Position
        //private Position instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Position
            //instance = new Position();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Position
        /// </summary>
        [Test]
        public void PositionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Position
            //Assert.IsInstanceOfType<Position> (instance, "variable 'instance' is a Position");
        }


        /// <summary>
        /// Test the property 'X'
        /// </summary>
        [Test]
        public void XTest()
        {
            // TODO unit test for the property 'X'
        }
        /// <summary>
        /// Test the property 'Y'
        /// </summary>
        [Test]
        public void YTest()
        {
            // TODO unit test for the property 'Y'
        }
        /// <summary>
        /// Test the property 'Z'
        /// </summary>
        [Test]
        public void ZTest()
        {
            // TODO unit test for the property 'Z'
        }

    }

}
