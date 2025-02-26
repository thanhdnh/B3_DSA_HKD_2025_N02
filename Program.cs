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
        if(top!=null)
            countA--;
        return d;
    }
    public int Count(){
        int dem = 0;
        MyStack temp = new MyStack();
        Node n;
        do{
            n = Pop();
            if(n!=null){
                dem++;
                temp.Push(n.data);
            }
        }while(n!=null);
        do{
            n = temp.Pop();
            if(n!=null)
                Push(n.data);
        }while(n!=null);
        return dem;
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
        Console.WriteLine("Count: " + s.Count());
        Console.WriteLine("Count: " + s.countA);


        System.Collections.Stack st = new System.Collections.Stack();
        //st.
    }
}