using System;

namespace T11FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;
            double price = 0;
            if (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":                            //2.50    1.20    0.85    1.45    2.70    5.50    3.85  banana	apple	orange	grapefruit	kiwi	pineapple	grapes                                               
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        banana = 2.50;
                        apple = 1.20;
                        orange = 0.85;
                        grapefruit = 1.45;
                        kiwi = 2.70;
                        pineapple = 5.50;
                        grapes = 3.85;

                        if (fruit == "banana")
                        {
                            price = banana * quantity;
                        }
                        if (fruit == "apple")
                        {
                            price = apple * quantity;
                        }
                        if (fruit == "orange")
                        {
                            price = orange * quantity;
                        }
                        if (fruit == "grapefruit")
                        {
                            price = grapefruit * quantity;
                        }
                        if (fruit == "kiwi")
                        {
                            price = kiwi * quantity;
                        }
                        if (fruit == "pineapple")
                        {
                            price = pineapple * quantity;
                        }
                        if (fruit == "grapes")
                        {
                            price = grapes * quantity;
                        }
                        break;
                    case "Saturday":                          //2.70    1.25    0.90    1.60    3.00    5.60    4.20 
                    case "Sunday":
                        banana = 2.70;
                        apple = 1.25;
                        orange = 0.90;
                        grapefruit = 1.60;
                        kiwi = 3.00;
                        pineapple = 5.60;
                        grapes = 4.20;

                        if (fruit == "banana")
                        {
                            price = banana * quantity;
                        }
                        if (fruit == "apple")
                        {
                            price = apple * quantity;
                        }
                        if (fruit == "orange")
                        {
                            price = orange * quantity;
                        }
                        if (fruit == "grapefruit")
                        {
                            price = grapefruit * quantity;
                        }
                        if (fruit == "kiwi")
                        {
                            price = kiwi * quantity;
                        }
                        if (fruit == "pineapple")
                        {
                            price = pineapple * quantity;
                        }
                        if (fruit == "grapes")
                        {
                            price = grapes * quantity;
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
                if (price > 0.00)
                {
                    Console.WriteLine($"{price:F2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}


