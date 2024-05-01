namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void FunSies()
        {
            Console.WriteLine("Who is your favorite person?");
            string yourPerson = Console.ReadLine();
            Console.WriteLine($"Great! What is your favorite person's favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is their favorite food?");
            string favFood = Console.ReadLine();
            Console.WriteLine("What is their best quality?");
            string favQual = Console.ReadLine();

            Console.WriteLine($"Yesterday, I ran into {yourPerson} and they were wearing a hideous {favColor} shirt. The gorss thing is that it was covered in {favFood}. Although {favQual}, they still smelled like {favFood}");
;        }


    }
}
