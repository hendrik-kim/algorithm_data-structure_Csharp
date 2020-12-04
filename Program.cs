using System;

namespace Algorithm_DataStructure_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.add(1);
            q.add(2);
            q.add(3);
            q.add(4);
            q.add(5);
            Console.WriteLine(q.remove());
            Console.WriteLine(q.remove());
            Console.WriteLine(q.peek());
            Console.WriteLine(q.remove());
            Console.WriteLine(q.isEmpty());
        }
    }
}
