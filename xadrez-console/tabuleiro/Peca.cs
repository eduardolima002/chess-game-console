using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qtdMovimentos = 0;
        }

        public void incrementaQtdMovimento()
        {
            qtdMovimentos++;
        }
        public void decrementaQtdMovimento()
        {
            qtdMovimentos--;
        }


        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = possibleMoves();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return possibleMoves()[pos.linha, pos.coluna];
        }

        public abstract bool[,] possibleMoves();
        
    }
}
