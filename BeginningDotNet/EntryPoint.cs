    using System;
    using System.Threading;

    class EntryPoint
    {
        static void Main()
        {
            Console.WriteLine("Hello World");
            //cw + tab + tab
            Console.WriteLine("New One");

            //Console Readline for String
            String Name;
            
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();

            //Console Readline for Int
            int Age;
            Console.Write("Please enter your age: ");
            Age = int.Parse(Console.ReadLine());


            //While loop to check Salary if less than 3K
            double Salary = 0;
            while(Salary<3000)
            {
                Console.Write("Please enter Salary greater than 3K: ");
                Salary = double.Parse(Console.ReadLine());
            }

        Console.WriteLine("Thank you for entering your Salary");
        }
    }

