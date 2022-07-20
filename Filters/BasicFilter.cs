using CSVQ.Model;

namespace CSVQ.Filters;

public interface IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }
    public void Transform(List<Person> lists);
    public List<Person>? FilterFunc(List<Person> lists);
    public void Cleanup(List<Person> lists);
}

public class DefaultFilter : IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; } = 0;

    public void Transform(List<Person> lists)
    {
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        Transform(lists);
        Results = lists;
        Cleanup(Results);
        return Results;
    }

    public void Cleanup(List<Person> lists)
    {
    }
}