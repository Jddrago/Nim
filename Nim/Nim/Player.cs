using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Player
    {
        private static int playernumber = 1;
        string Name { get; set; }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            if(name.Equals("")|| name.Equals(null))
            {
                Name = "Player " + playernumber;
                playernumber++;
            }
            else
            {
                Name = name;
                playernumber++;
            }
        }

        public virtual void takeTurn()
        {
            Console.WriteLine(getName() + "'s turn.");
            int row;
            int numPieces;
            do
            {
                row = NimLogic.PromptForRow();
                if (row < 0 || row > 2)
                {
                    Console.WriteLine("Invalid input please enter a valid row number.");
                    row = -1;
                }
            } while (row == -1);
            do
            {
                numPieces = NimLogic.PromptForNumPiecesTaken(row);
                if (numPieces == -1)
                {
                    Console.WriteLine("Invalid input please enter a valid number of pieces.");
                }
                switch (row)
                {
                    case 0: if (numPieces > 3 || Board.row1mod + numPieces > 3) { numPieces = -1; Console.Write("That row doesn't have enough pieces."); }; break;
                    case 1: if (numPieces > 5 || Board.row2mod + numPieces > 5) { numPieces = -1; Console.Write("That row doesn't have enough pieces."); }; break;
                    case 2: if (numPieces > 7 || Board.row3mod + numPieces > 7) { numPieces = -1; Console.Write("That row doesn't have enough pieces."); }; break;
                }
            } while (numPieces == -1);
            Board.takePiece(row, numPieces);
        }
    }
}
