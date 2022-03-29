using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tb = new Tabuleiro(8, 8);
                
                tb.colocarPeca(new Rei(tb, Cor.Branca), new Posicao(2, 3));
                tb.colocarPeca(new Torre(tb, Cor.Preta), new Posicao(3, 6));

                Tela.imprimeTabuleiro(tb);
                Console.WriteLine();
                PosicaoXadrez posi = new PosicaoXadrez('a', 1);
                Console.WriteLine(posi.toPosition());
                Console.WriteLine(posi);

            }catch(TabuleiroExecption e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
