namespace Tabuleiro
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; } // Can be acessed by subClasses or herself (protected)
        public int QuantitiesMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Position positionValue, Color colorValue, Board boardValue)
        {
            Position = positionValue;
            Color = colorValue;
            Board = boardValue;
            QuantitiesMoves = 0; //Moves of that piece will start by default : 0
        }
    }
}
