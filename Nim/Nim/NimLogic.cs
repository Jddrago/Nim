using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    class NimLogic
    {
        public Player[] players { get; set; }

        public void Run()
        {
            Board.setBaseState();
            createPlayers();
            PromptForName(players[0]);
            PromptForName(players[1]);
            Console.WriteLine(players[0].getName() + ", " + players[1].getName());
            gameLoop();
        }







        public void PromptForName(Player player)
        {
            Console.Write("What is your name player: ");
            string name = Console.ReadLine();
            player.setName(name);
        }

        public void createPlayers()
        {
            players = new Player[2];
            players[0] = new Player();
            players[1] = new Player();
        }

        public void gameLoop()
        {
            Player currentPlayer = players[0];
            do
            {
                Board.printBoard();
                currentPlayer.takeTurn();
                if (currentPlayer.Equals(players[0]))
                {
                    currentPlayer = players[1];
                }
                else
                {
                    currentPlayer = players[0];
                }

            } while (Board.numOfPieces > 1);
            Board.printBoard();
            if(Board.numOfPieces == 1)
            {
                if (currentPlayer.Equals(players[0]))
                {
                    currentPlayer = players[1];
                    Console.WriteLine(currentPlayer.getName() + " has won.");
                }
                else
                {
                    currentPlayer = players[0];
                    Console.WriteLine(currentPlayer.getName() + " has won.");
                }
            }
            else
            {
                Console.WriteLine(currentPlayer.getName() + " has won.");
            }
        }

        public static int PromptForRow()
        {
            Console.WriteLine("Please select which row you wish to take from(1-3): ");
            int row;
            if(int.TryParse(Console.ReadLine(), out row))
            {
                return row-1;
            }
            return -1;
        }

        public static int PromptForNumPiecesTaken(int row)
        {
            Console.WriteLine("Please enter how many pieces you wish to take from " + (row + 1));
            int numPieces;
            if (int.TryParse(Console.ReadLine(), out numPieces))
            {
                return numPieces;
            }
            return -1;
        }
    }
}
