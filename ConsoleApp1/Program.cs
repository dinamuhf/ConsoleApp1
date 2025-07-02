//#region 1
//namespace EnumExample
//{
//    class Program
//    {
//        enum WeekDays
//        {
//            Monday,
//            Tuesday,
//            Wednesday,
//            Thursday,
//            Friday,
//            Saturday,
//            Sunday
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Days of the Week:");
//            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
//            {
//                Console.WriteLine(day);
//            }
//            Console.ReadLine();
//        }
//    }
//}
//#endregion 

#region 2


//namespace StructExample
//{
//    struct Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Person(string name, int age)
//        {
//            this = new Person(); 
//            Name = name;
//            Age = age;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create and populate the array
//            Person[] people = new Person[3];
//            people[0] = new Person("Alice", 25);
//            people[1] = new Person("Bob", 30);
//            people[2] = new Person("Charlie", 22);

//            // Display the details
//            Console.WriteLine("People Information:");
//            foreach (Person person in people)
//            {
//                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//            }

//            Console.ReadLine(); // Keeps the console window open
//        }
//    }
//}

#endregion

//#region 3


//namespace SeasonExample
//{
//    enum Season
//    {
//        Spring,
//        Summer,
//        Autumn,
//        Winter
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
//            string input = Console.ReadLine();

//            // Try to parse input to enum (case-insensitive)
//            if (Enum.TryParse(input, true, out Season selectedSeason))
//            {
//                // Step 2: Display month range based on season
//                switch (selectedSeason)
//                {
//                    case Season.Spring:
//                        Console.WriteLine("Spring: March to May");
//                        break;
//                    case Season.Summer:
//                        Console.WriteLine("Summer: June to August");
//                        break;
//                    case Season.Autumn:
//                        Console.WriteLine("Autumn: September to November");
//                        break;
//                    case Season.Winter:
//                        Console.WriteLine("Winter: December to February");
//                        break;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid season name. Please enter one of: Spring, Summer, Autumn, Winter.");
//            }

//            Console.ReadLine();
//        }
//    }
//}
//#endregion

#region 4

namespace ColorCheck
{
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a color name:");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Colors selectedColor))
            {
                Console.WriteLine($"{selectedColor} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a primary color.");
            }

            Console.ReadLine(); 
        }
    }
}
#endregion