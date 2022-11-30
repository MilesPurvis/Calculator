/*
 * Program: Assignment 3 Part 2
 * 
 * Purpose: Four number calculator
 * 
 * Revision History:
 *  Created By Miles Purvis & Gabriel Siewart
 *  Nov 2nd 2022
 * 
 */
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3MPGSP2
{
    internal class Program
    {
        //Main execute the code for menu selection and directs the selection to the corret method using a switch case
        static void Main(string[] args)
        {
            //Declare Variables
            int input;
            bool endLoop = true;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("[Menu]");
                    //Prompt user for operator selection
                    Console.WriteLine("\nConestoga's PROG1925 Calculator");
                    Console.WriteLine("1) Addition");
                    Console.WriteLine("2) Subtract");
                    Console.WriteLine("3) Multiply");
                    Console.WriteLine("4) Divide");
                    Console.WriteLine("5) Exit");

                    Console.Write("\nPlease make a selection (1,2,3,4) or 5 to Exit: ");
                    input = Convert.ToInt32(Console.ReadLine());

                    //switch case to direct seleciton to the right method for the operator chosen
                    switch (input)
                    {
                        case 1:
                            Add();
                            break;
                        case 2:
                            Subtract();
                            break;
                        case 3:
                            Multiply();
                            break;
                        case 4:
                            Divide();
                            break;
                        case 5:
                            endLoop = false;
                            break;
                    }

                }
                //Catches OverflowException and FormatExceptions aswell as default Exception
                catch (FormatException fEx)
                {
                    Console.WriteLine("\n" + fEx.Message);
                    Console.WriteLine("\nPress any key to return to menu");
                    Console.ReadKey();
                }
                catch (OverflowException oEx)
                {
                    Console.WriteLine("\n" + oEx.Message);
                    Console.WriteLine("\nPress any key to return to menu");
                    Console.ReadKey();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                    Console.WriteLine("\nPress any key to return to menu");
                    Console.ReadKey();

                }
            } while (endLoop == true);

        }
        //Add takes four numbers and then displays the result.
        static void Add()
        {
            try
            {
                //Declare Variables
                int numOne;
                int numTwo;
                int numThree;
                int numFour;
                int sum;

                Console.Clear();
                Console.WriteLine("[Addition]");

                //Prompt User for Numbers
                Console.WriteLine("Choose Numbers");

                //take input for numOne, numTwo, numThree and numFour
                Console.Write("Number One: ");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Two: ");
                numTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Three: ");
                numThree = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Four: ");
                numFour = Convert.ToInt32(Console.ReadLine());

                //sum = the Sum of numOne, numTwo, numThree and numFour
                sum = numOne + numTwo + numThree + numFour;

                Console.WriteLine("{0} + {1} + {2} + {3} = {4}", numOne, numTwo, numThree, numFour, sum);
                Console.WriteLine("\nPress any Key to Main Menu");
                Console.ReadKey();
            }
            //Catches OverflowException and FormatExceptions aswell as default Exception
            catch (FormatException fEx)
            {
                Console.WriteLine("\n" + fEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
            catch (OverflowException oEx)
            {
                Console.WriteLine("\n" + oEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
        }
        //Subtract takes four numbers and subtracts them as entered.
        static void Subtract()
        {
            try
            {
                //Declare Variables
                int numOne;
                int numTwo;
                int numThree;
                int numFour;
                int difference;

                Console.Clear();
                Console.WriteLine("[Subtract]");

                //Prompt User for Numbers
                Console.WriteLine("Choose Numbers");

                //take input for numOne, numTwo, numThree and numFour
                Console.Write("Number One: ");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Two: ");
                numTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Three: ");
                numThree = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Four: ");
                numFour = Convert.ToInt32(Console.ReadLine());

                //difference = the Difference of numOne, numTwo, numThree and numFour
                difference = numOne - numTwo - numThree - numFour;

                Console.WriteLine("{0} - {1} - {2} - {3} = {4}", numOne, numTwo, numThree, numFour, difference);
                Console.WriteLine("\nPress any Key to Main Menu");
                Console.ReadKey();
            }
            //Catches OverflowException and FormatExceptions aswell as default Exception
            catch (FormatException fEx)
            {
                Console.WriteLine("\n" + fEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
            catch (OverflowException oEx)
            {
                Console.WriteLine("\n" + oEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
        }

        //Multiply takes four numbers and multiplies them as entered.
        static void Multiply()
        {
            try
            {
                //Declare Variables
                int numOne;
                int numTwo;
                int numThree;
                int numFour;
                int product;

                Console.Clear();
                Console.WriteLine("[Multiply]");

                //Prompt User for Numbers
                Console.WriteLine("Choose Numbers");

                //take input for numOne, numTwo, numThree and numFour
                Console.Write("Number One: ");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Two: ");
                numTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Three: ");
                numThree = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number Four: ");
                numFour = Convert.ToInt32(Console.ReadLine());

                //Product = the product of numOne, numTwo, numThree and numFour
                product = numOne * numTwo * numThree * numFour;

                Console.WriteLine("{0} * {1} * {2} * {3} = {4}", numOne, numTwo, numThree, numFour, product);
                Console.WriteLine("\nPress any Key to Main Menu");
                Console.ReadKey();
            }
            //Catches OverflowException and FormatExceptions aswell as default Exception
            catch (FormatException fEx)
            {
                Console.WriteLine("\n" + fEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
            catch (OverflowException oEx)
            {
                Console.WriteLine("\n" + oEx.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
                Console.WriteLine("\nPress any key to return to menu");
                Console.ReadKey();

            }
        }
        //Divide allows the user to enter only 2 numbers.
        static void Divide()
        {
            try
            {
                //Declare variables
                decimal selectionOne;
                decimal selectionTwo;
                decimal remainder;

                Console.Clear();
                //Prompt User for input
                Console.WriteLine("Which Numbers would you like to divide?");

                //take input for selectionOne
                Console.Write("Enter a number: ");
                selectionOne = Convert.ToDecimal(Console.ReadLine());
                //take input for selectionTwo
                Console.Write("Enter a denominator: ");
                selectionTwo = Convert.ToDecimal(Console.ReadLine());

                //remainder is the remainder of selectionOne and selectionTwo
                remainder = selectionOne / selectionTwo;

                Console.WriteLine("\nThe remainder of the numbers chosen is {0:.000}", remainder);
                Console.WriteLine("\nPress any Key to Main Menu");
                Console.ReadKey();
            }

            //Catches DivideByZero and FormatExceptions aswell as default Exception
            catch (DivideByZeroException dEx)
            {
                Console.WriteLine("\n" + dEx.Message + "\n\nPress Any Key to return to Main Menu");
                Console.ReadKey();
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("\n" + fEx.Message + "\n\nPress any Key to Main Menu");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message + "\n\nPress any Key to Main Menu");
                Console.ReadKey();

            }
        }
    }

}
