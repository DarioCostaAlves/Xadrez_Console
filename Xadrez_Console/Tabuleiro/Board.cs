namespace Tabuleiro
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces; //Tabuleiro va ter uma Matriz de peças- Private because they can't be asseced by someone else

        public Board(int linesValue, int columnsValue)
        {
            Lines = linesValue;
            Columns = columnsValue;
            pieces = new Piece[linesValue, columnsValue];
        }
    }
}
