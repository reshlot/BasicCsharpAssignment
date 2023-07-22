using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Task-1
            //To Print hello world
            Console.WriteLine("Hello, World!");
            Console.ReadKey();



            //Task-2
            // Ask the user for their name
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            // Print a personalized greeting message
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadKey();



            //Task-3
            //Basic Arithmetic

            // Ask the user for 2 value
            Console.WriteLine("Enter a value:");
            int a = Convert.ToInt32(Console.ReadLine());
          

            
            Console.WriteLine("Enter b value:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Addition
            int sum = a + b;
            Console.WriteLine("Addition: " + sum);

            // Subtraction
            int difference = a- b;
            Console.WriteLine("Subtraction: " + difference);

            // Multiplication
            int product = a * b;
            Console.WriteLine("Multiplication: " + product);

            // Division
            if (b != 0)
            {
                int quotient = a / b;
                Console.WriteLine("Division: " + quotient);
            }
            else
            {
                Console.WriteLine("0");
            }

            // Modulus
            if (b != 0)
            {
                int remainder = a% b;
                Console.WriteLine("Modulus: " + remainder);
            }
            else
            {
                Console.WriteLine("zero is not allowed.");
            }
            Console.ReadKey();




            //Task-4
            //Ask User  to enter integer
            Console.WriteLine("Enter c value:");
            int c = Convert.ToInt32(Console.ReadLine());

            if(c%2==0)
            {
                Console.WriteLine("Given number is even....");
            }
            else
            {
                Console.WriteLine("Given number is odd.....");
            }
            Console.ReadKey();



            //Task-5
            Console.WriteLine("Print the numbers from1 to 10:");
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();



            //Task-6
            
            int[] number = { 10, 12, 14, 16, 18 };
            int d = 0;
            foreach (int num in number)
            {
                d += num;
            }

            // Calculate the average of the elements in the array
            double average = (double)d / number.Length;

            // Display the sum and average on the console
            Console.WriteLine("Sum: " + d);
            Console.WriteLine("Average: " + average);
            Console.ReadKey();

            


            //Task-7


            Console.Write("Enter a positive integer: ");
            int integer = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(integer);

            Console.WriteLine("The factorial of {0} is {1}", integer, factorial);

            Console.ReadKey();

            //method
             long CalculateFactorial(int num)
            {
                if (num == 0)
                {
                    return 1;
                }
                else
                {
                    return num * CalculateFactorial(num - 1);
                }
              }  
            



            //Task-8

            int age;

            while (true)
            {
                Console.Write("Enter your age:\n ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                    Console.WriteLine(" Please! enter correct age\n");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
           
            Console.ReadKey();
            Console.WriteLine("Thank You!!!!!!!!!!!!!!!!!");
            Console.ReadKey();
        }
    }
    
}
