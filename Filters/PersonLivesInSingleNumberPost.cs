using CSVQ.Model;

namespace CSVQ.Filters;

public class PersonLivesInSingleNumberPost : IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }

    public void Transform(List<Person> lists)
    {
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        var results = lists.FindAll(pp =>
            char.IsLetter(pp.Postal.Split()[0][pp.Postal.Split()[0].Length - 1]) &&
            !char.IsLetter(pp.Postal.Split()[0][pp.Postal.Split()[0].Length - 2]));
        Transform(results);
        Results = results;
        Counts = results.Count;
        Cleanup(results);
        return Results;
    }

    public void Cleanup(List<Person> lists)
    {
    }
}