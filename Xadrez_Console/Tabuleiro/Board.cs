namespace Tabuleiro
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces; //Tabuleiro vai ter uma Matriz de peças- Private because they can't be asseced by someone else

        public Board(int linesValue, int columnsValue)
        {
            Lines = linesValue;
            Columns = columnsValue;
            pieces = new Piece[linesValue, columnsValue];
        }

        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.Line, pos.Column];
        }

        public bool existsPiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }

        public void putPiece(Piece pi , Position pos)
        {
            if (existsPiece(pos)) { throw new BoardException("There is already a piece in that position!"); }
            pieces[pos.Line, pos.Column] = pi;
            pi.Position = pos;
        }

        public bool validPosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            } 
                return true;
        }

        public void validatePosition(Position pos)
        {
            if(!validPosition(pos))
            {
                throw new BoardException("Invalid position! ");
            }
        }
    }
}
