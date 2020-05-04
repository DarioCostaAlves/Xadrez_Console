namespace Tabuleiro
{
    class Piece
    {
        public Position Position { get; set; }
        public Cor Cor { get; protected set; } // Can be acessed by subClasses or herself (protected)
        public int QuantitiesMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Cor corValue, Board boardValue)
        {            
            Cor = corValue;
            Board = boardValue;
            QuantitiesMoves = 0; //Moves of that piece will start by default : 0
        }
    }
}
