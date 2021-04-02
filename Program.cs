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
            //Console.WriteLine(namePlayer1); Testar variabeln - OK
            Console.Write("Please enter name Player 2 (O): ");
            String namePlayer2 = Console.ReadLine();
            
            //Console.WriteLine(namePlayer2); Testar variabeln - OK
            string grid1 = " ";
            string grid2 = " ";
            string grid3 = " ";
            string grid4 = " ";
            string grid5 = " ";
            string grid6 = " ";
            string grid7 = " ";
            string grid8 = " ";
            string grid9 = " ";
            
            String[] moves = {grid1,grid2,grid3,grid4,grid5,grid6,grid7,grid8,grid9}; //Ändrar variablerna grid# till en array med namnet moves
            
            Grid(moves); //Overload med 11 variabler, därav moves-arrayen.
            int turn = 1;
            bool turnPlayer1 = true;
            //Loopa härifrån. If för vilken spelares tur. 

            while (turn < 10)
            {
                if (turnPlayer1 == true)
                {
                    Console.Write(namePlayer1 + " please select a square. (1-9) ");
                    string txtDrawPlayer1 = Console.ReadLine();
                    int drawPlayer1 = int.Parse(txtDrawPlayer1);
                    drawPlayer1 = drawPlayer1 - 1;   
                    //Console.WriteLine(drawPlayer1); 
                    Draw(drawPlayer1, moves);
                } else
                {
                    Console.Write(namePlayer2 + " please select a square. (1-9) "); 
                    string txtDrawPlayer2 = Console.ReadLine();
                    int drawPlayer2 = int.Parse(txtDrawPlayer2);
                    drawPlayer2 = drawPlayer2 - 1;
                    //Console.WriteLine(drawPlayer2);
                    Draw2(drawPlayer2, moves);
                }
                
                //Console.WriteLine(turnPlayer1); Testar variabeln                

                Console.Clear();
                Grid(moves);
                turnPlayer1 = !turnPlayer1;
                //Console.WriteLine(turnPlayer1); Testar variabeln
                turn ++;
            }
            //Loopa hit.             
            Console.ReadKey(); //Paus innan nedstängning
        }

        //                  ---=== Methods nedan ===---
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
            // LOOPA HÄR, så man får fler chanser att göra rätt för sig. 
            //Console.WriteLine(drawPlayer1);
            if (moves[drawPlayer1] == " ")
            {
                moves[drawPlayer1] = "X";
            } 
            else
            {
                Console.WriteLine("Rutan är redan tagen, idiot!"); //Anchor till ovan (där man väljer ruta) Annars går turen över till andra spelaren. 
                Console.ReadKey();//Paus innan vidaregång   
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
                Console.WriteLine("Rutan är redan tagen, idiot!"); //Anchor till ovan (där man väljer ruta) Annars går turen över till andra spelaren. 
                Console.ReadKey();//Paus innan vidaregång
            }

        }
     
    }

}
