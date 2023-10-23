namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_ = new Task1_1();
            //_ = new Task1_2();
            _ = new Task1_3();

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
}