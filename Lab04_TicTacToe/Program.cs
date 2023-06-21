using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("Tic Tac Toe game!");
                StartGame();

                Console.WriteLine("Do you want to play again? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Thank you for playing Tic Tac Toe!");
        }

        static void StartGame()
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
            Player winner = game.Play();

            if (winner == null)
                Console.WriteLine("no winners!");
            else
                Console.WriteLine($"{winner.Marker} Wins!");
        }


    }
}
