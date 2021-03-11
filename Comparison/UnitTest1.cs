using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Mick";

            bool equals = age == 41;
            Console.WriteLine(equals);

            bool userisTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            Console.WriteLine("User is 41:" + equals);

            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            bool greaterThan = age > 12;

            bool greaterThanOrEqual = age <= 24;
            Console.WriteLine(greaterThanOrEqual);

            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            bool lessthanOrEqualTo = age <= 24;
            Console.WriteLine(lessthanOrEqualTo);

            bool orvalue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine($"True or True"{tOrT});
            Console.WriteLine($"True or False"{tOrF});
            Console.WriteLine($"False or True"{fOrT});
            Console.WriteLine($"False or False"{fOrF});

            bool andvalue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue



        }
    }
}
