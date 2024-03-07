
using System;
using System.ComponentModel.Design;
namespace tic_tac_toe_Arnob
{
    internal class Program
        
    {
        //1|2|3
        //4|5|6
        //7|8|9

        //X|2|3
        //4|5|6
        //7|8|9

        static String[] board = new String[9];
        static string PlaysAgain = "Y" ;
        static int counter = 0;
        static void initializevariable()
        {
            for (int i = 0; i <9; i++) {
                board[i] = i.ToString();
            }
        }
        static void PlayAgainMsg(string message)
        {
           Console.WriteLine( message + " Do you want to play again? ");
            if (Console.ReadLine().Equals("Y"))
                PlaysAgain.Equals("Y");
            else
                PlaysAgain.Equals("N");
        }
        static void winner()
        {
            Console.WriteLine("Congratulations! You have won. \n Do you want to play again? ");
            if(Console.ReadLine().Equals("Y"))
                    PlaysAgain.Equals ( "Y");   
           else
                PlaysAgain.Equals ( "N");
        }

        static void Main(string[] args)
        {  
            introduction();
            while (PlaysAgain.Equals("Y"))
                {
                initializevariable();
                while (hasWon() == false && counter < 9)
                {
                    askData("X");
                    if (hasWon() == true)
                        break;
                    askData("O");
                }
                if (hasWon() == true)
                    PlayAgainMsg("Congratulations! You won!");
                else
                    PlayAgainMsg("Sorry! This was a tie....");
            }
            goodBye();
        } 
        static void goodBye()
        {
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
        static void tieGame()
        {
            Console.WriteLine("Sorry! This was a tie game....");
        }
       
        static void askData(string player) {
            Console.Clear();
            Console.WriteLine("Player :" + player);
            int selection;
            while (true)
            { 
                Console.WriteLine("Please enter your selection :");
                drawBoard();
                 selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 0 || selection > 9 ||  board[selection].Equals("X") || board[selection].Equals("O")) 
                    Console.WriteLine("invalid Selection");
               
                else
                    break;

            }
            board[selection] = player;
        }
        static void drawBoard()
        {   for (int i = 0; i < 7; i+=3)
            {
                Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);
            }

        }
        static Boolean hasWon()
        {
            for(int i = 0;i < 7;i++) {
                if (board[i].Equals(board[i+1]) && board[i + 1].Equals(board[i+2]))
                {
                    return true;
                }
            }
            if (board[0].Equals(board[3]) && board[3].Equals(board[6]))
                return true;
              
            if (board[1].Equals(board[4]) && board[4].Equals(board[7]))
                
                 return true;
            if (board[2].Equals(board[5]) && board[3].Equals(board[8]))

                return true;
            if (board[2].Equals(board[4]) && board[4].Equals(board[6]))

                return true;
            if (board[0].Equals(board[4]) && board[4].Equals(board[8]))

                return true;
            return false;
        }
         static void introduction()
        {
            Console.Title = "Tic_Tac_toe";
            Console.WriteLine("Welcome to tic tac toe");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
