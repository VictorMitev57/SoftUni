using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<Pump> pumpsQueue = new Queue<Pump>();

            for (int i = 0; i < n - 1; i++)
            {
                string[] data = Console.ReadLine().Split();
                int amount = int.Parse(data[0]);
                int distance = int.Parse(data[1]);

                Pump pump = new Pump(i, amount, distance);
                pumpsQueue.Enqueue(pump);

            }

            int totalDistance = pumpsQueue.Sum(pump => pump.distance);
            int passedDistance = 0;
            int truckFuel = 0;

            while (passedDistance < totalDistance)
            {
                Pump currPump = pumpsQueue.Peek();
                truckFuel += currPump.amount;
                passedDistance += currPump.distance;
                pumpsQueue.Dequeue();

            }
        }
    }

    class Pump 
    {
        public int number;
        public int amount;
        public int distance;

        public Pump(int number, int amount, int distance) 
        {
            this.number = number;
            this.amount = amount;
            this.distance = distance;
        }
    }
}
