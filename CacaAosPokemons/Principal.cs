using System;

namespace CacaAosPokemons
{
	/// <summary>
	/// Classe principal da aplicação. 
	/// </summary>
	public class Principal
	{
		/// <summary>
		/// É aqui onde tudo começa ;)
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Obtem os comandos passados pelo usuário.
			string entradaDados = Console.ReadLine();
			
			// Inicia a o jogo e imprime o resultado em tela.
			Console.WriteLine(IniciarCaptura(entradaDados));
			Console.ReadLine();
		}

		public static int IniciarCaptura(string entradaDados)
		{
			char[] _input = entradaDados.ToCharArray();
			CapturaPokemon capturaPokemon = new CapturaPokemon();

			// Inicio capturando o da casa inicial 
			capturaPokemon.Capturar();

			// Percorre o input e realiza as movimentações
			for (int i = 0; i < _input.Length; i++)
			{
				capturaPokemon.Movimentar(_input[i]);
			}

			return capturaPokemon.Capturados;

		}
	}
}
