namespace MyProject;


class Program
{

    public static void square(out int a)
    {
        a = 10;
        a = a * a;
    }
    
    static void Main(string[] args)
    {
        int a = 2;
        square(out a);
        Console.WriteLine(a);
       
       
    }
}