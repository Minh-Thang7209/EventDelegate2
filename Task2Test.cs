namespace EventDelegate2
{
    public class Task2Test
    {
        public static void Run()
        {
            Task2 backpack = new Task2("Чорний", "Nike", "Нейлон", 1.2, 2);

            backpack.ItemAdded += delegate (string item)
            {
                Console.WriteLine($"Додано предмет: {item}");
            };

            backpack.ItemRemoved += delegate (string item)
            {
                Console.WriteLine($"Видалено предмет: {item}");
            };

            backpack.ItemChanged += delegate (string item)
            {
                Console.WriteLine($"Змінено предмет на: {item}");
            };

            try
            {
                backpack.AddItem("Книга");
                backpack.AddItem("Пляшка");
                backpack.AddItem("Ноутбук"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            backpack.ChangeItem("Книга", "Зошит");
            backpack.RemoveItem("Пляшка");
        }
    }
}