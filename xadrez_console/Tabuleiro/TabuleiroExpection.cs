using System;

namespace Tabuleiro
{
    class TabuleiroExpection : Exception
    {
        public TabuleiroExpection (string msg) : base(msg)
        {
        }
    }
}
