﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            //bool is true/false 
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }

        }
        [TestMethod]

        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the moives");

            }
            else
            {
                Console.WriteLine("You must stay home and finish your CHORES!!");

            }

            string input = "7";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested!!");
            }
            else
            {
                Console.WriteLine("You mught be tired today.");
                if (totalHours < 4)

                {
                    Console.WriteLine("You should get more SLEEP!!!");

                }

            }
            int age = 22;
            if (age > 17)
            {
                Console.WriteLine("You are an Adult");
            }
            else
            {

                if (age > 0)
                {
                    Console.WriteLine("You are a kid");
                }
                else

                {
                    if (age > 6)
                    {
                        Console.WriteLine("You are a kid");
                    }

                    else if (age > 0)
                    {
                        Console.WriteLine("You are far too young to be on a computer");
                    }
                    else
                    {
                        Console.WriteLine("You are not born yet");
                    }

                }

            }

            if(age< 65 && age > 18)
            { Console.WriteLine("Age is between 18 and 65");

            }

            if(age > 65 || age < 18)
            { Console.WriteLine("Age is either Greater than 65 or Less than 18");

            }
            if(age== 21)

            { Console.WriteLine("Age is equal to 21"); 
            
            }
            if(age !=36)

            { Console.WriteLine("Age is not equal to 36!!"); 
            
            }

        }
    }
}

        



   

