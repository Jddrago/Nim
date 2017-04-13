using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
<<<<<<< HEAD
     public class Computer : Player
=======
    public class Computer : Player
>>>>>>> origin/master
    {
        int row1max = Board.numRows, row2max = ((Board.numRows + Board.numColumns) / 2), row3max = Board.numColumns;

        public override void takeTurn()
        {
            simpleAI();
            //learningAI(); // uncomment this line and comment out the above line to switch AI's
        }

        public void simpleAI()
        {
            int row = -1, numpieces = -1;
            row = chooseRow();
            numpieces = selectPieces(row);

        }

        public void learningAI()
        {
            throw new NotImplementedException();
        }

        public int chooseRow()
        {
            int rowChoice;
            bool validRow = true;
            do
            {
                rowChoice = new Random().Next(row1max);
                switch (rowChoice)
                {
                    case 0:
                        if (Board.row1mod == row1max) { validRow = false; } else { validRow = true; };
                        break;
                    case 1:
                        if (Board.row2mod == row2max) { validRow = false; } else { validRow = true; };
                        break;
                    case 2:
                        if (Board.row3mod == row3max) { validRow = false; } else { validRow = true; };
                        break;
                }
            } while (!validRow);
            return rowChoice;
        }

        public int selectPieces(int row)
        {
            int numPieces = 0;
            bool validNumPieces = true;
            do
            {
                switch (row)
                {
                    case 0:
                        numPieces = new Random().Next(row1max)+1;
                        if (numPieces + Board.row1mod >= row1max) { validNumPieces = false; } else { validNumPieces = true; };
                        break;
                    case 1:
                        numPieces = new Random().Next(row2max)+1;
                        if (numPieces + Board.row2mod >= row2max) { validNumPieces = false; } else { validNumPieces = true; };
                        break;
                    case 2:
                        numPieces = new Random().Next(row3max)+1;
                        if (numPieces + Board.row3mod >= row3max) { validNumPieces = false; } else { validNumPieces = true; };
                        break;
                }
            } while (!validNumPieces);
            return numPieces;
        }
    }
}
