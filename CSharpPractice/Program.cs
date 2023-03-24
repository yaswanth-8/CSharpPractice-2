using System.Collections.Generic;

namespace MyProject;
//change to main while executing(main method)

class Program
{

    public static void Main(string[] args)  
    {
       var list = new LinkedList<string>();
       
        list.AddLast("ab");
        list.AddLast("bc");
        list.AddLast("cd");
        list.AddLast("de");
        list.AddLast("ef");
        list.AddLast("cd");
        LinkedListNode<string> node = list.Find("cd");
        LinkedListNode<string> currentNode = list.First;
        while (currentNode != null)
        {
            if (currentNode.Value == "cd")
            {
                // create new node with new value
                LinkedListNode<string> newNode = new LinkedListNode<string>("new");

                // insert new node before current node
                list.AddBefore(currentNode, newNode);
            }

            // move to next node
            currentNode = currentNode.Next;
        }

        foreach(string i in list)
        {
            Console.WriteLine(i);
        }
    }

}