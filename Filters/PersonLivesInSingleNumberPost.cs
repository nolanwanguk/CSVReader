using CSVQ.Model;
using CSVQ.Utility;
namespace CSVQ.Filters;

public class PersonLivesInSingleNumberPost:IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }

    public List<Person>? Transform(List<Person> lists)
    {
        return Results;
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        var results = lists.FindAll(pp => Char.IsLetter(pp.Postal.Split()[0][pp.Postal.Split()[0].Length-1]) && !Char.IsLetter(pp.Postal.Split()[0][pp.Postal.Split()[0].Length - 2]));
        Results = results;
        Counts = results.Count;
        return results;
    }

    public List<Person>? Cleanup(List<Person> lists)
    {
        return Results;
    }

    public void Show()
    {
        Console.WriteLine("Counts:{0}", Counts);
        if (Counts > 0)
        {
            Display.Display_in_Console(Results);
        }
    }
}