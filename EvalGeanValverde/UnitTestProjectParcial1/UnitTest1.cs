using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using EvalGeanValverde1.Controllers;
using EvalGeanValverde1.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectParcial1
{
    [TestClass]
    public class UnitTest1
    {
        public object PaisID { get; private set; }


        [TestMethod]
        public void TestGet()
        {
            //arrange
            PaisController controller = new PaisController();
            //act
            var lista = controller.GetPais();
            //assert
            Assert.IsNotNull(lista);
        }
        public void TestPost()
        {
            //arrange
            PaisController controller = new PaisController();
            Pais esperado = new Pais()
            {
                NombrePais = "Colombia",
                Capital = "Bogota",
                Population = 48759958,
                Lating = "4.0, -72.0",
                Timezones = "UTC-05:00",
                Currencies = "Colombian peso",
                Flag = "https://restcountries.eu/data/col.svg"
            };
            //act
            IHttpActionResult actionResult = controller.PostPais(esperado);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Pais>;
            //assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.IsNotNull(createdResult.RouteValues("id"));

        }
    }
}
