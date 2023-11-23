using System;
namespace Programa_com_Classes_e_Heranças
{
	public class Professor : Pessoa
	{
		public Professor(string assunto)
		{
		}

		public void ExplicarAula(string assunto)
		{
			Console.WriteLine($"\nHoje vamos aprender sobre {assunto}");
		}
	}
}

