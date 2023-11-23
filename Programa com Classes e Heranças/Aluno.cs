using System;
namespace Programa_com_Classes_e_Heranças
{
	public class Aluno : Pessoa
	{
		public Aluno()
		{
        }
		public void IrParaAula()
		{
			Console.WriteLine($"\nO aluno {nome} foi para a aula.");
		}
	}
}

