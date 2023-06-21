using System.Numerics;
using Lab04_TicTacToe.Classes;

namespace TestsTicTacToe
{
    public class UnitTest1
    {

        [Fact]
        public static void TestForWinnerTrue()//there a winner case test
        {
            Player p1 = new Player();
            p1.Marker = "X";
            p1.Name = "player1";
            Player p2 = new Player();
            p1.Marker = "O";
            p1.Name = "player2";
            Game game = new Game(p1, p2);

            game.Board.GameBoard = new string[,]
           {
                   {"O", "X", "X"},
                   {"O", "O", "X"},
                   {"X", "X", "O"}
           };

            bool winner = game.CheckForWinner(game.Board);
            Assert.True(winner);

        }

        [Fact]
        public void TestPlayerSwitch()
        {
            Player p1 = new Player();
            p1.Name = "player1";
            p1.Marker = "X";
            p1.IsTurn = true;

            Player p2 = new Player();
            p2.Name = "player2";
            p2.Marker = "O";
            p2.IsTurn = false;

            Game game = new Game(p1, p2);

            game.SwitchPlayer();

            
            Assert.True(p2.IsTurn);  
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(2, 0, 1)]
        [InlineData(9, 2, 2)]
        public void TestPositionForNumber(int number, int expectedRow, int expectedColumn)
        {
            Position position = Player.PositionForNumber(number);

            Assert.Equal(expectedRow, position.Row);
            Assert.Equal(expectedColumn, position.Column);
        }

        [Fact]
        public static void TestNoWinnerFalse()
        {
            Player p1 = new Player();
            p1.Marker = "X";
            p1.Name = "player1";
            Player p2 = new Player();
            p1.Marker = "O";
            p1.Name = "player2";
            Game game = new Game(p1, p2);

            game.Board.GameBoard = new string[,]
           {
                   {"x", "X", "0"},
                   {"O", "O", "X"},
                   {"X", "X", "O"}
           };

            bool winner = game.CheckForWinner(game.Board);
            Assert.False(winner);

        }
    }
}
