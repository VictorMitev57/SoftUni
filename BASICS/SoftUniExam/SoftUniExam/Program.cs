using System;

namespace SoftUniExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollsOfPaper = int.Parse(Console.ReadLine());
            int rollsOfCloth = int.Parse(Console.ReadLine());
            double glueInL = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double paper = 5.80;
            double cloth = 7.20;
            double glue = 1.20;

            double totalPaperPrice = paper * rollsOfPaper;
            double totalClothPrice = rollsOfCloth * cloth;
            double totalGlueInL = glue * glueInL;
            double total = totalClothPrice + totalPaperPrice + totalGlueInL;

            total *= (double)(100 - percent) / 100;
            Console.WriteLine($"{total:f3}");
        }
    }
}
