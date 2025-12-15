namespace EventDelegate2
{
    
    public class Task3
    {
        public static void Run()
        {
            int[] numbers = { 7, 14, 21, 3, 5, 28, 30 };

            Func<int[], int, int> countMultiples =
                (array, n) => array.Count(x => x % n == 0);

            Console.WriteLine($"Кратних 7: {countMultiples(numbers, 7)}");
            Console.WriteLine($"Кратних 3: {countMultiples(numbers, 3)}");
            Console.WriteLine($"Кратних 5: {countMultiples(numbers, 5)}");
        }
    }
}