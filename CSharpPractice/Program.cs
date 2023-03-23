namespace MyProject;


class Program
{
    
    static void Main(string[] args)
    {

       Stack <string> stack = new Stack<string>();
        stack.Push("a");
        stack.Push("b");
        stack.Push("c");

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Peek()); //the top most element in the stack

            stack.Pop();
        }

       
    }
}