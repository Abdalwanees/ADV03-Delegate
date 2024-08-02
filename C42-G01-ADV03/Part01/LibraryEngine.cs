using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV03.Part01
{
    // User-defined delegate
    public delegate string BookFunctionDelegate(Book B);
    public class LibraryEngine
    {


        #region Using the user-defined delegate
        public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        #endregion

        #region Using the built-in delegate
        public static void ProcessBooksWithFunc(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        } 
        #endregion
    }
}
