namespace eletkor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. feladat megoldása:");

            for (int age = 10; age <= 99; age++)
            {
                int tizes = age / 10;
                int egyes = age % 10;

                int swapped = egyes * 10 + tizes;

                if (swapped == 2 * (age + 1))
                {
                    Console.WriteLine($"A testvér mostani életkora: {age} év");
                }
            }

            Console.WriteLine();


            Console.WriteLine("2. feladat: (Ha felcserélném anyukám jelenlegi életkorának (két számjegyű életkor) számjegyeit, akkor három évvel ezelőtti korának háromszorosát kapnám. Hány éves lehet most?) megoldása:");

            for (int age = 10; age <= 99; age++)
            {
                int tizes = age / 10;
                int egyes = age % 10;

                int swapped = egyes * 10 + tizes;

                if (swapped == 3 * (age - 3))
                {
                    Console.WriteLine($"Anyukám mostani életkora: {age} év");
                }
            }

            Console.WriteLine();
            Console.WriteLine("A megoldások keresése befejeződött. Nyomj egy Entert a kilépéshez.");
            Console.ReadLine();
        }
    }
}
