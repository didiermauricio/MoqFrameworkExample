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
