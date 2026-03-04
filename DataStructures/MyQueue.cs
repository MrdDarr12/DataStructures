namespace DataStructures;
public class MyQueue<T>
{
    private MyLinkedList<T> list = new MyLinkedList<T>();
    public int Count => list.Count;

    public void Enqueue(T value) => list.AddLast(value);
    public void Dequeue() => list.RemoveFirst();
    public bool Contains(T value) => list.Contains(value);
    public void Clear() => list.Clear();
}