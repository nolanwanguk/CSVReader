namespace CSVQ.IO;
/// <summary>
/// BeforeRead does setup environments and define public variables for different readers
/// Reader is the real action method to retrieve data
/// AfterRead does cleanup works and close handlers which may opened in Reader
/// ::BeforeRead could be empty
/// ::AfterRead could be empty
/// </summary>
public abstract class BasicReader
{
    public abstract void BeforeRead();
    public abstract void Reader(string path);
    public abstract void AfterRead();
}