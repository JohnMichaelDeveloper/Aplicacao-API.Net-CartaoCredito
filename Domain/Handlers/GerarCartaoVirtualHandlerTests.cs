using Domain.Commands.Inputs;
using Domain.Commands.Results;
using Domain.Handlers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HandlerTests
{
    [TestClass]
    public class GerarCartaoVirtualHandlerTests
    {
        [TestMethod]
        public void DeveRetornarEmailInvalido()
        {
            var command = new GerarCartaoVirtualCommand();
            command.Email = "jhonatafernandes.com";

            var gerarCartaoHandler = new GerarCartaoVirtualHandler();
            var result = gerarCartaoHandler.Handle(command);

            Assert.AreEqual(result, typeof(string));
        }

        [TestMethod]
        public void DeveRetornarSucesso()
        {
            var command = new GerarCartaoVirtualCommand();
            command.Email = "jhonatafernandes.com";

            var gerarCartaoHandler = new GerarCartaoVirtualHandler();
            var result = gerarCartaoHandler.Handle(command);

            Assert.AreEqual(result, typeof(GerarCartaoVirtualCommandResult));
        }
    }
}