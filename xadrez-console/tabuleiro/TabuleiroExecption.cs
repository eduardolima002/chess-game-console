using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    internal class TabuleiroExecption : Exception
    {
        public TabuleiroExecption(string msg) : base(msg)
        {

        }
    }
}
