﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check to see if a string is a palindrome
            //Console.WriteLine("Enter a string");
            //string userInput = Console.ReadLine();  
            //string userInputReversed = "";
            //for (int i = userInput.Length - 1; i >= 0; i--)
            //{
            //    userInputReversed = userInputReversed + userInput[i];   
            //}
            //Console.WriteLine(userInputReversed);



            //Remove duplicate characters from a string
            //Console.WriteLine("Please enter a word");
            //string userInputB = Console.ReadLine();
            //string userInputMinusDups = "";
            //foreach (char item in userInputB)
            //{
            //    for (int i = 0; i < userInputB.Length; i++)
            //    {
            //        if(!userInputMinusDups.Contains(item))
            //        {
            //            userInputMinusDups += item;

            //        }

            //    }
            //}
            //Console.WriteLine(userInputMinusDups);



            //Check to see if a number is an Armstrong number
            //Console.WriteLine("Please enter a number");
            //string userInputC = Console.ReadLine();
            //int userInputCInt = int.Parse(userInputC);
            //int num1 = int.Parse(userInputC[0].ToString());
            //int num2 = int.Parse(userInputC[1].ToString());
            //int num3 = int.Parse(userInputC[2].ToString());
            //if (num1 * num1 * num1 + num2 * num2 * num2 + num3 * num3 * num3 == userInputCInt)
            //{
            //    Console.WriteLine("Your number is an Armstrong number.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is NOT an Armstrong number.");
            //}



            //Produces all Armstrong numbers between 1 and 1000
            int numa = 0;
            int numab = 0;
            int numb = 0;
            int numc = 0;

            for (int i = 100; i < 1000; i++)
            {
                numc = i % 10;//last digit 1
                numab = i / 10;//first two digits  37
                numb = numab % 10; //middle digit 7
                numa = numab / 10;//first digit
               
                if(numa * numa * numa + numb * numb * numb + numc * numc * numc == i)
                {
                    Console.WriteLine(i + " is an Armstrong number");
                }
            }



        }
    }
}
