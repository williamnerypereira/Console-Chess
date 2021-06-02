﻿using System;
using Tabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tab tab)
        {
            for(int i=0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");

                for(int j=0; j < tab.colunas; j++)
                {
                    if(tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        //Console.Write(tab.Peca(i, j) + " ");
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    } 
                }

                Console.WriteLine();
            }

            Console.WriteLine(" a b c d e f g h");
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }
        public static void ImprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
