using CSVQ.Model;

namespace CSVQ.Filters;

public interface IBasicFilter
{
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }
    public List<Person>? Transform(List<Person> list);
    public List<Person>? FilterFunc(List<Person> lists);
    public List<Person>? Cleanup(List<Person> lists);
}