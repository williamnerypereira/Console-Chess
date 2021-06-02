﻿using System;
using Tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tab tab)
        {
            for(int i=0; i < tab.linhas; i++)
            {
                for(int j=0; j < tab.colunas; j++)
                {
                    if(tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    } 
                }

                Console.WriteLine();
            }
        }
    }
}
