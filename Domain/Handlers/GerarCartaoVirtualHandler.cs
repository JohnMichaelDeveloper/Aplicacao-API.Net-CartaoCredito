using Domain.Commands.Inputs;
using Domain.Commands.Results;

namespace Domain.Handlers
{

	public class GerarCartaoVirtualHandler
	{
		public GerarCartaoVirtualCommandResult Handle(GerarCartaoVirtualCommand command)
		{
			//Validar Command
			command.Validar();

			if (command.Invalid)
				return null;
			//Gerar número de cartão aleatório
			var numeroCartao = string.Empty;
			for (int i = 0; i < 4; i++)
			{
				var random = new Random();
				var blocoCartao = $"{random.Next(1000, 9999)}";
				numeroCartao = $"{numeroCartao + blocoCartao}";
			}
			// Criar entidade e salvar no banco
			var cartaoVirtual = new CartaoVirtual(command.Email, numeroCartao, DateTime.Now);

			//Criar command result e retornar
			var commandResult = new GerarCartaoVirtualCommandResult(command.Email, numeroCartao);

			return null;
		}
	}
}
