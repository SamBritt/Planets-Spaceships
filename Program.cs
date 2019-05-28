using System;
using System.Collections.Generic;

namespace planetsAndSpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // foreach (string planet in planetList)
            // {
            //     Console.WriteLine($"Planet: {planet}");
            // }
            
            List<string> finalPlanets = new List<string>() { "Neptune", "Pluto" };
            planetList.AddRange(finalPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Insert(6, "Uranus");
            //S**t! Pluto apparently isn't a planet anymore!
            planetList.Remove("Pluto");
            foreach (string planet in planetList)
            {
                Console.WriteLine($"Planet: {planet}");
            }
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            foreach(string rockyPlanet in rockyPlanets){
                Console.WriteLine($"Rocky Planet: {rockyPlanet}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
