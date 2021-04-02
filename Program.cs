using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe!\n");
            Console.Write("Please enter name Player 1 (X): ");
            String namePlayer1 = Console.ReadLine();
            //Console.WriteLine(namePlayer1); Testing variable - OK (Delete line when game is complete.)
            Console.Write("Please enter name Player 2 (O): ");
            String namePlayer2 = Console.ReadLine();
            string winner = "none";
            //Console.WriteLine(namePlayer2); Testing variable - OK
            string grid1 = " ";
            string grid2 = " ";
            string grid3 = " ";
            string grid4 = " ";
            string grid5 = " ";
            string grid6 = " ";
            string grid7 = " ";
            string grid8 = " ";
            string grid9 = " ";
            
            String[] moves = {grid1,grid2,grid3,grid4,grid5,grid6,grid7,grid8,grid9}; //Changes the variables grid# to an array named moves.
            
            Grid(moves); //Go-to method called Grid, bring information from array moves.
            int turn = 1;
            bool turnPlayer1 = true;
            //Loop from here. If to determine player turn.

            while (turn < 10)
            {
                if (turnPlayer1 == true)
                {

                    Console.Write(namePlayer1 + " please select a square. (1-9) ");
                    string txtDrawPlayer1 = Console.ReadLine(); //Validate input!
                    int drawPlayer1 = int.Parse(txtDrawPlayer1);
                    drawPlayer1 = drawPlayer1 - 1;   
                    //Console.WriteLine(drawPlayer1); 
                    Draw(drawPlayer1, moves);
                    //Check for 3 in a row here 

                } else
                {
                    Console.Write(namePlayer2 + " please select a square. (1-9) "); 
                    string txtDrawPlayer2 = Console.ReadLine(); //Validate input!
                    int drawPlayer2 = int.Parse(txtDrawPlayer2);
                    drawPlayer2 = drawPlayer2 - 1;
                    //Console.WriteLine(drawPlayer2);
                    Draw2(drawPlayer2, moves);
                    //Check for 3 in a row here
                }
                
                //Console.WriteLine(turnPlayer1); Testing variable. - Ok                

                Console.Clear();
                Grid(moves);
                turnPlayer1 = !turnPlayer1;
                //Console.WriteLine(turnPlayer1); Testing variable - Ok
                turn ++;
            }
            //Loopa hit.  
            if (winner == "none")
            {
                Console.WriteLine("It´s a TIE!");//Tie breaker? 
            }  

            Console.ReadKey(); //Pause before shutdown. 
        }

        //                  ---=== Methods below ===---
        static void Grid(String[] moves)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", moves[0], moves[1], moves[2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", moves[3], moves[4], moves[5]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", moves[6], moves[7], moves[8]);
            Console.WriteLine("-------------");
        }
        static void Draw(int drawPlayer1, String[] moves)
        {
            // LOOP FROM HERE, to let players have more chanses if square is occupied. (Pending) Is a loop the right way to do it? 
            //Console.WriteLine(drawPlayer1);
            if (moves[drawPlayer1] == " ")
            {
                moves[drawPlayer1] = "X";
            } 
            else
            {
                Console.WriteLine("Square is occupied, idiot! Try again!"); //Here I want to make it possible for players to get a second chance if they´re assigning a square that is occupied.
                Console.ReadKey();//Pause before proceeding.  
            }    
                        
        }
        static void Draw2(int drawPlayer2, String[] moves)
        {
            //Console.WriteLine(drawPlayer2);
            if (moves[drawPlayer2] == " ")
            {
                moves[drawPlayer2] = "O";
            }
            else
            {
                Console.WriteLine("Square is occupied, idiot!"); //Here I want to make it possible for players to get a second chance if they´re assigning a square that is occupied.
                Console.ReadKey();//Pause before proceeding.
            }

        }
     
    }

}
