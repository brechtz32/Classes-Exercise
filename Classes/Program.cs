namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Malibu";
            myCar.Year = 2022;

            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model}, and it's year is a {myCar.Year}.");
        }
    }
}
