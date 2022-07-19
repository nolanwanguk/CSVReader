namespace CSVQ.Filters;

public abstract class BasicFilter
{
    public Enum Results=default!;
    public int Counts = default!;
    public abstract Enum Transform(Enum lists);
    public abstract Enum FilterFunc(Enum lists);
    public abstract Enum Cleanup(Enum lists);
}