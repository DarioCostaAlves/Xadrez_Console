using System;
using Tabuleiro;

namespace Xadrez_Console
{
    class Screen
    {
        public static void printBoard(Board board) 
        {
            for(int i = 0; i<board.Lines; i++)
            {
                for(int j=0; j<board.Columns;j++)
                {
                    if(board.piece(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(board.piece(i,j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
