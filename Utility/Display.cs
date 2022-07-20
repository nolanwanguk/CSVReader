using CSVQ.Model;

namespace CSVQ.Utility;

public class Display
{
    public static void Display_in_Console(List<Person>? lists)
    {
        lists?.ForEach(i => Console.WriteLine(i.ToString()));
    }

    public static void Display_in_Console_Debug(List<Person>? lists)
    {
        lists = lists?.GetRange(0, 3);
        lists?.ForEach(i => Console.WriteLine(i.ToString()));
    }
}