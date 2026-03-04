namespace DataStructures;

public class MyStack<T>
{
    private MyLinkedList<T> list = new MyLinkedList<T>();
    public int Count => list.Count;

    public void Push(T value) => list.AddFirst(value);
    public void Pop() => list.RemoveFirst();
    public bool Contains(T value) => list.Contains(value);
    public void Clear() => list.Clear();
}