namespace EventDelegate2
{
    public class Task2
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public int Volume { get; set; }

        private List<string> items = new List<string>();

        // Події
        public event Action<string> ItemAdded;
        public event Action<string> ItemRemoved;
        public event Action<string> ItemChanged;

        public Task2(string color, string brand, string fabric,
                        double weight, int volume)
        {
            Color = color;
            Brand = brand;
            Fabric = fabric;
            Weight = weight;
            Volume = volume;
        }

        public void AddItem(string item)
        {
            if (items.Count >= Volume)
                throw new Exception("Перевищено обсяг рюкзака!");

            items.Add(item);
            ItemAdded?.Invoke(item);
        }

        public void RemoveItem(string item)
        {
            if (items.Remove(item))
                ItemRemoved?.Invoke(item);
        }

        public void ChangeItem(string oldItem, string newItem)
        {
            int index = items.IndexOf(oldItem);
            if (index == -1)
                return;

            items[index] = newItem;
            ItemChanged?.Invoke(newItem);
        }
    }
}