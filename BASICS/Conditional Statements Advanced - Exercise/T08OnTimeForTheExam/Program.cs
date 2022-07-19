using System;

namespace T08OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourHeCamed = int.Parse(Console.ReadLine());
            int minHeCamed = int.Parse(Console.ReadLine());
            int hourCounter = 0;
            int minCounter = 0;
            if (hourExam == hourHeCamed && minExam == minHeCamed)
            {
                Console.WriteLine("On time");
            }
            ////////////////////////////////////////////////////////
            else if (hourExam == hourHeCamed && minHeCamed != minExam)
            {
                if (minExam > minHeCamed)
                {
                    if ((minExam - minHeCamed) <= 30)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{(minExam - minHeCamed):d2} minutes before the start");
                    }
                    else if (minExam - minHeCamed > 30)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{(minExam - minHeCamed):d2} minutes before the start");
                    }

                }
                else if (minExam < minHeCamed)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{(minHeCamed - minExam):d2} minutes after the start");
                }
            }
            ////////////////////////////////////////////////////
            else if (hourExam != hourHeCamed && minHeCamed == minExam)
            {
                if (hourExam > hourHeCamed)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hourExam - hourHeCamed}:{minExam:d2} hours before the start");
                }
                else if (hourExam < hourHeCamed)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hourHeCamed - hourExam}:{minExam:d2} hours after the start");
                }
            }
            //////////////////////////////////////////////////////////////
            else if (hourExam != hourHeCamed && minHeCamed != minExam)
            {
                if (hourExam > hourHeCamed)            /*10 > 9*/ /*30 50*/ /* 10.30 - 9.50*/                /*10  50*/  /*10  30*/
                {                                       /*10 > 9*/ /*50 30*/ /* 10.50 - 9.30*/               /*9  30*/   /*9   50*/
                    hourCounter++;
                    if (hourExam - hourCounter > 1)
                    {
                        hourCounter = hourExam - hourHeCamed;
                    }
                    else if (hourHeCamed - hourExam > 1)
                    {
                        hourCounter = hourHeCamed - hourExam;
                    }
                    if (minExam > minHeCamed)
                    {
                        Console.WriteLine("Early");//////////////////////////////////////////////////////////
                        Console.WriteLine($"{hourCounter}:{(minExam - minHeCamed):d2} hours before the start");
                    }
                    else if (minHeCamed > minExam)
                    {
                        if (minExam == 00)
                        {
                            Console.WriteLine("On time");
                            Console.WriteLine($"{(60 - minHeCamed)} minutes before the start");
                        }
                        else if (minHeCamed - minExam > 50 && minHeCamed - minExam <= 59)
                        {
                            Console.WriteLine("On time");
                            Console.WriteLine($"{(minHeCamed - minExam - 50)} minutes before the start");
                        }
                        else if (minHeCamed - minExam <= 30)
                        {
                            int condition = 60 - (minHeCamed - minExam);
                            if (condition > 30)
                            {
                                minCounter = 60 - Math.Abs(minHeCamed - minExam);
                                Console.WriteLine("Early");
                                Console.WriteLine($"{(minCounter):d2} minutes before the start");
                            }
                            else if (condition <= 30)
                            {
                                minCounter = 60 - Math.Abs(minHeCamed - minExam);
                                Console.WriteLine("On time");
                                Console.WriteLine($"{(minCounter):d2} minutes before the start");
                            }
                        }
                        else if (minHeCamed - minExam > 30)
                        {
                            int condition = 60 - minHeCamed - minExam;
                            if (condition <= 30)
                            {
                                minCounter = 60 - (minHeCamed - minExam);
                                Console.WriteLine("On time");
                                Console.WriteLine($"{(minCounter):d2} minutes before the start");
                            }
                            else if (condition > 30)
                            {
                                minCounter = 60 - (minHeCamed - minExam);
                                Console.WriteLine("Early");
                                Console.WriteLine($"{(minCounter):d2} minutes before the start");
                            }
                        }
                    }

                }
                else if (hourExam < hourHeCamed)                                 /* 11 // 12*/
                {
                    if (minExam > minHeCamed)
                    {
                        Console.WriteLine("Late");
                        minCounter = 60 - (minExam - minHeCamed);
                        Console.WriteLine($"{(minCounter):d2} minutes after the start");
                    }
                    else if (minHeCamed > minExam)
                    {
                        hourCounter++;
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hourCounter}:{(minHeCamed - minExam):d2} hours after the start");
                    }
                }
            }
        }
    }
}
