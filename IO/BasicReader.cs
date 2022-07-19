namespace CSVQ.IO;

public abstract class BasicReader
{
    public string Path = default!;
    public abstract void BeforeRead();
    public abstract Enum Reader(string path);
    public abstract void AfterRead();

}