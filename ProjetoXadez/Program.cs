﻿using System;
using tabuleiro;
using xadrez;

namespace ProjetoXadez
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 2));
            //    Tela.imprimirTabuleiro(tab);
            //}catch(TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            PosicaoXadrez pos = new PosicaoXadrez('c', );
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
