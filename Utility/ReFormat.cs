namespace CSVQ.Utility;

public class ReFormat
{
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