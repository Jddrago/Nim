using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class Board
    {
        static int numOfPieces = 15;
        static char[][] pieces;
        static public void setBaseState()
        {
            for(int i = 0; i < 3; i++)
            {
                int numToAdd = 0;
                switch (i)
                {
                    case 0: numToAdd = 3; break;
                    case 1: numToAdd = 5; break;
                    case 2: numToAdd = 7; break;
                }
                for(int j = 0; j < 7; j++)
                {
                    if (j <= numToAdd)
                    {
                        pieces[i][j] = 'X';
                    }
                    else
                    {
                        pieces[i][j] = ' ';
                    }
                }
            }
        }
        static public void takePiece(int row, int numOfPiecesToTake)
        {
            numOfPieces -= numOfPiecesToTake;
            for(int i = 0; i <= numOfPieces; i++)
            {
                pieces[row][i].Equals(' ');
            }
        }
        static public void printBoard()
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
        static public bool validatePiece(int row, int numOfPiecesToTake)
        {
            bool valid = false;
            switch (row)
            {
                
            }
            return valid;
        }
    }
}
