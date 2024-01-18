using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}. What is your favorite animal?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine($"{favAnimal}? Interesting choice. What about your favorite color? What might that be?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color! Do you happen to have a favorite artist or band?");
            var band = Console.ReadLine();

            Console.WriteLine(Sum(3, 3));
            Console.WriteLine(Multiply(5, 6, 3));
        }

        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
    }
}
