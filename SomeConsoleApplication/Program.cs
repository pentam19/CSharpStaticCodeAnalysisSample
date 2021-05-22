using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            var iAmTrue = true;
            if (iAmTrue)
            {
                // Test1
                Console.WriteLine("Call MyClass.ArgTest()");
                //myClass.ArgTest("aaaaa");
                myClass.ArgTest(null);

                // Test2
                Console.WriteLine("Call MyClass.GetTest()");
                //string str = myClass.GetTest(true);
                string str = myClass.GetTest(false);
                Console.WriteLine(str.Length);

                //
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }

        public static bool AlwaysReturnsTrue()
        {
            return true;
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
