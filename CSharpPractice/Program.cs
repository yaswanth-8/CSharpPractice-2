using System.Collections.Generic;

namespace MyProject;
//change to main while executing(main method)

class Program
{

    public static void Main(string[] args)  
    {
       Dictionary<int,string> map = new Dictionary<int,string>();
        map.Add(1, "yaswanth");
        map.Add(2, "kishore");
        map.Add(3, "gokulakrishnan");

        foreach(KeyValuePair<int,string> kvp in map)
        {
            if (kvp.Value == "yaswanth")
            {
                map[kvp.Key] = "kavin";
            }
            Console.WriteLine(kvp.Key + " " + kvp.Value);
        }
        
    }

}