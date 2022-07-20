namespace CSVQ.Utility;

public class CsvParser
{
    public static List<string> Decouple(string arg, string delimit = ",")
    {
        string[] arr = arg.Split(delimit);
        List<string> results = new List<string>();
        string concatStr = string.Empty;
        int flag = -1;
        
        for (var i = 0; i < arr.Length; i++)
        {
            if (flag == -1) {results.Add(arr[i]);}
            if (arr[i] == string.Empty) { return results; }
            
            if (arr[i].StartsWith("\""))
            {
                flag = 1;
                concatStr+=arr[i];
            }
            
            if (flag == 1)
            {
                concatStr += arr[i];
            }
            
            if ( flag== 1&&arr[i].EndsWith("\"") )
            {
                results.Add((concatStr+arr[i]).Replace("\"",""));
                flag = -1;
                concatStr = string.Empty;
            }

            
        }

        if (concatStr==String.Empty) {return results;}
        
        results = arr.ToList();
        return results;
    }
    // Placehold for functional usages
    public static string Concat(string[] args)
    {
        var str = string.Concat(args);
        str = str.Replace("\"", string.Empty).Trim();
        return str;
    }
}