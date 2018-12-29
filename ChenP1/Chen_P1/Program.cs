using System;

//Sitong Chen
//IGME.202.01
//9-23-2017
//Project 1, ASCII Replacer
namespace Chen_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 2D array variable to hold three texts
            string[,] texts = new string[3, 15];
            //assign value to string, three types of choice
            //first choice
            texts[0, 0] = "     ;";
            texts[0, 1] = "     ;;";
            texts[0, 2] = "     ;';.";
            texts[0, 3] = "     ;  ;;";
            texts[0, 4] = "     ;   ;;";
            texts[0, 5] = "     ;    ;;";
            texts[0, 6] = "     ;    ;;";
            texts[0, 7] = "     ;   ;'";
            texts[0, 8] = "     ;  '";
            texts[0, 9] = ",;;;,;";
            texts[0, 10] = ";;;;;;";
            texts[0, 11] = "`;;;;'";

            //second choice
            texts[1, 0] = "     ;;;;;;;;;;;;;;;;;;;";
            texts[1, 1] = "     ;;;;;;;;;;;;;;;;;;;";
            texts[1, 2] = "     ;                 ;";
            texts[1, 3] = "     ;                 ;";
            texts[1, 4] = "     ;                 ;";
            texts[1, 5] = "     ;                 ;";
            texts[1, 6] = "     ;                 ;";
            texts[1, 7] = "     ;                 ;";
            texts[1, 8] = "     ;                 ;";
            texts[1, 9] = ",;;;;;            ,;;;;;";
            texts[1, 10] = ",;;;;;            ,;;;;;";
            texts[1, 11] = "`;;;;'            `;;;;'";

            //third choice
            texts[2, 0] = "        ..,,,,,..";
            texts[2, 1] = "    .,;;;;;;;;;;;;;;,.";
            texts[2, 2] = "  ,;;;'            `;;;;,       ,,";
            texts[2, 3] = " ,;'                 ';;;;,    ;;;;";
            texts[2, 4] = ".;.;;;;,               ;;;;;.   ''";
            texts[2, 5] = ";;;;;;;;                ;;;;;";
            texts[2, 6] = "`;;;;;;'                ;;;;;";
            texts[2, 7] = "                        ;;;;'   ,,";
            texts[2, 8] = "                      .;;;;'   ;;;;";
            texts[2, 9] = "                     ,;;;'      ''";
            texts[2, 10] = "                   ,;;;'";
            texts[2, 11] = "                ,;;;'";
            texts[2, 12] = "            .;;;;'";
            texts[2, 13] = "       .,;;;''";
            texts[2, 14] = "    .,;;''";

            //print welcome and options
            Console.WriteLine("**************** Welcome to the ASCII Replacer! *****************");
            Console.WriteLine();
            //print ask user to input
            Console.WriteLine("Your options:");
            Console.WriteLine();

            //print three choices
            //print first pattern
            Console.WriteLine("a.");
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine(texts[0, i]);
            }
            Console.WriteLine();

            //print second pattern
            Console.WriteLine("b.");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(texts[1, i]);
            }
            Console.WriteLine();

            //print third pattern
            Console.WriteLine("c.");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(texts[2, i]);
            }

            //print and ask user input
            Console.WriteLine();
            Console.WriteLine("Which text would you like to play with (please type a, b, or c)? what?");
            Console.Write("\tPlease type a valid choice: ");
            char userChoiece = GetUserInput('a', 'c');       //call get user input method and store character valiable

            //print and ask user choose and replace character
            Console.WriteLine();
            Console.Write("Which character would you like to replace? ");
            char choose = GetUserInput(' ', '~');     //call get user input method and store character valiable
            Console.Write("Which character would you like to replace it with (type ' ' -space- if you like a random one? ");
            char replace = GetUserInput(' ', '~');     ////call get user input method and store character valiable
            //if user choose space, give a random value
            if (replace == ' ')
            {
                Random randomObj = new Random();      //create a random object
                replace = (char)randomObj.Next(' ', (1 + '~'));        //call method to assign random value
            }

            //print user's choice
            Console.WriteLine();
            Console.WriteLine("Original character: " + choose + " replace with: " + replace);
            Console.WriteLine();

            //Replace character by user's choices and print it
            //first choice
            if (userChoiece == 'a')
            {
                for (int i = 0; i < 12; i++)
                {
                    string newTexts = ReplaceChar(texts[0, i], choose, replace);
                    Console.WriteLine(newTexts);
                }
            }
            //second choice
            if (userChoiece == 'b')
            {
                for (int i = 0; i < 12; i++)
                {
                    string newTexts = ReplaceChar(texts[1, i], choose, replace);     //call method to replace text
                    Console.WriteLine(newTexts);                   //print replaced text
                }
            }
            //third choice
            if (userChoiece == 'c')
            {
                for (int i = 0; i < 15; i++)
                {
                    string newTexts = ReplaceChar(texts[2, i], choose, replace);          //call method to replace text
                    Console.WriteLine(newTexts);                  //print replaced text
                }
            }

            //print thanks for place and texts resouces
            Console.WriteLine();
            Console.WriteLine("************ Thanks for Playing >_< ***************");
            Console.WriteLine();
            Console.WriteLine("\tASCII	art	from	Ascii-Code.com	(https://www.ascii-code.com/ascii-art/music/musical-notation.php)");
            Console.WriteLine();

        }

        //method to get user character
        //two parameter
        //return chracter
        static char GetUserInput(char lowBound, char highBound)
        {
            //print to ask user input
            
            string input = Console.ReadLine();

            //create valiable to hold input after parsing
            char inputParse;

            //create boolean valiable to check if use input character or other
            bool check = false;
            //if input is character, check is true
            if (char.TryParse(input, out inputParse))
            {
                check = true;
            }
            //if input is not a charcater, check is false
            else
            {
                check = false;
            }

            //create other boolean for starting while loop
            bool checkAll = true;
            while (checkAll == true)
            {
                //if input is character
                if (check == true)
                {
                    //if input is a, b, c. store user's information
                    if ((inputParse >= lowBound) && (inputParse <= highBound))
                    {
                        checkAll = false;
                    }
                    //if input is not a, b, c. run loop to ask input again
                    else
                    {
                        //print type valid value
                        Console.Write("\tPlease type a valid choice: ");
                        input = Console.ReadLine();
                        //check if input is character again
                        if (char.TryParse(input, out inputParse))
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                        }

                        checkAll = true;
                    }
                }

                //if input is not character, run loop and ask input again
                if (check == false)
                {
                    //print type valid value
                    Console.Write("\tPlease type a valid choice: ");
                    input = Console.ReadLine();
                    //check if input is character again
                    if (char.TryParse(input, out inputParse))
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }

                    checkAll = true;
                }
            }

            //return parsed value
            return inputParse;
        }

        //method to replace character
        //string parameter and two character parameters
        //return string
        static string ReplaceChar(string given, char search, char replace)
        {
            char[] encodeArray; //create character array
            encodeArray = new char[given.Length];    //make same size with incoming string
            for(int i = 0; i < encodeArray.Length; i++)
            {
                encodeArray[i] = given[i];       //assign string characters to character array

                if(encodeArray[i] == search)
                {
                    encodeArray[i] = replace;      //replace new value to character array
                }
            }
            //return a new string
            return new string(encodeArray);
        }
    }
}