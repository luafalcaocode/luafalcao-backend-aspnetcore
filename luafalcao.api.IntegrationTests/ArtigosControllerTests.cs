using luafalcao.api.Web;
using luafalcao.api.Web.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace luafalcao.api.IntegrationTests
{
    public class ArtigosControllerTests     {
        private ArtigosController controller;
      
        [SetUp]
        public void Setup()
        {
            var arrangeTests = new ArrangeTests();
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}