using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }


        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if(isTrue)
            {

            }

            int age = 28;

            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                Console.WriteLine("You're still a kid.");
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:

                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // bool someVariable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;
        }
    }
}
