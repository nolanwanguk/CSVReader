namespace CSVQ.IO;

public abstract class BasicReader
{
    public abstract void BeforeRead();
    public abstract void Reader(string path);
    public abstract void AfterRead();
}