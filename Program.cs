using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here
            {
                Console.WriteLine("Enter First Number");
                int firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int secondnumber = Convert.ToInt32(Console.ReadLine());

                if (firstnumber == secondnumber)

                Console.WriteLine("The numbers "+firstnumber+" and "+secondnumber+" are the same ");

                else
                { Console.WriteLine("These numbers are not equal"); }
                Console.WriteLine("--------------------------------------");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
        }

        static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here
            // NOTE: good solution, novice developers should us curly braces, you also have unnecessary braces on lines 114 and 130
            {
                Console.WriteLine("Enter Number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)

                    Console.WriteLine(num + " is an even number");

                else

                    Console.WriteLine(num + " is an odd number");


                Console.WriteLine("--------------------------------------");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
        }

        static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here
            Console.WriteLine("Enter a character:");
            char input = Char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u'  )
            {
                Console.WriteLine("This is a vowel");
            }
            
            if (input == 'y')
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("'Y' is considered to be a vowel if… ");
                Console.WriteLine("The word has no other vowel or ");
                Console.WriteLine("The letter is at the end of a word or syllable or ");
                Console.WriteLine("The letter is in the middle of a syllable BUT ");
                Console.WriteLine("'Y' can represent a consonant when it starts off a word or syllable. ");
                Console.WriteLine("This is a vowel");
                Console.WriteLine("but also");
            }

            else if ((input >= 'a' || input == 'z'))
            {

                Console.WriteLine("This is a consonant");
            }


            Console.WriteLine("--------------------------------------");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here
            // NOTE: good solution 
            {
                int number1;
                int number2;
                int number3;

                Console.Write("Input the 1st number :");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 2nd number :");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd  number :");
                number3 = Convert.ToInt32(Console.ReadLine());


                if (number1 > number2)
                {
                    if (number1 > number3)
                    {
                        Console.Write(number1+" is the larger number");
                    }
                    else
                    {
                        Console.Write(number3+" is the larger number");
                    }
                }

                else if (number2 > number3)
                    Console.Write(number2+" is the larger number");
                
                else
                    Console.Write(number3+" is the larger number");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here
            // NOTE: good solution
            Console.WriteLine("Enter number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The remainder is");
            Console.WriteLine(userInput % 3);
            Console.WriteLine();

            if (userInput % 3 == 0)
            {

                Console.WriteLine("divisible by 3");
            }

            else 
            {

                Console.WriteLine("not divisible by 3");
            }
            
            Console.WriteLine("--------------------------------------");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here
            // NOTE: good solution; think about using some pre-calculated math, like .9 or .95 instead of /100
            Console.WriteLine("Enter number of people");
            float dinners = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter what each person paid");
            float paid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Your total is...");
            float total = (dinners * paid);
            Console.WriteLine(total);
           
            
            
            double discount10 =90;

            double discount5 =95;

            if (total >= 50)
            {
                Console.WriteLine("");
                Console.WriteLine("Congratulations! you qualify for a 10% discount");
                Console.WriteLine("");
                Console.WriteLine("Your new total is...");
                Console.WriteLine(total * discount10 / 100);
            }      
            else if (total <= 49)
            {
                Console.WriteLine("");
                Console.WriteLine("Congratulations! you qualify for a 5% discount");
                Console.WriteLine("");
                Console.WriteLine("Your new total is...");
                Console.WriteLine(total * discount5 / 100);
            }
            
            Console.WriteLine("--------------------------------------");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
            // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here
            // NOTE: good solution, use curly braces on if statements and you have extra unncessary brackets
            { 
            Console.WriteLine("Enter your age.");
            Console.WriteLine();
            Console.WriteLine("***ONLY USE NUMBERS***");

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

                {
                    if (age <= 0)
                        Console.WriteLine("This program is for humans");
                    else if (age <= 2)
                        Console.WriteLine("You are in Still in Mama's Arms ");
                    else if (age <= 4)
                        Console.WriteLine("You are in Preschool Maniac");
                    else if (age <= 11)
                        Console.WriteLine("You are in Elementary School");
                    else if (age <= 14)
                        Console.WriteLine("You are in Middle School");
                    else if (age <= 18)
                        Console.WriteLine("You are in High School");
                    else if (age <= 22)
                        Console.WriteLine("You are in College");
                    else if (age <= 65)
                        Console.WriteLine("You are still Working for the Man");
                    else if (age <= 100)
                        Console.WriteLine("You are in The Golden Years.");
                    else if (age >= 100)
                        Console.WriteLine("This program is for humans");
                }
                
                Console.WriteLine("--------------------------------------");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
        }

        static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");


            // Enter your solution here
            // NOTE: good solution but needs ToLower()
                Console.WriteLine("Type a number from zero to ten");
                string number = Console.ReadLine();
                
                    switch (number)
                    {
                    case "zero":
                        Console.WriteLine("0");
                        break;
                    case "one":
                        Console.WriteLine("1");
                        break;
                    case "two":
                        Console.WriteLine("2");
                        break;
                    case "three":
                        Console.WriteLine("3");
                        break;
                    case "four":
                        Console.WriteLine("4");
                        break;
                    case "five":
                        Console.WriteLine("5");
                        break;
                    case "six":
                        Console.WriteLine("6");
                        break;
                    case "seven":
                        Console.WriteLine("7");
                        break;
                    case "eight":
                        Console.WriteLine("8");
                        break;
                    case "nine":
                        Console.WriteLine("9");
                        break;
                    case "ten":
                        Console.WriteLine("10");
                        break;
                    }
            
            Console.WriteLine("--------------------------------------");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here
            // NOTE: good solution
            {
               
                Console.WriteLine("Enter the first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter the second name");
                string LastName = Console.ReadLine();
                
                int numberOfLetters1 = firstName.Length;
                int numberOfLetters2 = LastName.Length;


                {   if (numberOfLetters1 > numberOfLetters2)

                        Console.WriteLine(firstName + " First is longer. " + LastName);

                    if (numberOfLetters1 < numberOfLetters2)

                        Console.WriteLine(LastName + " Last must be longer! " + firstName);

                    if (numberOfLetters1 == numberOfLetters2)
                        Console.WriteLine("Same-sies");
                }

                Console.WriteLine("--------------------------------------");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }
        }

        static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            // NOTE: good solution
            {
                Console.WriteLine("Enter the first name");
                string firstName = (Console.ReadLine());
                Console.WriteLine("Enter second name");
                string secondName = (Console.ReadLine());
               
                {
                    if (firstName == secondName)

                        Console.WriteLine("The names are the same.");

                    else
                        Console.WriteLine("The names are different.");
                }
            }
            Console.WriteLine("--------------------------------------");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            // NOTE: good solution
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Your name is " + name);
                
                Console.Clear();
                
                Console.WriteLine("what is your birthplace");
                string birthPlace = Console.ReadLine();
                
                Console.Clear();
                
                Console.WriteLine("Hi " + name + "!, You were born in " + birthPlace);
                
                Console.WriteLine();
                
                Console.WriteLine("--------------------------------------");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

        }
    }
}