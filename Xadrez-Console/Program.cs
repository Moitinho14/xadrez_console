using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            try
            {
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 7));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 4));

                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException msg)
            {
                Console.WriteLine(msg.Message);
            }

            Console.ReadLine();
        }
    }
}
