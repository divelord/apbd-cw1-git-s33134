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
        
        string[] inputs = input.Split(" ");
        
        int[] numbers = new int[inputs.Length];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputs[i]);
        }
    }
}