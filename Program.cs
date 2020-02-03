using Jogo_Xadrez_Console.tabuleiro;
using System;


namespace Jogo_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
        }
    }
}
