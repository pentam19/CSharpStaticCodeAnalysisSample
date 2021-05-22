using System;
namespace SomeConsoleApplication
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public void ArgTest(string str)
        {
            Console.WriteLine(str.Length);
        }

        public string GetTest(bool flg)
        {
            if (flg)
            {
                return "bbbbb";
            }
            else
            {
                return null;
            }
        }
    }
}
