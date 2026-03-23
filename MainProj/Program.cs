using MyLinkedListProgramm;

namespace MainProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            MyQueue<int> queue = new MyQueue<int>();   
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());

            queue.Enqueue(1);
            queue.Enqueue(2);   
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

        }
    }
}