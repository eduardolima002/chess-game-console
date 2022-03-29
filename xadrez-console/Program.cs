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
                tb.colocarPeca(new Torre(tb, Cor.Preta), new Posicao(0, 0));
                tb.colocarPeca(new Torre(tb, Cor.Preta), new Posicao(1, 3));
                tb.colocarPeca(new Rei(tb, Cor.Preta), new Posicao(2, 3));

                Tela.imprimeTabuleiro(tb);

            }catch(TabuleiroExecption e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
