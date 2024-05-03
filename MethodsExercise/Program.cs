using System;
using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int added = Add(2,4);
            Console.WriteLine(added);

            int subtracted = Subtract(10,3);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(10, 2);
            Console.WriteLine(multiplied);

            int result = Sum(1, 5, 7, 9);
            Console.WriteLine(result);
        }

        public static void Funsies()
        {
            Console.WriteLine("Who is your favorite person?");
            string yourPerson = Console.ReadLine();
            Console.WriteLine($"Great! What is your favorite person's favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is their favorite food?");
            string favFood = Console.ReadLine();
            Console.WriteLine("What is their best quality?");
            string favQual = Console.ReadLine();

            Console.WriteLine($"Yesterday, I ran into {yourPerson} and they were wearing a hideous {favColor} shirt. The gross thing is that it was covered in {favFood}. Although {favQual}, they still smelled like {favFood}");
        }
        
  
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;      
                             
        }

        public static int Subtract(int numOne, int numTwo)

        {
            return numOne - numTwo;

        }
        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;

        }
 
        public static int Sum(params int[] numbers)           
        {
            int Sum = 0;

            foreach(int number in numbers) 
            {
               Sum = Sum + number

;            }

            return Sum;
        }

           
      
         

        
    }
}


    

