using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGturnos1
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Console.WriteLine("Bem-Vindo");
            Console.WriteLine("");
            Console.WriteLine("(1) Novo jogo");
            Console.WriteLine("(2) Sair");
            escolha = Console.ReadLine();

            Console.WriteLine(" Aperte qualquer tecla para continuar.");
            Console.ReadKey();

            Personagem Char = new Personagem();
            Char.criarPersonagem();

            Itens Equipes = new Itens();
            Equipes.cadastrarItem();

           
        }
    }
}
