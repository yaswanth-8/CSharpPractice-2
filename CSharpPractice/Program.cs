namespace MyProject;

class Sample<T>
{
    public Sample(T message) { 
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sample<string> genericPractice = new Sample<string>("Yaswanth");
        Sample<int> number = new Sample<int>(8);
    }
}