using System;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using BuckFizz.ServiceModel;
using BuckFizz.ServiceInterface;

namespace BuckFizz.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof(MyServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                }
            }
            .Init();
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void Test_Method1()
        {
            var service = appHost.Container.Resolve<MyServices>();

          var response = (TableResponse)service.Any(new webTable { repeatCount = 5 } );

            Assert.That(response.Result, Is.EqualTo("1, 2, Fizz, 4, Buck"));
        }
    }
}
