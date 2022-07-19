using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meals = Console.ReadLine().Split();
            int[] caloriesPerDay = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> calories = new Stack<int>();
            Queue<string> mealsEaten = new Queue<string>();

            foreach (var meal in meals)
            {
                mealsEaten.Enqueue(meal);
            }

            foreach (var cal in caloriesPerDay)
            {
                calories.Push(cal);
            }

            int currMeal = 0;
            int removedCal = 0;
            while (mealsEaten.Count > 0)
            {

                if (mealsEaten.Peek() == "salad")
                {
                    int saladCal = 350;
                    currMeal = calories.Peek();
                    calories.Pop();
                    currMeal -= saladCal;
                    if (currMeal == 0)
                    {
                        currMeal = 0;
                    }
                    else if (currMeal < 0)
                    {
                        Math.Abs();
                        removedCal = saladCal - currMeal;
                        currMeal = 0;
                        currMeal = calories.Peek();
                        currMeal -= removedCal;
                    }
                    calories.Push(currMeal);
                    mealsEaten.Dequeue();

                }
                else if (mealsEaten.Peek() == "soup")
                {
                    int soupCal = 490;
                }
                else if (mealsEaten.Peek() == "pasta")
                {
                    int pastaCal = 680;
                }
                else if (mealsEaten.Peek() == "steak")
                {
                    int steakCal = 790;
                }
            }
        }
    }
}
