using C42_G01_ADV03.Part01;

namespace C42_G01_ADV03
{
    internal class Program
    {

        #region PrintList
        public static void printList<T>(List<T> list)
        {
            Console.Write("Element: {");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}");
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Part01
            //List<Book> books = new List<Book>
            //{
            //    new Book("123", "Ahram", new string[] { "Mohamed" }, new DateTime(2020, 1, 1), 29.99m),
            //};

            //#region A,B

            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooksWithFunc(books, BookFunctions.GetTitle);

            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooksWithFunc(books, BookFunctions.GetAuthors);

            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            //LibraryEngine.ProcessBooksWithFunc(books, BookFunctions.GetPrice);
            //#endregion

            //#region Using anonymous method
            //Console.WriteLine("********************************");
            ////Anonymous Method(GetISBN).
            //LibraryEngine.ProcessBooksWithFunc(books, delegate (Book B) { return B.ISBN; });
            ////Anonymous Method(GetTitle).
            //LibraryEngine.ProcessBooksWithFunc(books, delegate (Book B) { return B.Title; });
            ////Anonymous Method(GetPrice).
            //LibraryEngine.ProcessBooksWithFunc(books, delegate (Book B) { return B.Price.ToString(); });
            ////Anonymous Method(GetPublicationDate).
            //LibraryEngine.ProcessBooksWithFunc(books, delegate (Book B) { return B.PublicationDate.ToString(); });

            //#endregion

            //#region Using lambda expression

            //Console.WriteLine("********************************");

            //LibraryEngine.ProcessBooksWithFunc(books, (Book B) => B.PublicationDate.ToShortDateString());


            //#endregion         
            #endregion

            #region Part02
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            printList<int>(numbers);
            #region Exists
            bool existsGreaterThanFive = numbers.Exists(x => x > 5);
            Console.WriteLine($"Any number greater than 5: {existsGreaterThanFive}");
            #endregion

            #region Find
            int firstOdd = numbers.Find(x => x % 2 == 1);
            Console.WriteLine($"First odd number: {firstOdd}");
            #endregion

            #region FindAll
            var oddNumbers = numbers.FindAll(x => x % 2 == 1);
            printList(oddNumbers);
            var evenNumbers = numbers.FindAll(x => x % 2 == 0);
            printList(evenNumbers);
            #endregion

            #region FindIndex
            int firstEvenIndex = numbers.FindIndex(x => x % 2 == 0);
            Console.WriteLine($"First even index: {firstEvenIndex}");
            #endregion

            #region FindLast
            int lastOdd = numbers.FindLast(x => x % 2 == 1);
            Console.WriteLine($"Last odd number: {lastOdd}");
            #endregion

            #region FindLastIndex
            int lastEvenIndex = numbers.FindLastIndex(x => x % 2 == 0);
            Console.WriteLine($"Last even index: {lastEvenIndex}");
            #endregion

            #region ForEach
            numbers.ForEach(x => Console.WriteLine(x + 10)); //This won't modify the list 
            #endregion

            #region TrueForAll
            bool allGreaterThanFive = numbers.TrueForAll(x => x > 5);
            Console.WriteLine($"All numbers greater than 5: {allGreaterThanFive}");
            #endregion
            #endregion

        }
    }
}
