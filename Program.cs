using System;

namespace Nome_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome;
            string sobrenome;

            //<---Inicio(Nome e Sobrenome)--->//
            Console.Write("Digite Seu Nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite Seu Sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.Write("\n");
            //<---Fim(Nome e Sobrenome)--->//

            //<---Inicio(Nome Completo)--->//
            Console.Write($"Nome Completo: {nome} {sobrenome}");
            Console.Write("\n");
            //<---Fim(Nome Completo)--->//

            //<---Inicio(Nome de Catálogo)--->//
            Console.WriteLine($"Nome de Catálogo: {sobrenome.ToUpper()}, {nome}");
            Console.Write("\n");
            //<---Fim(Nome de Catálogo)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
        }
    }
}
