using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class Board
    {
        int numOfPieces = 15;
        char[][] pieces;
        public Board()
        {
            setBaseState();
        }

        private void setBaseState()
        {
            
        }
        public bool takePiece(int row, int numOfPiecesToTake)
        {

        }
        public void printBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; i < 7; j++)
                {
                    if(j == 0)
                    {
                        Console.WriteLine(pieces[i][j]);
                    }
                    else
                    {
                        Console.Write(pieces[i][j]);
                    }
                }
            }
        }
    }
}
