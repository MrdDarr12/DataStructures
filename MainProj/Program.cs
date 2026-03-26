using MyBinaryTree;
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


            MyBinaryTree<int> tree = new MyBinaryTree<int>();

            // Add
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);

            //In-Order 
            foreach (var item in tree.InOrder())
            {
                Console.Write(item + " ");
            }

            //Pre-Order 
            foreach (var item in tree.PreOrder())
            {
                Console.Write(item + " ");
            }

            //Post-Order Traversal
            foreach (var item in tree.PostOrder())
            {
                Console.Write(item + " ");
            }

            // Remove
            tree.Remove(20);

            tree.Remove(30);

            tree.Remove(50);

            //In-Order After Removals
            foreach (var item in tree)
            {
                Console.Write(item + " ");
            }

           
        }
    }
}