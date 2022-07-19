using System;

namespace T._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string commands = Console.ReadLine();
            ////Th1s 1s my str1ng!//
            //Change 1 i
            //Includes string
            //End my
            //Uppercase
            //FindIndex I
            //Cut 5 5
            //Done

            while (commands != "Done")
            {
                string[] currCommand = commands.Split();
                if (currCommand[0] == "Change")
                {
                    string character = currCommand[1].ToString();
                    string replacement = currCommand[2].ToString();

                   input = input.Replace(character, replacement);
                   Console.WriteLine(input);
                }
                else if (currCommand[0] == "Includes")
                {
                    string includes = currCommand[1];
                    if (input.Contains(includes))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (currCommand[0] == "End")
                {
                    string end = currCommand[1];
                    if (input.EndsWith(end))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (currCommand[0] == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (currCommand[0] == "FindIndex")
                {
                    string character = currCommand[1];
                    int index = input.IndexOf(character); 
                    Console.WriteLine(index);

                }
                else if (currCommand[0] == "Cut")
                {    
                    int startIndex = int.Parse(currCommand[1]);           //Ftu   3 7 
                    int count = int.Parse(currCommand[2]);                //FTUNI I
                    input = input.Remove(0, startIndex);     //*S0FTUNI IS THE B3ST PLAC3**
                    input = input.Remove(count);
                    Console.WriteLine(input);
                }

                commands = Console.ReadLine();
            }
        }
    }
}
