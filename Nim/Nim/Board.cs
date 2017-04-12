using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class Board
    {
        public static int numOfPieces = 15, row1mod = 0, row2mod = 0, row3mod = 0;
        public static int numRows = 3, numColumns = 7;
        static char[,] pieces = new char[numRows,numColumns];
        static public void setBaseState()
        {
            initBoard();
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
                    if (j < numToAdd)
                    {
                        pieces[i,j] = 'X';
                    }
                    else
                    {
                        pieces[i,j] = ' ';
                    }
                }
            }
        }
        static public void takePiece(int row, int numOfPiecesToTake)
        {
            numOfPieces -= numOfPiecesToTake;
            switch (row)
            {
                case 0: for (int i = 0; i < numOfPiecesToTake; i++)
                {
                    pieces[row, i + row1mod] = ' ';
                }
                    row1mod += numOfPiecesToTake;
                    break;
                case 1:
                    for (int i = 0; i < numOfPiecesToTake; i++)
                    {
                        pieces[row, i + row2mod] = ' ';
                    }
                    row2mod += numOfPiecesToTake;
                    break;
                case 2:
                    for (int i = 0; i < numOfPiecesToTake; i++)
                    {
                        pieces[row, i + row3mod] = ' ';
                    }
                    row3mod += numOfPiecesToTake;
                    break;
            }
        }
        static public void printBoard()
        {
            for(int i = 0; i < numRows; i++)
            {
                for(int j = 0; j < numColumns; j++)
                {
                    if(j == numColumns-1)
                    {
                        Console.WriteLine(pieces[i,j]);
                    }
                    else
                    {
                        Console.Write(pieces[i,j]);
                    }
                }
            }
        }
        static private void initBoard()
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    pieces[i,j] = new char();
                }
            }
        }
        static public void SaveBoardState(string file)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, pieces);
            stream.Close();
        }
    }
}