using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // ConcurrentQueue
        ConcurrentQueue<int> cq = new ConcurrentQueue<int>();

        // Producer Threads
        Task producer1 = Task.Run(() => {
            for (int i = 1; i <= 5; i++)
            {
                cq.Enqueue(i);
                Console.WriteLine("Producer1 Enqueue: " + i);
            }
        });

        Task producer2 = Task.Run(() => {
            for (int i = 6; i <= 10; i++)
            {
                cq.Enqueue(i);
                Console.WriteLine("Producer2 Enqueue: " + i);
            }
        });

        Task.WaitAll(producer1, producer2);

        // Consumer Thread
        Task consumer = Task.Run(() => {
            while (cq.TryDequeue(out int item))
            {
                Console.WriteLine("Consumer Dequeue: " + item);
            }
        });

        consumer.Wait();
    }
}

