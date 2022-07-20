using CSVQ.Model;
using CSVQ.Utility;
namespace CSVQ.Filters;

public class PersonHouseNumberEquals3:IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }

    public List<Person>? Transform(List<Person> lists)
    {
        return Results;
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        var results = lists.FindAll(pp => pp.Address.Split()[0].Length==3);
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