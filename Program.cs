using System;

namespace aula_26_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoAluno;

            Console.Beep();
            Console.Clear();

            Console.Write("Olá aluno, Digite o seu nome:");
            nomeDoAluno = Console.ReadLine();
            Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lista de Alunos Malvados");
            Console.WriteLine("------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("1. Pedrinho");
            Console.WriteLine("2. Zezinho");
            Console.WriteLine("3. Mariazinha");
            Console.WriteLine("4. Jorginho");
            Console.WriteLine($"5.{nomeDoAluno}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vão Todos Pra Diretoria!");
            Console.Beep();
            Console.ResetColor();

            Console.Write("Pressione uma tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
