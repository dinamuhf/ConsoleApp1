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


namespace StructExample
{
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this = new Person(); 
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create and populate the array
            Person[] people = new Person[3];
            people[0] = new Person("Alice", 25);
            people[1] = new Person("Bob", 30);
            people[2] = new Person("Charlie", 22);

            // Display the details
            Console.WriteLine("People Information:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            Console.ReadLine(); // Keeps the console window open
        }
    }
}

#endregion