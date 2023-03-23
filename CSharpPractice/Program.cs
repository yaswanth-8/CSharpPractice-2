namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        int result=0;
        int zero = 0;
        try
        {
            result = 5 / zero;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Exception caught: {0}", e);
        }
        finally
        {
            Console.WriteLine("Result: {0}", result);
        }
    }
}