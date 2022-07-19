using System;

namespace T13SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roomForOnePerson = 18;
            const double apartment = 25;
            const double presidentApartment = 35;

            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            double price = 0;
            switch (room)
            {
                case "room for one person":
                    if (days < 10)
                    {
                        price = nights * roomForOnePerson;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = nights * roomForOnePerson;
                    }
                    else
                    {
                        price = nights * roomForOnePerson;
                    }
                    ///////////////////////////////////////////////////
                    if (rating == "positive")
                    {
                        price *= 1.25;
                    }
                    else if (rating == "negative")
                    {
                        price *= 0.90;
                    }
                    break;



                case "apartment":
                    if (days < 10)
                    {
                        price = (nights * apartment) * 0.70;

                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = (nights * apartment) * 0.65;
                    }
                    else
                    {
                        price = (nights * apartment) * 0.50;
                    }
                    /////////////////////////////////////////////////
                    if (rating == "positive")
                    {
                        price *= 1.25;
                    }
                    else if (rating == "negative")
                    {
                        price *= 0.90;
                    }
                    break;




                case "president apartment":
                    if (days < 10)
                    {
                        price = (nights * presidentApartment) * 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = (nights * presidentApartment) * 0.85;

                    }
                    else
                    {
                        price = (nights * presidentApartment) * 0.80;

                    }
                    ////////////////////////////////////////////////////
                    if (rating == "positive")
                    {
                        price *= 1.25;
                    }
                    else if (rating == "negative")
                    {
                        price *= 0.90;
                    }
                    break;


            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
