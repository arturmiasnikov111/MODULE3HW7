using System;
using MODULE3HW7.task1;
using System.Threading.Tasks;

namespace MODULE3HW7
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var task1 = new task1.task1();
            task1.Run();

            var task2 = new task2.task2();
            task2.Run();

        }
    }
}