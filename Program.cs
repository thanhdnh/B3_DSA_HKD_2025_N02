public class Node
{
    public Node next;
    public object data;
}
public class MyStack
{
    Node top;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object ele)
    {
        Node n = new Node();
        n.data = ele;
        n.next = top;
        top = n;
    }
    public Node Pop()
    {
        if (top == null)
            return null;
        Node d = top;
        top = top.next;
        return d;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        MyStack s = new MyStack();
        s.Push(1);
        s.Push(2);
        s.Push(3);
    }
}