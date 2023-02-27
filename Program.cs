// See https://aka.ms/new-console-template for more information
using Day__2;

Console.WriteLine("Directed BY Mohamed Fayad");

#region Stack
Console.WriteLine("***************//Stack\\\\*************");
Stack_1 s1 = new Stack_1(10);
try
{
    s1.Push(1);
    s1.Push(2);
    s1.Push(3);
    s1.Push(4);
    s1.Push(5);
    s1.Push(6);
    s1.Push(7);
    s1.Push(8);
    s1.Push(9);
    s1.Push(10);
    // s1.Push(11); // →→→ going to catch  Exception
}
catch
{
    Console.WriteLine("stack is full");
}
try
{
    Console.WriteLine("remove  " + s1.Pop());  
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop()); 
    Console.WriteLine("remove  " + s1.Pop());
    //Console.WriteLine("remove  " +s1.Pop());  →→→ going to catch  Exception
}
catch
{
    Console.WriteLine("stack is empty");
}

#endregion


#region Queue
Console.WriteLine("***************//Queue\\\\*************");
Queue q1 = new Queue(10);
try
{
    q1.Push(1);
    q1.Push(2);
    q1.Push(3);
    q1.Push(4);
    q1.Push(5);
    q1.Push(6);
    q1.Push(7);
    q1.Push(8);
    q1.Push(9);
    q1.Push(10);
    // q1.Push(11);// →→→→going to catch  Exception
}
catch
{
    Console.WriteLine("Queue is full");
}
try
{
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    Console.WriteLine("remove  " + q1.Pop());
    // Console.WriteLine("remove  " +q1.Pop()); // →→→ going to catch  Exception
}
catch
{
    Console.WriteLine("Queue is empty");
} 
#endregion
