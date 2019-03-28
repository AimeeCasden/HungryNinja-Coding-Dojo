using System;
using System.Collections.Generic;

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>

<body>
<h3>Here are some delicious food:</h3>
    @{
    string[] Food = new string { "Apple Pie", "Burrito", "Clams Chowder", "Donuts" };
    for (int idx = 0; idx < Food.Length; idx++) 
    { 
        <p>@Food[idx]</p> 
    }
    }
</body> 
</html>













namespace HungryNinja
{

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        // food constructor that takes in all four parameters: name, calories, whether or not the food is spicy or sweet
        public Food(string name, int calories, bool isspicy, bool issweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isspicy;
            IsSweet = issweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;

        // buffet constructor that produces a list of food
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food ("Shakshouka", 500, true, false),
                new Food ("Falafel", 57, false, false),
                new Food ("Chicken Shawarma", 500, false, false),
                new Food ("Baklava", 230, false, true),
                new Food ("Hummus", 160, true, false),
                new Food ("Cheese Bourekas", 420, false, false),
                new Food ("Marble Halvah", 200, false, true),
            };
        }
        public Food Serve()
        {
            // Serve method randomly selects a food object from the Menu list and returns a random Food object

            Random rand = new Random();
            rand.Next(0, Menu.Count);
            return Menu[rand.Next(0, Menu.Count)];
        }
    }

    class Ninja
        {
        private int calorieIntake;
         public List<Food> FoodHistory;

        // add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory

            public Ninja()
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
                {

                };
            }
            // Add public getter to IsFull property that returns a BOOLEAN if the Ninja has eaten more than 1200 calories.
            public bool IsFull
            {
                get
                {
                    // is the calorie intake greater than 1200? If so, its true, if not, it skips entire if statement and returns false.
                    if (calorieIntake > 1200)
                    {
                        return true;
                    }
                    return false;
                }
            }

            // build out the Eat method that: if the Ninja is NOT full
            // adds calorie value to ninja's total calorieIntake
            // adds the randomly selected Food object to ninja's FoodHistory list
            // writes the Food's Name - and if it is spicy/sweet to the console
            public void Eat(Food item)
            {
                if (IsFull == false)
                {
                    calorieIntake += item.Calories;
                    FoodHistory.Add(item);
                    Console.WriteLine(item.Name);

                }
                else{
                    Console.WriteLine("Ninja is too full to eat more!");
                }
            }
        }






    class Program
    {
        static void Main(string[] args)
        {
            // create a Ninja object below
            // this is now an object
            Ninja myNinja = new Ninja();
            

            // buffet object must be createed in order to run

            Buffet myBuffet = new Buffet();

            // calls a method within Buffet
            // Serve() returns a food object

            myBuffet.Serve();


            // Ninja will eat and it will eat a random item that myBuffet.Serve returns (which is one random item) then when the Ninja exceeds 1200 calories, a string appears that says the Ninja is too full to eat.

            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());
            myNinja.Eat(myBuffet.Serve());

            




        }
    }

}