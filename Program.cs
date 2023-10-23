namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_ = new Task1_1();
            //_ = new Task1_2();
            //_ = new Task1_3();

            //_ = new Task2_1();
            //_ = new Task2_2();
            _ = new Task2_3();

            Console.ReadKey();
        }
    }

    class Task1_1
    {
        public Task1_1()
        {
            Start();
        }

        static private void Start()
        {
            Console.Write("Write a color: ");
            string color = Console.ReadLine().ToLower();

            if (color == "yellow")
            {
                Console.WriteLine("Banana");
            } else if (color == "red")
            {
                Console.WriteLine("Apple");
            } else if (color == "orange")
            {
                Console.WriteLine("Orange");
            } else
            {
                Console.WriteLine("Unknown fruit");
            }
        }
    }

    class Task1_2
    {
        public Task1_2()
        {
            Start();
        }

        private static void Start()
        {
            char choice = ' ';
            float value = 0;

            Console.WriteLine("What do you want to convert?" +
                "\n1 = inches to centimeters" +
                "\n2 = centimeters to inches");

            while (choice != '1' || choice != '2')
            {
                choice = Console.ReadKey().KeyChar;


                if (choice == '1' || choice == '2') break;

                Console.WriteLine("\nNot a valid value. Please select 1 or 2...");
            }

            Console.Write("\nWrite the value you want converted: ");
            value = float.Parse(Console.ReadLine());


            if (choice == '1')
            {
                Console.WriteLine($"{value} inches equals {value * 2.54f} centimeters.");
            } else if (choice == '2')
            {
                Console.WriteLine($"{value} centimeters equals {value / 2.54f} inches");
            }
        }
    }

    class Task1_3
    {
        public Task1_3()
        {
            Start();
        }



        private static void Start()
        {
            string[] person = new string[2];
            int[] age = new int[2];

            Console.WriteLine("Write the name of 2 different people." +
                "\nOne at a time, press [Enter] after each name:");

            for (int i = 0; i < person.Length; i++)
            {
                person[i] = Console.ReadLine();
            }

            for (int i = 0; i < person.Length; i++)
            {
                Console.Write($"Write the age of {person[i]}: ");
                age[i] = int.Parse(Console.ReadLine());
            }

            if (age[0] > age[1])
            {
                Console.WriteLine($"{person[0]} ({age[0]}) is older than {person[1]} ({age[1]}).");
            } else if (age[0] < age[1])
            {
                Console.WriteLine($"{person[1]} ({age[1]}) is older than {person[0]} ({age[0]}).");
            } else if (age[0] == age[1])
            {
                Console.WriteLine($"{person[0]} and {person[1]} are of the same age ({age[0]}).");
            }
        }
    }

    class Task2_1
    {
        public Task2_1()
        {
            Start();
        }

        private static void Start()
        {
            int[] numbers = new int[9];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("---Verion 1---");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("---Version 2---");
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

    class Task2_2
    {
        public Task2_2()
        {
            Start();
        }

        private static void Start()
        {
            int[] dice;
            int numberOfDice = 0;

            Console.WriteLine("How many dice would you like to roll?");
            numberOfDice = int.Parse(Console.ReadLine());

            dice = new int[numberOfDice];

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomNumber(1, 6);

                Console.WriteLine($"Dice #{i + 1} is {dice[i]}");
            }

            Console.WriteLine($"The sum of all dice is: {dice.Sum()}");
        }

        private static int randomNumber(int low, int high)
        {
            Random random = new Random();

            return random.Next(low, high + 1);
        }
    }

    class Task2_3
    {
        public Task2_3()
        {
            Start();
        }

        private static void Start()
        {
            List<int> fibbonaciList = new();
            fibbonaciList.Add(0);
            fibbonaciList.Add(1);

            Console.WriteLine("How many numbers of the Fibonacci sequence would you like to calculate?");

            int numberOfValues = int.Parse(Console.ReadLine());

            for (int i = 2; i < numberOfValues; i++)
            {
                fibbonaciList.Add(
                    fibbonaciList[fibbonaciList.Count - 1] +
                    fibbonaciList[fibbonaciList.Count - 2]);
            }

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.WriteLine($"| {fibbonaciList[i]} |");
            }
        }


    }
}