using System;
using System.Drawing;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);


                board.putPiece(new Rook(board, Cor.Preta), new Position(0, 0));
                board.putPiece(new Rook(board, Cor.Preta), new Position(1, 9));
                board.putPiece(new King(board, Cor.Preta), new Position(0, 2));

                Screen.printBoard(board);
            }
            catch(BoardException e)
            { Console.WriteLine(e.Message); }
            Console.ReadLine();
        }
    }
}
