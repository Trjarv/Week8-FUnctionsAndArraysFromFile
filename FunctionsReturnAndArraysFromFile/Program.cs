﻿using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood() 
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");
        }

        private static void DisplayRandomDrink() 
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");
        }

        private static void DisplayRandomMovie() 
        {
            string[] movies = { "Shadow Hunters", "The Rain", "Sweeet Home", "3%", "Cursed", "Death to 2020", "Project Power" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMoovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMoovie}");
        }
    }
}
