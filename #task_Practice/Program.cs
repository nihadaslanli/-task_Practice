namespace _task_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Selsi derec = new(0);
            Kelvin tempratur = derec;
            Console.WriteLine(tempratur.temp);
        }
    }
}
//0 kelvin = -273 selsi