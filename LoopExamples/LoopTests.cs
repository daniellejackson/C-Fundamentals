using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total !=10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;

            while (total<10)
            {
                if (total == 10)
                { Console.WriteLine("Goal Reached");

                    break;
                }

                total++;
               
            }
            Random random = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping) 
            {
                someCount = random.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount ==15)
                { keepLooping = false;
                
                }



            }
            

        }
        [TestMethod]
        public void ForLoops()

        {
            int studentCount = 21;

            for (int i = 0; i < studentCount; i++)

            {
                Console.WriteLine(i);

            }

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ineborg" };

            foreach (int i = 0; i < students.Length; i++)

            {
                Console.WriteLine(students + " is a student in the class");
            }

            string MyName = "Danielle Eugenia Jackson";
            foreach (char letter in MyName)
        }
    }
}
