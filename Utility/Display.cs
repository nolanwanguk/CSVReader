using CSVQ.Model;

namespace CSVQ.Utility;
/// <summary>
/// Display a List<Person/> object in Console
/// </summary>
public class Display
{
    /// <summary>
    /// show all items in the list
    /// </summary>
    /// <param name="lists">list of List<Person/> needs to shown in Console</param>
    public static void Display_in_Console(List<Person>? lists)
    {
        lists?.ForEach(i => Console.WriteLine(i.ToString()));
    }
    /// <summary>
    /// show top 3 items || null in the list for debugging 
    /// </summary>
    /// <param name="lists">list of List<Person/> needs to shown in Console</param>
    public static void Display_in_Console_Debug(List<Person>? lists)
    {
        lists = lists?.GetRange(0, 3);
        lists?.ForEach(i => Console.WriteLine(i.ToString()));
    }
}