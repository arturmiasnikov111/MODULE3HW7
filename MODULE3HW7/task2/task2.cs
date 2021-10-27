using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MODULE3HW7.task2
{
    public class task2
    {
        private readonly CancellationTokenSource _cancellationToken;

        public task2()
        {
            _cancellationToken = new CancellationTokenSource();
        }

        public void Run()
        {
            var task = Task.Run(() => Fibon(1));
            Thread.Sleep(10000);
            _cancellationToken.Cancel();
            Console.WriteLine(task.Result);
        }

        public double Fibon(double number)
        {
            if (_cancellationToken.Token.IsCancellationRequested)
            {
                Console.WriteLine("operation is canceled");
                return number;
            }

            if (number <= 1)
            {
                return number;
            }

            return Fibon(number - 1) + Fibon(number - 2);
        }
    }
}