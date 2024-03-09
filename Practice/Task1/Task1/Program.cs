using System;

try
{
        Stack<int> intS = new Stack<int>();
        intS.Push(Convert.ToInt32(Console.ReadLine()));
        intS.Push(Convert.ToInt32(Console.ReadLine()));
        intS.Push(Convert.ToInt32(Console.ReadLine()));
        intS.Push(Convert.ToInt32(Console.ReadLine()));


        Console.WriteLine(intS.Pop()); 
        Console.WriteLine(intS.Peek()); 

        Stack<string> stringS = new Stack<string>();
        stringS.Push("Alijon");
        stringS.Push("Muhammad");
        stringS.Push("Muhammad");


        Console.WriteLine(stringS.Pop()); 
        Console.WriteLine(stringS.Peek()); 
    

}
catch (Exception)
{
    
    System.Console.WriteLine("Ne verniy format Vvoda : ");
}
