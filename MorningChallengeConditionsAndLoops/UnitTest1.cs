using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallengeConditionsAndLoops
{
    [TestClass]
    public class ChallengeConditionsLoops
    {
        [TestMethod]
        public void ChallengeCL()
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            //2Bonus:
            foreach (char letter in word)
            {
                //only print the letter if its I
                if (letter=='i') //check this first
                {
                    Console.WriteLine('i');
                }
               else if (letter == 'l') //check second
                {
                    Console.WriteLine('L');
                }
                else //and if it doesn't work print this
                {
                    Console.WriteLine("Not an I");
                    
                }
                
            }
            Console.WriteLine($"number of letters in the word: {word.Length}");

        }
        [TestMethod]
        public void Chores()
        {

        }
    }
}
