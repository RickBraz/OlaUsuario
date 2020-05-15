using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola usuario por favor digite seu nome!");

            string nome = Console.ReadLine();
            string mensagem = "Olá " + nome + "!";

            Console.WriteLine(mensagem);
        }
    }
}
