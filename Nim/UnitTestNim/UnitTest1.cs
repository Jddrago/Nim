using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nim;


namespace UnitTestNim
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SelectingRow1()
        {
            Computer computer = new Computer();
            Board.row2mod = 5;
            Board.row3mod = 7;
            int row = computer.chooseRow();

            Assert.IsTrue(row == 0);
        }

        [TestMethod]
        public void SelectingPeicesfromRow2()
        {
            Computer computer = new Computer();
            int numPieces = computer.selectPieces(1);
            Board.row1mod = 3;
            Board.row2mod = 2;
            Board.row3mod = 7;
            int row = computer.chooseRow();

            Assert.IsTrue(numPieces>=0 && numPieces<3);
        }
    }
}
