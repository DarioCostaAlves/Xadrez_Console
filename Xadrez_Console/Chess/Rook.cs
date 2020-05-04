using Tabuleiro;

namespace Xadrez
{
    class Rook : Piece
    {
        public Rook(Board boardValue, Cor corValue) : base(corValue, boardValue)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
