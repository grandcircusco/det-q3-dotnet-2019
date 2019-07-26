using System.Collections.Generic;
using Xunit;
using System;


namespace MockAssessment2a
{
    public class MockAssessment2aTests
    {
        [Fact]
        public static void AddToArray()
        {            
            int actual = Challenge.AddStarWarsCharacters("Luke", "Darth", "Yoda");

            Assert.Equal(2, actual);
        }

        [Fact]
        public static void TestOfStrength()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Yoda", 4500000);
            dictionary.Add("Darth", 60200);
            dictionary.Add("Luke", 3000);

            string expected = "Yoda".ToLower();

            string actual = Challenge.DeathStarCombat(dictionary).ToLower();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void PlanetReversal()
        {
            string[] planeted = {"Tatooine", "Alderaan", "Hoth", "Naboo", "Endor" };

            List<string> expected = new List<string> {"Endor", "Naboo", "Hoth", "Alderaan", "Tatooine" };
            List<string> actual = Challenge.ConvertPlantets(new List<string>(), planeted);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void DroidAverages()
        {
            List<int> droids = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 23, 16, 5678, 234, 5, 46, 678, 9, 87, 456, 356, 34, 2 };


            double expected = 537.857142857143;           

            double actual = Challenge.AverageDroids(droids);

            Assert.Equal(Math.Round(expected, 2), Math.Round(actual, 2));
        }
        
        [Fact]
        public static void VaderWasCaptured()
        {
            string expected = "Vader Was Captured".ToLower();
            string actual = Challenge.TryToCatchDarthVader("1").ToLower();       
            

            Assert.Contains(expected, actual);
        }

        [Fact]
        public static void VaderGotAway()
        {
            string expected = "Vader Got Away".ToLower();
            string actual = Challenge.TryToCatchDarthVader("Vader Haters").ToLower();           

            Assert.Contains(expected, actual);
        }
    }
}   