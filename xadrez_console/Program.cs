using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Xadrez via Console";

            /*Posicao p = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + p);*/
            try
            {
                Tab tab = new Tab(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroExpection e)
            {
                Console.WriteLine(e.Message);
            }

            /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());*/

            Console.ReadLine();
        }
    }
}
