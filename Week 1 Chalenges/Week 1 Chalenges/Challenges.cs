using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Chalenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void Week1Challenges()
        {
            string firstName = "Tanner";
            string lastName = "Lemon";
            int age = 28;

            string[] favoriteMovies = { "The Pursuit of Happyness", "The Lord of the Rings", "Forest Gump", "500" };
            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Now);
            DateTime yesterday = new DateTime(2020, 11, 16);
            dates.Add(yesterday);

            int agePlus = age + 7;
            Console.WriteLine(agePlus);

            int ageMinus = age - 7;
            Console.WriteLine(ageMinus);

            int ageTimes = age * 7;
            Console.WriteLine(ageTimes);

            int ageDivided = age / 7;
            Console.WriteLine(ageDivided);

            int ageMod = age % 7;
            Console.WriteLine(ageMod);

        }

        [TestMethod]
        public void SleepDay()
        {
            int hoursOfSleep = 13;

            if (hoursOfSleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursOfSleep >= 8 && hoursOfSleep < 10)
            {
                Console.WriteLine("You should be pretty rested");
            } 
            else if (hoursOfSleep > 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("Bummer")
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            string howWasYourDay = "Great";

            switch (howWasYourDay)
            {
                case "Great":
                    Console.WriteLine("Congratulations.");
                    break;
                case "Good":
                    Console.WriteLine("Getting there.");
                    break;
                case "Okay":
                    Console.WriteLine("Well, why just okay?.");
                    break;
                case "Bad":
                    Console.WriteLine("That sucks.");
                    break;
                default:
                   Console.WriteLine("Weird");
                   break;
            }
        }
    }
}
