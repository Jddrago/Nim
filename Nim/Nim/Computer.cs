using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class Computer : Player
    {
        int row1max = Board.numRows, row2max = ((Board.numRows + Board.numColumns) / 2), row3max = Board.numColumns;

        public override void takeTurn()
        {
            simpleAI();
            //learningAI(); // uncomment this line and comment out the above line to switch AI's
        }

        public void simpleAI()
        {
            bool validRow = true, validnumPieces = true;
            do
            {
                int rowChoice = new Random().Next(row1max);
                switch (rowChoice)
                {
                    case 0:
                        if (Board.row1mod == row1max) { validRow = false; } else { validRow = true; };
                        break;
                    case 1:
                        if (Board.row2mod == row2max) { validRow = false;} else { validRow = true; };
                        break;
                    case 2:
                        if (Board.row3mod == row3max) { validRow = false; } else { validRow = true; };
                        break;
                }
            } while (!validRow);

        }

        public void learningAI()
        {
            throw new NotImplementedException();
        }
    }
}
