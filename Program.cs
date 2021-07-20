using System;
using System.Threading.Tasks;

namespace ParallelProgramming1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parallel Tasks");

            //Task task1 = new Task(() => DoSomething());
            //Task task11 = new Task((obj) => DoSomething(obj), 11);
            //Task<string> task12 = new Task<string>(() => DoSomething(12, 5));

            //Task task2 = new Task(delegate
            //{
            //    DoSomething();
            //});
            //Task task21 = new Task(delegate (object obj)
            //{
            //    DoSomething(obj);
            //}, 21);
            //Task<string> task22 = new Task(delegate (object obj1, object obj2)
            //{
            //    DoSomething(obj1, obj2);
            //}, 22, 5);

            Task task3 = new Task(new Action(DoSomething));
            Task task31 = new Task(new Action<object>(DoSomething),31);
            Task<string> task32 = new Task<string>(() => DoSomething());

            //Task task4 = new Task(new Action<object>(DoSomething), 4);

            //Task.Factory.StartNew(() =>
            //{
            //    DoSomething(5);
            //    DoSomething(6);
            //});

            //Task<string> task7 = new Task<string>(() => DoSomething(7, 12));
            //Task<string> task9 = new Task<string>(() => DoSomething(9, 12));

            //task1.Start();
            //task2.Start();
            task3.Start();
            task31.Start();
            //task7.Start();
            //Console.WriteLine("Task 7 -> Waiting for task to complete.");
            //task7.Wait();
            //Console.WriteLine("Task 7 Completed.");

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }

        static void DoSomething()
        {
            Console.WriteLine($"Task run");
        }

        static void DoSomething(object n)
        {
            Console.WriteLine($"Task {n} run");
        }

        static string DoSomething(object n, object param)
        {
            Console.WriteLine($"Task {n} run with param={param}");

            var res = Convert.ToInt32(n) * Convert.ToInt32(param);

            return $"Result={res}";
        }
    }
}
