using System;

namespace AppVeyorDeployTest
{
    class Program
    {
        [STAThread]
        public static int Main()
        {
            var obj = new TestClass();
            Console.WriteLine(obj.GetSomeString());
            Console.ReadLine();
            return 0;
        }
    }
}
