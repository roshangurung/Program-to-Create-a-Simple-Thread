using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
class program///This C# Program, we are creating a new ThreadStart delegate. The delegate points to a method that will be executed by the new thread. Pass this delegate as a parameter when creating a new Thread instance. Finally, call the Thread.Start method to run the method.//
{
    public void WorkThreadFunction()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Simple Thread");
        }
    }
}
class threprog
{
    public static void Main()
    {
        program pg = new program();
        Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));
        thread.Start();
        Console.Read();
    }
}
///Output:Simple Thread
//Simple Thread
//Simple Thread
//Simple Thread
//Simple Thread