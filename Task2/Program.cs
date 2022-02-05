using System;

namespace Task2
{
    internal struct Train
    {
        private string _destinationPoint, _departureTime;
        private int _number;

        public int Number => _number;
        public Train(string destinationPoint, string departureTime, int number)
        {
            _destinationPoint = destinationPoint;
            _departureTime = departureTime;
            _number = number;
        }

        public override string ToString()
        {
            return $"Train {_number} to {_destinationPoint} leaves at {_departureTime}";
        }
        public static void Sort(Train[] array)
        {
            Train temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].Number > array[j].Number)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] listOfTrains = new Train[2];

            //listOfTrains[0] = new Train("Lvov", "12:02", 2);
            //listOfTrains[1] = new Train("Harkov", "07:05", 34);
            //listOfTrains[2] = new Train("Donetsk", "23:40", 7);
            //listOfTrains[3] = new Train("Kiev", "12:02", 5);
            //listOfTrains[4] = new Train("Dnepr", "07:05", 27);
            //listOfTrains[5] = new Train("Odessa", "23:40", 88);
            //listOfTrains[6] = new Train("Uzgorod", "12:02", 4);
            //listOfTrains[7] = new Train("Vinnitsa", "07:05", 10);

            Console.WriteLine("Enter train info: \"City/number/time(00:00)\"");
            for (int i = 0; i < listOfTrains.Length; i++)
            {
                Console.Write($"Train {i + 1} ");
                string[] inputInfo = Console.ReadLine().Split('/');
                listOfTrains[i] = new Train(inputInfo[0], inputInfo[2], Convert.ToInt32(inputInfo[1]));
            }

            Train.Sort(listOfTrains);
            for (int i = 0; i < listOfTrains.Length; i++)
                Console.WriteLine(listOfTrains[i]);

            Console.WriteLine("Enter train number to find info: ");
            int numberToFind = Convert.ToInt32(Console.ReadLine());
            Train? result = null;
            for (int i = 0; i < listOfTrains.Length; i++)
            {
                if (listOfTrains[i].Number == numberToFind)
                {
                    result = listOfTrains[i];
                    break;
                }
                result = null;
            }
            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine($"Train {numberToFind} not found.");
        }
    }
}
