namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
     DateTime now = DateTime.Now;
        int hour = now.Hour;
        
        string greeting;
        
        if (hour >= 5 && hour < 12)
        {
            greeting = "Good morning!";
        }
        else if (hour >= 12 && hour < 18)
        {
            greeting = "Good afternoon!";
        }
        else if (hour >= 18 && hour < 22)
        {
            greeting = "Good evening!";
        }
        else
        {
            greeting = "Good night!";
        }
        
        Console.WriteLine(greeting);
    }
}

