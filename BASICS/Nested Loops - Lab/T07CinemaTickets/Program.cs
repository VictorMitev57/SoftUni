using System;

namespace T07CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double kidCounter = 0;
            double standardCounter = 0;
            double studentCounter = 0;
            double totalTickets = 0;
            double fullness = 0;
            bool flag = false;

            while (movie != "Finish")
            {
                double seats = int.Parse(Console.ReadLine());
                string freeSpace = Console.ReadLine();
                ///////////////////////////////////////
                
                double seatsCounter = 0;
                fullness = 0;
                /////////////////////////////////////
                while (freeSpace != "End")
                {
                    seatsCounter++;
                    totalTickets++;

                    if (freeSpace == "standard")
                    {
                        standardCounter++;
                    }
                    else if (freeSpace == "kid")
                    {
                        kidCounter++;

                    }
                    else if(freeSpace =="student")      
                    {
                        studentCounter++;
                    }
                    if (seats == seatsCounter)
                    {
                        break;
                    }
                    freeSpace = Console.ReadLine();
                }
                fullness = (seatsCounter / seats) *100;
                Console.WriteLine($"{movie} - {fullness:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{((studentCounter / totalTickets) * 100):f2}% student tickets.");    
            Console.WriteLine($"{((standardCounter / totalTickets) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((kidCounter / totalTickets) * 100):f2}% kids tickets.");
        }
    }
}
