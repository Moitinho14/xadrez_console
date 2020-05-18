using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.ImprimirTabuleiro(partida.tab);
            }
            catch(TabuleiroException msg)
            {
                Console.WriteLine(msg.Message);
            }

            Console.ReadLine();
        }
    }
}
