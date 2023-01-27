namespace Uppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];

            Console.WriteLine("skriv in tre heltal.");
            tal[0] = int.Parse(Console.ReadLine());
            tal[1] = int.Parse(Console.ReadLine());
            tal[2] = int.Parse(Console.ReadLine());



            Console.WriteLine(" summa av dina tal är " + (tal[0] + tal[1] + tal[2]));






        }
    }

}