using System;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorAssignment();
        }

        static void CalculatorAssignment()
        {
         Calculator c = new Calculator();
            Console.WriteLine("Please choose one of the following options by entering the number next to it.");
            bool repeat = true;  

            while(repeat)
            {
            Console.WriteLine("1. Add two numbers\n2. Multiply two numbers\n3. Sum the numbers between two numbers.\n4. Add number to memory\n5. Clear memory\n6. Print calculator contents.\n7. Quit");
            int choice = int.Parse(Console.ReadLine());         
            
            switch(choice)
            {
                case 1:
                    TakeInput(c);
                    Console.WriteLine($"Result: {c.SumNumbers()}");
                    Console.Read();
                    break;
                case 2: 
                    TakeInput(c);
                    Console.WriteLine($"Result: {c.MultiplyNumbers()}");
                    Console.Read();
                    break; 
                case 3: 
                    TakeInput(c);
                    Console.WriteLine($"Result: {c.SumInBetween()}");
                    Console.Read();
                    break; 
                case 4: 
                    Console.WriteLine("Please enter the number you wish to save in memory: ");
                    c.NumberInMemory = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number saved to memory");
                    Console.Read();
                    break; 
                case 5: 
                    c.NumberInMemory = 0; 
                    Console.WriteLine("Memory cleared.");
                    Console.Read();
                    break;
                case 6: 
                    Console.WriteLine(c.ToString());
                    Console.Read();
                    break; 
                case 7: 
                    repeat = false; 
                    break;
            }
            }   
        }
        static void TakeInput(Calculator c)
        {
            Console.WriteLine("Please enter first number: "); 
            c.FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            c.SecondNumber = int.Parse(Console.ReadLine()); 
        }
    }
}
