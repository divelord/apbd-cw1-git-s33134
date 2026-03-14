namespace cwiczenia2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczby, oddzielone spacja: ");
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
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("[");
            }  
            
            Console.Write(numbers[i]);
            
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write("]");                
            }
        }
    }

    static double CalculateAverage(int[] numbers)
    {
        double sum = 0.0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        
        return sum / numbers.Length;
    }
}