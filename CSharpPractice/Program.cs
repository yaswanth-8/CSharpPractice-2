namespace MyProject;


class Program
{
    
    static void Main(string[] args)
    {

        var mySet = new SortedSet<int>() {1, 5, 7, 3 };
        foreach (var item in mySet)
        {
            Console.WriteLine(item);
        }

       
    }
}