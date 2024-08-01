namespace ListCrud
{
    public class Program
    {
        public static List<int> AddInteger(List<int> ints)
        {
            Console.WriteLine("Enter the Integer to be added");
            int userInput = int.Parse(Console.ReadLine());
            ints.Add(userInput);
            return ints;
        }
        public static void DisplayAtIndex(List<int> ints)
        {
            Console.WriteLine("Enter the Index to be Displayes");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(ints[userInput]);
        }
        public static void DisplayAll(List<int> ints)
        {
            foreach (int i in ints) { Console.Write($"{i} "); }
            Console.WriteLine();
        }

        public static List<int> Update(List<int> ints)
        {
            Console.WriteLine("Enter the Index to be Updates");
            int userInputIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the updated Value");
            int userInputUpdate = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Update");
            DisplayAll(ints);
            ints[userInputIndex] = userInputUpdate;
            Console.WriteLine("After Update");
            DisplayAll(ints);
            return ints;
        }

        public static List<int> RemoveAtindex(List<int> ints)
        {
            Console.WriteLine("Enter the Index to be Removed");
            int userInputIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Remove");
            DisplayAll(ints);
            ints.RemoveAt(userInputIndex);
            Console.WriteLine("After Remove");
            DisplayAll(ints);
            return ints;
        }

        public static List<int> RemoveAll(List<int> ints)
        {

            ints.Clear();
            Console.WriteLine("Removed all elements");

            return ints;
        }



        public static void CrudOptions(List<int> ints)
        {
            int userInput = -1;
            while (userInput != 0)
            {
                Console.WriteLine("1. Add Interger" +
                    "\n2. Diplay at Index" +
                    "\n3. Display All" +
                    "\n4. Update Integer" +
                    "\n5. Remove at index" +
                    "\n6. Remove All" +
                    "\n0. Exit");
                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1: ints = AddInteger(ints);break;
                    case 2: DisplayAtIndex(ints);break;
                    case 3: DisplayAll(ints);break;
                    case 4: ints = Update(ints); break;
                    case 5: ints = RemoveAtindex(ints);break;
                    case 6: ints = RemoveAll(ints);break;

                }
            }
        }
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(1); intList.Add(4); intList.Add(8); intList.Add(11); intList.Add(15);
            CrudOptions(intList);
        }
    }
}