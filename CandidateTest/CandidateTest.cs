using System;
using System.Collections.Generic;

namespace CandidateTest
{
    public static class TestFunctions
    {
        /// <summary>
        /// Function to calculate the cost to the business for a company wide bonus payment
        /// </summary>
        /// <param numberOfEmployees="Number Of Employees"></param>
        /// <param bous="Bonus Payment"></param>
        /// <returns>The cost to the company for making a company wide bonus payment</returns>
        public static double BonusCalculation(int numberOfEmployees, double bonus)
        {
            double total = 0;

            for (int x = 0; x < numberOfEmployees; x++)
            {
                total += bonus;
            }

            return total;
        }

        /// <summary>
        /// Takes 2 string arrays returns 1 string array containing each name only once, in alphabetical order (remove duplicates).
        /// </summary>
        /// <param name="names1"></param>
        /// <param name="names2"></param>
        /// <returns>String list containing unique names, ordered alphabetically</returns>
        public static List<string> UniqueNames(List<string> names1, List<string> names2)
        {
            return new List<string>();
        }

        /// <summary>
        /// Takes an input phrase & return the letter that appears most in the phrase
        /// </summary>
        /// <param name="input"></param>
        /// <returns>character that appears the most</returns>
        public static char PopularLetter(string input)
        {
            return 'a';
        }
    }
}
