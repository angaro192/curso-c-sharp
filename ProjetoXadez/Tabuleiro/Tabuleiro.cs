using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int coluna { get; set;}
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int coluna)
        {
            this.linhas = linhas;
            this.coluna = coluna;
            pecas = new Peca[linhas, coluna];
        }
    }
}
