namespace CSVQ.Utility;

public class Display
{
    public void Display_in_Console(List<Enum> lists)
    {
        lists.ForEach(i => Console.WriteLine(i.ToString()));
    }
}