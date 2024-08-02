using Demo.Classes;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Demo
{
    //You can write inside namespace(Class ,Enum ,Interface ,Delegate) 
    //Step01
    public delegate int StringFuncDelegate(string s);
    //new Delegate 
    //01 --> The  Reference From delegater can refare to function or more [Pointer to functions]
    //
    //     
    //public delegate bool FindDelegate<T>(T Num);
    internal class Program
    {

        #region Print method
        public static void printElementFromArr<T>(T[] Arr)
        {
            Console.Write("Element: {");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"{Arr[i]}");
                if (i < Arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }

        #endregion

        #region Find odd Method
        public static List<T> FindElement<T>(List<T> list,Predicate<T> findNumDel)
        {
            List<T> result=new List<T>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++) {
                    if (findNumDel(list[i]))
                    {
                        result.Add(list[i]);
                    }
                }    
            }
            return result;
        }
        #endregion

        #region PrintList
        public static void printList<T>(List<T> list) {
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
            #region Delegate
            //Delegate :-is a c# language feature
            // Has 2 Usagees:
            //              --> Functional Programing           
            //                  --> 01- Store Func In Variable         
            //                  --> 02- Pass function as a parameter to another function         
            //                  --> 03- Return function threw another function
            //              --> Event - Driven programin.
            //                  --> 1- 
            //              
            #endregion

            #region Delegate Examples

            #region EX01
            ////Step01 --> Declare For refrence from delegate
            //StringFuncDelegate ReferenceDelegate;
            ////Step02 --> Intit Delegate Reference [Pointer]

            ////ReferenceDelegate = new StringFuncDelegate(StringMethods.GetUpperCaseCounter);// --> Old Syntax
            //ReferenceDelegate = StringMethods.GetUpperCaseCounter;// --> Syntax sugar
            ////Step03 --> use delegate refrence 
            ////int Result = ReferenceDelegate.Invoke("Maha Ahmed");// --> Old Syntax
            //int Result = ReferenceDelegate("Maha Ahmed");// --> Syntax sugar
            //Console.WriteLine($"Upper case Counter : {Result}");
            //ReferenceDelegate += StringMethods.GetLowerCaseCounter;// --> Syntax sugar
            //Result = ReferenceDelegate("Maha Ahmed");// --> Syntax sugar
            //Console.WriteLine($"Lower case case Counter : {Result}");
            #endregion

            #region EX02
            //int[] numbres = { 10, 2, 5, 7, 9, 3, 2, 1, 3, 2, 1, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //printElementFromArr (numbres);
            //SortingAlgorithms.BubbleSort(numbres,CompareFunc.CompareGrater );
            //printElementFromArr(numbres);
            //SortingAlgorithms.BubbleSort(numbres,CompareFunc.CompareLess );
            //printElementFromArr(numbres);
            #endregion

            #region EX02 With Genarics
            //int[] numbres = { 10, 2, 5, 7, 9, 3, 2, 1, 3, 2, 1, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //printElementFromArr(numbres);
            //SortingAlgorithms<int>.BubbleSort(numbres, CompareFunc.CompareGreater);
            //printElementFromArr(numbres);
            //SortingAlgorithms<int>.BubbleSort(numbres, CompareFunc.CompareLess);
            //printElementFromArr(numbres);
            //string[] Names = { "Ahmed", "Ali", "Omer", "Riad", "Osama", "Bakr" };
            //printElementFromArr(Names);
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunc.SortAscending);
            //printElementFromArr(Names);
            //SortingAlgorithms<string>.BubbleSort(Names, CompareFunc.SortDescending);
            //printElementFromArr(Names);

            #endregion

            #region EX03[with genaric]
            //List<int> Numbres = new List<int>();
            //Numbres = Enumerable.Range(1, 100).ToList();
            //printList(Numbres);
            //Console.WriteLine("Odd Num");
            //List<int> oddNum = FindElement<int>(Numbres, Conditionfunc.CheckOdd);
            //printList(oddNum);
            //Console.WriteLine("Even Num");
            //List<int> evenNum = FindElement<int>(Numbres, Conditionfunc.CheckEven);
            //printList(evenNum);
            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mai", "Omer", "Farouk", "Hendy", "Hambozo" };
            //List<string> ValuesMore04 = FindElement<string>(Names, Conditionfunc.CheckLength);
            //printList(ValuesMore04);
            #endregion


            #endregion

            #region Build in delegate
            //Predicate-- > take 1 argument and refere to function return bool
            //Func-- > Can refare to take from 1 to 16 parameter from any data type then must return
            //Action-- > [Genaric Version & None Genaric Version]
            //         Genaric Version --> must be void and take from  to 16 parameter from any data typ
            //         Non genaric version --> take 0 parameter and must be void
            #endregion

            #region Examples Of buildin delegate

            #region Predicate
            ////Predicate<int> predicate; //Reference refare to function take one argument and return bool
            //Predicate<int> predicate=Conditionfunc.Test;
            //Console.WriteLine(predicate.Invoke(0)); 
            #endregion

            #region func
            ////Func<int,string> func;// reference refare to function take one argument and return string
            //Func<int, string> func=Conditionfunc.cast;
            //Console.WriteLine( func(1) ); 
            #endregion

            #region Action

            #region Non Genaric action
            ////Action action;//Reference refare to function not take any argument and not return 
            //Action action = Conditionfunc.print;
            //action.Invoke(); 
            #endregion

            #region Genaric action
            ////Action<string> action;//reference refare to function take one argument and not return 
            //Action<string> action=Conditionfunc.printName;
            //action.Invoke("Ahemd");
            #endregion
            #endregion

            #endregion

            #region Annonymous method

            #region Predicate
            //Predicate<int> predicate = delegate (int numbre) { return numbre > 0; };
            //Console.WriteLine(predicate.Invoke(5)); 
            #endregion

            #region Func
            //Func<int,string> func=delegate(int i) {return i.ToString();};
            //Console.WriteLine(func.Invoke(5));
            #endregion

            #region Action

            #region Non Genaric
            //Action action = delegate ()
            //    {
            //        Console.WriteLine("Hellow");
            //    };
            //action.Invoke(); 
            #endregion

            #region  Genaric
            //Action<string> action = delegate (string name) { Console.WriteLine($"Hellow {name}."); };
            //action.Invoke("Ali");
            #endregion
            #endregion
            #endregion

            #region Lambada Exprossion C#9
            #region Predicate 
            //Predicate<int> predicate = (num) => num > 0;
            //Console.WriteLine(predicate.Invoke(4));
            #endregion

            #region Func
            //Func<int,string> func=(num)=>num.ToString();
            //Console.WriteLine(func.Invoke(5));
            #endregion

            #region Action
            #region Non genaric
            //Action action = () => Console.WriteLine("Hellow");
            //action.Invoke();    
            #endregion

            #region Genaric
            //Action<string> action=(name)=>Console.WriteLine(name);
            //action.Invoke("Ahmed");
            #endregion
            #endregion

            #endregion

            #region New Feature in delegate at C#10
            ////var
            //var name = "ahmed";
            ////name = 10;//-xx->not correct
            //var predicate = (int num) => num > 0;

            #endregion

            #region Method in list
            //List<int> Numbres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //printList<int>(Numbres);
            #region 01 Findall
            //List<int> OddNum = Numbres.FindAll(x => x % 2 != 1);
            //printList<int>(OddNum);
            //List<int> EvenNum = Numbres.FindAll(x => x % 2 == 1);
            //printList<int>(EvenNum); 
            #endregion

            #region 02 find
            //int FristOdd = Numbres.Find(x => x % 2 != 1);
            //Console.WriteLine(FristOdd);
            //int FristEven = Numbres.Find(x => x % 2 == 1);
            //Console.WriteLine(FristEven);
            #endregion

            #region Findlast
            //int LastOdd = Numbres.FindLast(x => x % 2 != 1);
            //Console.WriteLine(LastOdd);
            //int LastEven = Numbres.FindLast(x => x % 2 == 1);
            //Console.WriteLine(LastEven);
            #endregion

            #region Exist
            //Console.WriteLine(Numbres.Exists(x => x > 5));
            #endregion

            #region TrueForAll
            //Console.WriteLine(Numbres.TrueForAll(x => x > 5));
            #endregion

            #region ForEach
            //Numbres.ForEach(x => x += 10);
            //printList<int>(Numbres);
            #endregion

            #region RemoveAll
            //Numbres.RemoveAll(x => x > 5);
            //printList<int>(Numbres);
            #endregion

            #endregion

        }
    }
}