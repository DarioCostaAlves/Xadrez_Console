using Tabuleiro;

namespace Xadrez
{
    class King : Piece
    {
        public King(Board boardValue, Cor corValue) : base(corValue,boardValue)
        {
        }

        public override string ToString()
        {
            return "K"; 
        }
    }
}
