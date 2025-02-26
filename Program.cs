public class Node
{
    public Node next;
    public object data;
}
public class MyStack
{
    Node top;
    public int countA = 0;
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
        countA++;
    }
    public Node Pop()
    {
        if (top == null)
            return null;
        Node d = top;
        top = top.next;
        if (countA > 0)
            countA--;
        return d;
    }
    public int Count()
    {
        int dem = 0;
        MyStack temp = new MyStack();
        //Node n;
        do
        {
            //n = Pop();
            //if(n!=null){
            dem++;
            temp.Push(Pop().data);
            //}
        } while (top != null);
        do
        {
            /*n = temp.Pop();
            if(n!=null)
                Push(n.data);*/
            Push(temp.Pop().data);
        } while (temp.top != null);
        return dem;
    }
    public object Peek()
    {
        /*object n = Pop().data;
        Push(n);
        return n;*/
        return top.data;
    }
    public bool Contains(int ele)
    {
        MyStack temp = new MyStack();
        while (top != null)
        {
            int value = (int)Pop().data;
            temp.Push(value);
            if (value == ele)
            {
                while (temp.top != null)
                    Push(temp.Pop().data);
                return true;
            }
        }
        while (temp.top != null)
            Push(temp.Pop().data);
        return false;
    }
    //Bổ sung hàm sort để sx theo thứ tự tăng dần
}
public class Node2
{
    public Node2 prev, next;
    public object data;
}
public class MyQueue
{
    Node2 rear, front; public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
            rear.prev = n;
            n.next = rear; rear = n;
        }
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        return d;
    }
    //Bổ sung các phương thức Count, Peek, Contains, Sort
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
        Console.WriteLine("Count: " + s.Count());
        Console.WriteLine("Count: " + s.countA);
        Console.WriteLine("Peek: " + s.Peek());
        Console.WriteLine("Contains 2: " + s.Contains(2));
        Console.WriteLine("Contains 4: " + s.Contains(4));


        System.Collections.Stack st = new System.Collections.Stack();
        //st.
    }
}