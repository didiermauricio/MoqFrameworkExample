using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BreakingDependencies;
using BreakingDependencies.Example;

namespace DependencyInyByParameters
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InformationService_WhenIdDoesNotExists_ResultIsTrue()
        {
            //Arrange

            var dataReader = new Mock<IDataReader>();

            dataReader.Setup(dr => dr.ReadUserInfoFromDB("123456")).Returns("Found!");
            
            var service = new InformationService(dataReader.Object);

            //Act
            var result = service.RequestInfomation();

            //Assert
            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void InformationService_WhenIdDoesNotExists_ResultIsFalse()
        {
            //Arrange

            var dataReader = new Mock<IDataReader>();

            dataReader.Setup(dr => dr.ReadUserInfoFromDB("123456")).Returns(string.Empty);

            var service = new InformationService(dataReader.Object);

            //Act
            var result = service.RequestInfomation();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
