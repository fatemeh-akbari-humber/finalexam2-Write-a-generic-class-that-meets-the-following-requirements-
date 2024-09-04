namespace finalexam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ValueType<int> collection = new ValueType<int>();

          
            collection.AddItem(11);
            collection.AddItem(5);
            collection.AddItem(25);

            
            Console.WriteLine("Item at index 1: " + collection.GetItem(1));

            var sortedItems = collection.GetSortedDescending();
            Console.WriteLine("Sorted items in descending order: " + string.Join(", ", sortedItems));
        }
    }
}








