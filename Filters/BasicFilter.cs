using CSVQ.Model;

namespace CSVQ.Filters;

public interface IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }
    public List<Person>? Transform(List<Person> lists);
    public List<Person>? FilterFunc(List<Person> lists);
    public List<Person>? Cleanup(List<Person> lists);
}

public class DefaultFilter:IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; } = 0;
    public List<Person>? Transform(List<Person> lists)
    {
        return lists;
    }

    public List<Person>? FilterFunc(List<Person> lists)
    {
        Results = lists;
        return lists;
    }

    public List<Person>? Cleanup(List<Person> lists)
    {
        return lists;
    }
}