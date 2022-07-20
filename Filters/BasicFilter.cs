using CSVQ.Model;

namespace CSVQ.Filters;

public interface IBasicFilter
{
    /// <summary>
    /// ::Results is the final data after filtered for public accessing
    /// ::Counts is the count of the final data
    /// Transform does convert, reformat and other operations before into filter
    /// FilterFunc is the real action method which filter data from Transformed ::Results
    /// Cleanup does close handlers, remove empty lists and so on after filtered
    /// ::Transform could be empty
    /// ::Cleanup could be empty
    /// </summary>
    public List<Person>? Results { get; set; }
    public int Counts { get; set; }
    public void Transform(List<Person> lists);
    public List<Person>? FilterFunc(List<Person> lists);
    public void Cleanup(List<Person> lists);
}

public class DefaultFilter : IBasicFilter
{
    /// <summary>
    /// Fundamental filter class for passing through input directly
    /// N: using in Debugging
    /// N: a template to create new filter class 
    /// </summary>
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