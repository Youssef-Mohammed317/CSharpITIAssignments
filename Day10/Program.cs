
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Threads and Tasks
            #region Threads
            //ThreadStart threadStart = new ThreadStart(PrintX);

            //Thread thread = new Thread(threadStart);

            //Thread thread = new Thread(PrintX);

            // to send parameters with thread
            //Thread thread = new Thread(Test); // method 1: use Function to call your function

            //Thread thread = new Thread(()=>PrintX(10)); // method 2: use lambda exp

            //ParameterizedThreadStart parameterized = new ParameterizedThreadStart(PrintX);
            //Thread thread = new Thread(parameterized);

            //thread.Start(10); // Start Here Calling PrintX with count 10


            //thread.IsBackground = true; 
            //main thread end thread even not ended
            //if main thread end all child threads ends even not ended
            //default if main thread end wait new thread until end then end

            //thread.Start();

            //Thread.Sleep(1000); // main thread sleep for 1 sec because this line executed in main thread

            //PrintY();

            //bool finished = thread.Join(2000); // return bool if there is time for wait

            //if (!finished)
            //{
            //    thread.Abort(); // end thread forced
            //}


            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("Y");
            //    if(i == 10)
            //    {
            //        //thread.Join(); // main thread wait this thread until end then complete its code
            //        //thread.Join(2000); // wait for 2000 ms
            //        //thread.Join(TimeSpan.FromHours(1)); // wait for 1 hour
            //    }
            //}

            // use Thread to return value no exist
            // but you can use thread to change the same prop of a class

            //Helper helper = new Helper();
            //Thread thread = new Thread(helper.PrintMsg);

            //thread.Start();
            //helper.PrintMsg();

            //if there is an exception in new thread
            //you cant catch it in main thread

            #endregion

            #region Tasks
            //Task task = Task.Run(() => PrintX(1000)); // by default background

            //task.Wait(); // not go to main thread until task ended

            //PrintY();

            //if there is an exception in the task 
            //you can catch it and handle it in main thread
            //you can also return value from task

            //Task<int> task = Task.Run(() => myFun());
            //TaskAwaiter<int> taskAwaiter = task.GetAwaiter();
            //taskAwaiter.OnCompleted(Test);
            //taskAwaiter.OnCompleted(() => Console.WriteLine($"Task Finished:Result:{taskAwaiter.GetResult()}"));
            //Console.WriteLine("Any Thing Else....");

            //Thread.Sleep(5000);

            //int result = task.Result;
            //Console.WriteLine(result);


            //RunAsync();
            //Console.WriteLine("Any Thing Else....");

            //Thread.Sleep(5000); // wait until task end because task is background

            #endregion

            // in windows form apps
            // you cant access any control from thread which not created in it
            // so you can use this.invoke() // take delegate which point to function works in main thread by this.invoke() which called in new thread
            // this delegate not take any thing not return any thing
        }

        static public async Task RunAsync()
        {
            //Task<int> task = Task.Run(() => myFun());
            //TaskAwaiter<int> taskAwaiter = task.GetAwaiter();
            //taskAwaiter.OnCompleted(Test);
            //taskAwaiter.OnCompleted(() => Console.WriteLine($"Task Finished:Result:{taskAwaiter.GetResult()}"));

            //int result = await Task.Run(() => myFun()); // i not move from here until task ended
            
            //Console.WriteLine(result);

            //Thread.Sleep(5000);

            //int result = task.Result;
            //Console.WriteLine(result);


        }
        static public int myFun()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Here....");
            return 100;
        }
        // method 1
        static void Test()
        {
            PrintX(10);
        }
        static void PrintX()
        {
            //Thread.Sleep(1000); // child thread sleep for 1 sec because this line executed in this thread

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        }
        // method 1 & 2
        static void PrintX(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("X");
            }
        }
        // method 3
        static void PrintX(object count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                Console.Write("X");
            }
        }
        static void PrintY()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Y");
            }
        }

    }
}
