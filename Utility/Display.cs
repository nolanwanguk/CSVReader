using CSVQ.Model;

namespace CSVQ.Utility;

public class Display
{
    public static void Display_in_Console(List<Person>? lists)
    {
        lists?.ForEach(i => Console.WriteLine(i.ToString()));
    }
}