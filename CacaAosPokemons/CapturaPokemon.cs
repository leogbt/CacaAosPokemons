using System;
using System.Collections.Generic;

namespace CacaAosPokemons
{
	/// <summary>
	/// Classe que mantem as caracteristicas e ações envolventes à captura de pokemons.
	/// </summary>
	public class CapturaPokemon
	{

		public int Capturados { get; set; }
		public List<int[]> CasasVisitadas { get; set; }

		public CapturaPokemon()
		{
			CasasVisitadas = new List<int[]>();
			GuardarCasaVisitada();
		}

		int PosicaoX = 0; // Posição inicial eixo X
		int PosicaoY = 0; // Posição inicial eixo Y

		/// <summary>
		/// Método para realização de movimentação entre "casas", baseada no comando de entrada.
		/// </summary>
		/// <param name="comando">Um char para identificar a direção da movimentação.</param>
		public void Movimentar(char comando)
		{
			switch (comando.ToString().ToUpper())
			{
				case "N":
					PosicaoY++;
					break;

				case "S":
					PosicaoY--;
					break;

				case "E":
					PosicaoX++;
					break;

				case "O":
					PosicaoX--;
					break;

				default:
					Console.WriteLine("Opção inválida");
					break;
			}


			if (!PokemonJaCapturado(PosicaoX, PosicaoY))
			{
				Capturar();
			}

		}

		/// <summary>
		/// Verifica se o pokemon foi da casa atual capturado
		/// </summary>
		/// <returns>Um bool que identifica se o pokemon daquela casa foi capturado</returns>
		private bool PokemonJaCapturado(int posX, int posY)
		{
			bool flagCasaVisitada = false;

			for (int i = 0; i < CasasVisitadas.Count; i++)
			{
				//Verifico se ja tem uma casa na posição x e y

				if (CasasVisitadas[i][0] == posX && CasasVisitadas[i][1] == posY)
				{
					flagCasaVisitada = true;
					break;

				}
			}

			return flagCasaVisitada;
		}

		/// <summary>
		/// Adiciona a casa na lista de casas visitadas onde os pokemons ja foram capturados
		/// </summary>
		private void GuardarCasaVisitada()
		{
			CasasVisitadas.Add(new int[] { PosicaoX, PosicaoY });
		}

		/// <summary>
		/// Realiza a captura do pokemon e adcionando casa na lista de casas capturadas.
		/// </summary>
		public void Capturar()
		{
			Capturados++;
			GuardarCasaVisitada();
		}


	}
}
