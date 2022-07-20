using CSVQ.Model;

namespace CSVQ.Filters;

public class PersonLivesInDerbyshire : IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }

    public void Transform(List<Person> lists)
    {
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        var results = lists.FindAll(pp => pp.City.ToLower().Contains("derbyshire"));
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