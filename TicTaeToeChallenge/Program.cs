
using System;

namespace TicTaeToeChallenge
{
    public class Program
    {
        public static char[,] playField = new char[,]
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        
        static int count=0;
        static void Main(string[] args)
        {
            //This game is created for practice purpose only
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            
            setField();



            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                    //setField();

                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                    //setField();
                }
                setField();

                #region
                //Check Winning Condition


                char[] playerChars = { 'X', 'O' };
                foreach (char ch in playerChars)
                {
                    if (((playField[0, 0] == ch) && (playField[0, 1] == ch) && (playField[0, 2] == ch))
                        || ((playField[1, 0] == ch) && (playField[1, 1] == ch) && (playField[1, 2] == ch))
                        || ((playField[2, 0] == ch) && (playField[2, 1] == ch) && (playField[2, 2] == ch))
                        || ((playField[0, 0] == ch) && (playField[1, 0] == ch) && (playField[2, 0] == ch))
                        || ((playField[0, 1] == ch) && (playField[1, 1] == ch) && (playField[2, 1] == ch))
                        || ((playField[0, 2] == ch) && (playField[1, 2] == ch) && (playField[2, 2] == ch))
                        || ((playField[0, 0] == ch) && (playField[1, 1] == ch) && (playField[2, 2] == ch))
                        || ((playField[0, 2] == ch) && (playField[1, 1] == ch) && (playField[2, 0] == ch)))
                    {
                        if(ch == 'X')
                        {
                            Console.WriteLine("Player 2 has won.");
                        }
                        else
                        {
                            Console.WriteLine("Player 1 has won.");
                        }
                        Console.WriteLine("Press any key to reset the game.");
                        Console.ReadLine();

                        resetField();

                        break;
                    }
                    else if(count ==10)
                    {
                        Console.WriteLine("Huuuhhh!! No winner, its a draw.");
                        Console.WriteLine("Press any key to reset the game.");
                        Console.ReadLine();
                        resetField();
                    }
                     
                }
            

                #endregion

                #region
                //Test if the fiels are already taken
                do
                {
                
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter valid number");
                    }


                    if ((input == 1) && (playField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playField[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }

                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorrect input, please select another input");
                        inputCorrect = false;
                        
                    }

                } while (!inputCorrect);
                #endregion

            }while(true);
           

        }
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if(player == 1)
            {
                playerSign = 'X';
            }
            else if(player == 2)
            {
                playerSign = 'O';
            }
            switch(input)
            {
                case 1:
                    playField[0, 0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1,0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1,2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
            }
        }
        static void setField()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                   Tic Tac Toe Game                               ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                                                        |     |     ");
            Console.WriteLine("                                                    {0}   |  {1}  |  {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("                                                        |     |     ");
            Console.WriteLine("                                                  ------------------");
            Console.WriteLine("                                                        |     |     ");
            Console.WriteLine("                                                     {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("                                                        |     |     ");
            Console.WriteLine("                                                  ------------------");
            Console.WriteLine("                                                        |     |     ");
            Console.WriteLine("                                                    {0}   |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("                                                        |     |     ");
            count++;
        }
        //resetting the using resetField function

        static void resetField()
        {
            char[,] playFieldInitial = new char[,]
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };
            playField = playFieldInitial;
            setField();
            count = 0;

        }
    }
}
