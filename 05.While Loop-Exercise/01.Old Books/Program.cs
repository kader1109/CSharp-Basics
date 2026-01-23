namespace _01.Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string searchedBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int checkedBooks = 0;

            while (currentBook != searchedBook)
            {
                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    return;
                }


                checkedBooks++;
                currentBook = Console.ReadLine();
            }
            Console.WriteLine($"You checked {checkedBooks} books and found it.");


        }
    }
}
