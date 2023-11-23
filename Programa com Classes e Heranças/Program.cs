using System;

namespace Programa_com_Classes_e_Heranças
{

    class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            Aluno aluno = new Aluno();
            Professor professor = new Professor("C#");

            pessoa.Cumprimentar("Roger");
            pessoa.DizerIdade(45);

            aluno.Cumprimentar("Aluno Cristiano");
            aluno.DizerIdade(21);
            aluno.IrParaAula();

            professor.Cumprimentar("Professor Gustavo");
            professor.ExplicarAula("C#");

            Console.ReadLine();
        }
    }
}
