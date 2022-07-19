using System;

namespace T04SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double roomForoneperson = 18;
            double apartment = 25;
            double presidentApartment = 35;

            int nights = days - 1;
            double total = 0;

            switch (room)
            {

                case "room for one person":
                    if (days < 10)
                    {
                        total = nights* roomForoneperson;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = nights * roomForoneperson;
                    }
                    else if (days > 15)
                    {
                        total = nights * roomForoneperson;
                    }
                    break;


                case "apartment":
                    if (days < 10)
                    {
                        total = (nights * apartment) * 0.70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = (nights * apartment) * 0.65;
                    }
                    else if (days > 15)
                    {
                        total = (nights * apartment) * 0.50;
                    }
                    break;


                case "president apartment":
                    if (days < 10)
                    {
                        total = (nights * presidentApartment) * 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = (nights * presidentApartment) * 0.85;

                    }
                    else if (days > 15)
                    {
                        total = (nights * presidentApartment) * 0.80;

                    }
                    break;
            }
            if (rating == "positive")
            {
                total *= 1.25;
            }
            else
            {
                total *= 0.90;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
