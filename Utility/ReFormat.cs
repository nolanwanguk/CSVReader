namespace CSVQ.Utility;

public class ReFormat
{
    public static int Phone_To_Num(string num)
    {
        num = num.Replace("-", "");
        try
        {
            int result=Convert.ToInt32(num);
            return result;
        }
        catch
        {
            return -1;
        }
    }
}