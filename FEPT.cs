﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticeTestPROJ
{
    class FEPT
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Console.WriteLine("The greatest number of the 3 entered is:" + getGreatestValueof3());


            //Exercise Extra
            //isKnumbertheAddof2();

            //Exercise 2
            //GetStudentsGrade();

            //Exercise 3
            //Console.WriteLine("The number of digits of the integer number entered is:" + CountTheNumberOfDigits());

            //Exercise 4
            //PrintTableOfChars();

            Console.ReadLine();

            string sentence = Console.ReadLine();
        }
        //1.Implement a method that prompts the user to input three integer values and find the 
        //greatest value of the three values.
        static private string getGreatestValueof3()
        {
            int a1 = 0;
            Console.WriteLine("Please insert number 1:");
            int.TryParse(Console.ReadLine(), out a1);

            int a2 = 0;
            Console.WriteLine("Please insert number 2:");
            int.TryParse(Console.ReadLine(), out a2);

            int a3 = 0;
            Console.WriteLine("Please insert number 3:");
            int.TryParse(Console.ReadLine(), out a3);

            int[] ResultArray = { a1, a2, a3 };
            Array.Sort(ResultArray);

            return ResultArray[2].ToString();

        }

        //Extra.Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        static private bool isKnumbertheAddof2()
        {
            int K = 17;
            int S;
            bool boolSRFN;
            int[] ArraySRFN = { 210, 26, 25, 18, 2, 16, 2, 1, 0, 3, 10, 15, 3, 7 };
            int ArrayLength;

            ArrayLength = ArraySRFN.Length;
            int ArrayLengthMinus1 = ArrayLength - 1;
            Console.WriteLine(ArrayLength.ToString());

            Array.Sort(ArraySRFN);
            Array.Reverse(ArraySRFN);

            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("iteration for MAIN number:" + ArraySRFN[i]);
                S = K - ArraySRFN[i];
                for (int j = 0; j < ArrayLength; j++)
                {
                    Console.WriteLine("iteration for SECONDARY number:" + ArraySRFN[j]);
                    if (j == i) { Console.WriteLine("equal number"); }
                    else
                    {
                        if (S == ArraySRFN[j])
                        {
                            boolSRFN = true;
                            Console.WriteLine("true");
                            return boolSRFN;
                        }
                        else { Console.WriteLine("one iteration corresponding with numbers:"); };
                    }
                }
            }
            boolSRFN = false;
            Console.WriteLine("false");
            return boolSRFN;
        }

        //2.Write a method that determines a student’s grade. The method will read three types of
        //scores(quiz score, mid-term score, and final score) and determine the grade based on
        //the following rules:
        static private string GetStudentsGrade()
        {
            int grade1;
            int grade2;
            int grade3;
            int AverageGrade;

            Console.WriteLine("Please enter the quiz score (0-100):");
            int.TryParse(Console.ReadLine().ToString(), out grade1);
            Console.WriteLine("");

            Console.WriteLine("Please enter the mid-term score (0-100):");
            int.TryParse(Console.ReadLine().ToString(), out grade2);
            Console.WriteLine("");

            Console.WriteLine("Please enter the final score (0-100):");
            int.TryParse(Console.ReadLine().ToString(), out grade3);
            Console.WriteLine("");

            AverageGrade = (grade1 + grade2 + grade3) / 3;

            Console.WriteLine("The average grade is:" + AverageGrade.ToString());
            Console.WriteLine("--------------------------------------------------");

            if (AverageGrade == 90) { Console.WriteLine("Your final grade is: Grade A"); return "Grade A"; }
            else if ((AverageGrade >= 70) && (AverageGrade < 90)) { Console.WriteLine("Your final grade is: Grade B"); return "Grade B"; }
            else if ((AverageGrade >= 50) && (AverageGrade < 70)) { Console.WriteLine("Your final grade is: Grade C"); return "Grade C"; }
            else if (AverageGrade < 50) { Console.WriteLine("Your final grade is: Grade F"); return "Grade F"; }
            else { Console.WriteLine("Not any grade applicable"); return "Not any grade applicable"; };
        }

        //3.Write a method that counts the number of digits in an integer number.For example; 23498 has five digits.
        static private int CountTheNumberOfDigits()
        {
            int numberEntered;
            string numberEnteredSTRNG;
            Console.WriteLine("To calculate the number of digits, ENTER an integer number please:");
            numberEnteredSTRNG = Console.ReadLine();
            int.TryParse(numberEnteredSTRNG, out numberEntered);

            Console.WriteLine("the number entered as INTEGER is:" + numberEntered.ToString());
            Console.WriteLine("the number entered as STRING is:" + numberEnteredSTRNG);
            Console.WriteLine("");
            return numberEnteredSTRNG.Length;
        }

        //4.Write a method to print the table of characters that are equivalent to the ASCII codes from 1 to 122.
        //  The program will print the 10 characters per line.
        static private void PrintTableOfChars()
        {
            //
        }


    }
}
