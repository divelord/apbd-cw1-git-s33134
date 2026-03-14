namespace cwiczenia2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczby: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Brak danych");
            return;
        }
        
        string[] numbers = input.Split(' ');
    }
}