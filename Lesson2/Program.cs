namespace Lesson2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pls, enter the Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter your age");
            var age = Console.ReadLine();
            Console.WriteLine("You are " + age + " years old");
            Console.Read();
        }

    }
}