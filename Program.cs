using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your birth year?");

            int inputYear =int.Parse ( Console.ReadLine());  // make it integer using .parse for user input
            int today= DateTime.Now.Year;                   // its count todays date

            int age = today - inputYear;                    // age difference calculation
            //Console.WriteLine(age);
            if(age < 18)                                    // conditional statement for ídentifying over and below 18 age
            {
                Console.WriteLine("Your age is " + age + ".");
                Console.WriteLine("Your are not old enough to use this application. " );



            }
            else
            {
                Console.WriteLine("Your age is " + age +".");
                Console.WriteLine("\n");

                Console.WriteLine("Welcome, please answer the below verification questions: ");
                Console.WriteLine("\n");


                string[] question = new string[]                            // Make an array for three question for over 18 ages peopole
                {
                   "1. What is your name?",
                   "2. What is favourite game?",
                   "3. What is your fvourite song?"
                };

                string[] answer = new string[]                            // Make an array for those three question answer.
                {
                   "surat",
                   "football",
                   "song"
                };

                List<string> notes = new List<string>();                  // Make a list for storing the question answer from user.


                for (int i=0; i< question.Length; i++)
                {
                    Console.WriteLine(question[i]);
                    string  insert= (Console.ReadLine());
                    notes.Add(insert);                                  // add the user answer in the list 



                }
                

                if (answer[0] == notes[0] && answer[1] == notes[1] && answer[2] == notes[2])         // compare the user answer with our answer.
                {
                    Console.WriteLine("\n");

                    Console.WriteLine("Welcome to the application!");
                    

                }
                else
                {
                    Console.WriteLine("\n");

                    Console.WriteLine("Nice try!");
                               
                }

                        
                
                //Console.WriteLine("what is your name?");                                        // this part for myself 
                //string insertedQuestion = Console.ReadLine();
                //if (insertedQuestion == "polash")
                //{
                //    //Console.WriteLine("welcome to the application");
                //}
                //else
                //{
                //    //Console.WriteLine("Sorry, Nice try");
                //}


                //Console.WriteLine("what is your favourite movie?");
                //string insertedQuestion1 = Console.ReadLine();
                //if (insertedQuestion1 == "surat")
                //{
                //    //Console.WriteLine("welcome to the application");
                //}
                //else
                //{
                //    //Console.WriteLine("Sorry, Nice try");
                //}


                //Console.WriteLine("what is your favourite game?");
                //string insertedQuestion2 = Console.ReadLine();
                //if (insertedQuestion2 == "football")
                //{
                //    Console.WriteLine("welcome to the application");
                //}
                //else
                //{
                //    Console.WriteLine("Sorry, Nice try");
            }

            


        }
    }
}
