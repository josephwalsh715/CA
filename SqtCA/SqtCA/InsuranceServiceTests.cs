using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SqtCA
{


    [TestFixture]
    public class InsuranceServiceTests
    {
        /*
         * this is for question (iv)
         */

        private InsuranceService _insuranceService;

        [SetUp]
        public void Setup()
        {
            _insuranceService = new InsuranceService();
        }

        [Test]
        public void Test_Rural_Location_Age_Between_18_And_30()
        {
            double premium = _insuranceService.CalcPremium(25, "rural");
            Assert.AreEqual(5.0, premium);
        }

        [Test]
        public void Test_Rural_Location_Age_31_Or_Above()
        {
            double premium = _insuranceService.CalcPremium(31, "rural");
            Assert.AreEqual(2.50, premium);
        }

        [Test]
        public void Test_Rural_Location_Age_Below_18()
        {
            double premium = _insuranceService.CalcPremium(17, "rural");
            Assert.AreEqual(0.0, premium);
        }

        [Test]
        public void Test_Urban_Location_Age_Between_18_And_35()
        {
            double premium = _insuranceService.CalcPremium(25, "urban");
            Assert.AreEqual(6.0, premium);
        }

        [Test]
        public void Test_Urban_Location_Age_36_Or_Above()
        {
            double premium = _insuranceService.CalcPremium(36, "urban");
            Assert.AreEqual(5.0, premium);
        }

        [Test]
        public void Test_Urban_Location_Age_Below_18()
        {
            double premium = _insuranceService.CalcPremium(17, "urban");
            Assert.AreEqual(0.0, premium);
        }

        [Test]
        public void Test_Unknown_Location()
        {
            double premium = _insuranceService.CalcPremium(25, "unknown");
            Assert.AreEqual(0.0, premium);
        }

        [Test]
        public void Test_Age_50_Or_Above()
        {
            double premium = _insuranceService.CalcPremium(50, "rural");
            Assert.AreEqual(2.50, premium);
        }

        [Test]
        public void Test_Age_Below_50()
        {
            double premium = _insuranceService.CalcPremium(40, "rural");
            Assert.AreEqual(2.50, premium);
        }

        /*
         *this is for question (v) 
         */

        //private InsuranceService _service;
        //private Mock<IDiscountService> _discountServiceMock;

        //[SetUp]
        //public void Setup()
        //{
        //    _discountServiceMock = new Mock<IDiscountService>();
        //    _service = new InsuranceService(_discountServiceMock.Object);
        //}

        //[Test]
        //public void CalcPremium_Rural18_Returns5()
        //{
        //    // Arrange
        //    int age = 18;
        //    string location = "rural";
        //    double expected = 5.0;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Rural30_Returns2_5()
        //{
        //    // Arrange
        //    int age = 30;
        //    string location = "rural";
        //    double expected = 2.5;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Rural31_Returns2_5()
        //{
        //    // Arrange
        //    int age = 31;
        //    string location = "rural";
        //    double expected = 2.5;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Rural17_Returns0()
        //{
        //    // Arrange
        //    int age = 17;
        //    string location = "rural";
        //    double expected = 0.0;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Urban18_Returns0()
        //{
        //    // Arrange
        //    int age = 18;
        //    string location = "urban";
        //    double expected = 0.0;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Urban35_Returns6_0()
        //{
        //    // Arrange
        //    int age = 35;
        //    string location = "urban";
        //    double expected = 6.0;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Urban36_Returns5_0()
        //{
        //    // Arrange
        //    int age = 36;
        //    string location = "urban";
        //    double expected = 5.0;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_Urban17_Returns0()
        //{
        //    // Arrange
        //    int age = 17;
        //    string location = "urban";
        //    double expected = 0.0;

        //    // Act
        //    double actual = _service.CalcPremium(age, location);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test]
        //public void CalcPremium_DiscountAge50_ReturnsDiscountedPremium()
        //{
        //    // Arrange
        //    int age = 50;
        //    string location = "rural";
        //    double expected = 2.5;
        //}
    }
}
