using System;
using myApp.Sample;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> s = (int x) =>
                {
                    Console.WriteLine("ints[x] = " + x);
                    return x;
                };
            Console.WriteLine(s(200));
            Hey hlp = new Hey("Test");
            Console.WriteLine(hlp.getName() + " this!");
            Console.WriteLine(Another.getNumber());
            int[] ints = { 1, 2, 3, 4, 5 };
            foreach (int x in ints)
            {
                Console.WriteLine("ints[x] = " + x);
            }
            Console.WriteLine("\n********\n");

            Another a = new Another();
            a.addToList("hey");
            a.addToList("hey2");
            foreach (var x in a.GetList())
                Console.WriteLine(x);
            a.addToDict("KEY", "VALUE");
            a.addToDict("KEY2", "VALUE2");
            foreach (var x in a.getDict())
            {
                Console.WriteLine(x);
            }

            DateTime date = new DateTime();
            Console.WriteLine(date.ToString());

        }

        static public string randomMethod()
        {
            return "Random Method";
        }
        static public string randomMethod(string str)
        {
            return "Random Method Overloaded with " + str;
        }
    }
}
