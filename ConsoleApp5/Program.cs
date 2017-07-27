using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Square or Cube Calculator. I calculate squares or cubes up to the number you request.");
            bool cont = true;

            while (cont == true){ //while bool is true run all this code; bool will be false when user selects anything other than 1 down below
         
            Console.WriteLine("Please enter a 2 to find squares, 3 to find cubes.");
            string sqcu = Console.ReadLine();

                if (sqcu == "2" || sqcu == "3")//so long as the user doesnt tell me a 1 or 2, this loop cannot be ran. User will be asked for a 2 3 endlessly.
                {
     
                    float findNumber;
                    float finalAnswer;
                    bool acceptable = true;
                    string telluser = " ";

                    Console.WriteLine("Enter a number only please.");
                    string userWants = Console.ReadLine(); 
                    while (acceptable == true)
                    {
               
                        acceptable = float.TryParse(userWants, out findNumber); //user enters a float: Acceptable is true, we can run calculations. False, we ask for number again.

                        if (acceptable == true)
                        {
                            if (sqcu == "2")
                            {
                                telluser = "squared";

                            }
                            if (sqcu == "3")
                            {
                                telluser = "cubed";
                            }
                            finalAnswer = DoCalc(findNumber, sqcu);
                            Console.WriteLine("Each integer " + telluser + " up to " +findNumber + "=" + finalAnswer);
                            acceptable = false;
                        }
                        
   
                        Console.WriteLine("Want to do this again? 1 for yes, anything else for no."); //checks if user wants to continue
                        string keepGoing = Console.ReadLine();

                        if (keepGoing == "1")
                        {
                            cont = true;
                        }
                        else
                        {
                            acceptable = false;
                            cont = false;
                         
                        } //program quits when user doesnt enter a 1 here
                    }
                }
                }
                }
        
        public static float DoCalc(float userInput, string sqOrCu)
        {
            float result = 0;


            for (float i = 1; i < (userInput + 1); i++)
            {
                if (sqOrCu == "2")
                {
                    result = result + (i * i); //so userInput is 3. Math would go 0 + (1*1) = 1, 1 + (2 * 2) = 5, 5 + (3 * 3) = 14 result would be 14
                }

                if (sqOrCu == "3")
                {
                    result = result + (i * i * i);
                }
            }


            return result;
        }
    }

   
    
}
