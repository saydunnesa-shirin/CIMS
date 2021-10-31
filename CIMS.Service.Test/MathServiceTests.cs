using NUnit.Framework;

namespace CIMS.Service.Test
{
    public class MathServiceTests
    {

        [SetUp]
        public void Setup()
        {
        }

        //private readonly IMathService _mathService;
        //public MathServiceTests(IMathService mathService)
        //{
        //    _mathService = mathService;
        //}

        [Test]
        public void Addition_Test()
        {
            //Aggange
            MathService mathService = new MathService();
            var expected = 10;
            //Act
            var actual = mathService.Addition(5, 5);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtraction_Test()
        {
            //Arrenge
            MathService mathService = new MathService();
            var expected = 2.2;

            //Act
            var actual = mathService.Subtraction(4.4M, 2.2M);

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Multiplication_Test()
        {
            //Arrenge
            MathService mathService = new MathService();
            var expected = 9.68;

            //Act
            var actual = mathService.Multiplication(4.4M, 2.2M);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Division_Test()
        {
            //Arrenge
            MathService mathService = new MathService();
            var expected = 2;

            //Act
            var actual = mathService.Division(4.4M, 2.2M);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}