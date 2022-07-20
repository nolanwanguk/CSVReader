using CSVQ.Model;

namespace CSVQ.Filters;

public class PersonHouseNumberEquals3 : IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }

    public void Transform(List<Person> lists)
    {
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        var results = lists.FindAll(pp => pp.Address.Split()[0].Length == 3);
        Transform(results);
        Results = results;
        Counts = results.Count;
        Cleanup(Results);
        return Results;
    }

    public void Cleanup(List<Person> lists)
    {
    }
}