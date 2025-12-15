namespace EventDelegate2
{
    public class Task1
    {
        public static void Run()
        {
            Func<string, (int R, int G, int B)> getRGB = delegate (string color)
            {
                return color.ToLower() switch
                {
                    "червоний" => (255, 0, 0),
                    "помаранчевий" => (255, 165, 0),
                    "жовтий" => (255, 255, 0),
                    "зелений" => (0, 255, 0),
                    "блакитний" => (0, 191, 255),
                    "синій" => (0, 0, 255),
                    "фіолетовий" => (138, 43, 226),
                    _ => throw new ArgumentException("Невідомий колір")
                };
            };

            var rgb = getRGB("зелений");
            Console.WriteLine($"RGB зеленого: {rgb.R}, {rgb.G}, {rgb.B}");
        }
    }
}