using System;
namespace Programa_com_Classes_e_Heranças
{
	public class Pessoa
	{
		public string nome;
		public int idade;


		public void Cumprimentar(string nome)
		{
			Console.WriteLine($"\nOlá meu é {nome}.");
		}

		public void DizerIdade(int idade)
		{
			Console.WriteLine($"\nEu tenho {idade} anos.");
		}

			
	}
}

