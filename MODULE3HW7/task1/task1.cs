using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MODULE3HW7.task1
{
    public class task1
    {
        public async void Run()
        {
            var lst = new List<Task>();
            
            lst.Add(Task.Run(() => SomeOtherOperation(3)));
            lst.Add(Task.Run(() => SomeOtherOperation(5)));
            lst.Add(Task.Run(() => SomeOperation(2)));
            lst.Add(Task.Run(() => SomeOtherOperation(4)));

            await Task.WhenAll(lst);

            foreach (var item in lst)
            {
                Console.WriteLine($"{((Task<int>)item).Result} result");   
            }
        }

        private int SomeOperation(int a) => a + a / a - a;

        private int SomeOtherOperation(int a) => a * a + (a - a);
        
        }
}