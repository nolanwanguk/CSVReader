namespace CSVQ.Utility;
/// <summary>
/// re-format one type to another type with some processes
/// </summary>
public class ReFormat
{
    /// <summary>
    /// format and convert a string phone number to integer
    /// </summary>
    /// <param name="num">string type phone number which includes "-" </param>
    /// <returns>integer type phone number without "-" or -1 when failed</returns>
    public static int Phone_To_Num(string num)
    {
        num = num.Replace("-", "");
        try
        {
            var result = Convert.ToInt32(num);
            return result;
        }
        catch
        {
            return -1;
        }
    }
}