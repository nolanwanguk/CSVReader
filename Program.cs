using CSVQ.Filters;
using CSVQ.IO;
using CSVQ.Model;
using CSVQ.Utility;

namespace CSVQ;

public class Program
{
    public static void ShowOptions()
    {
        Console.WriteLine("Option 1:Every person who has “Esq” in their company name.");
        Console.WriteLine("Option 2:Every person who lives in “Derbyshire”.");
        Console.WriteLine("Option 3:Every person whose house number is exactly three digits.");
        Console.WriteLine("Option 4:Every person whose website URL is longer than 35 characters.");
        Console.WriteLine("Option 5:Every person who lives in a postcode area with a single-digit value.");
        Console.WriteLine(
            "Option 6:Every person whose first phone number is numerically larger than their second phone number.");
    }

    public static void Main()
    {
        Console.WriteLine("Start Testing");
        var reader = new CSVHelperReader();
        reader.Reader(@"Data/input.csv");
        var results = reader.Qresults;
        var filtered = new List<Person>();
        Console.WriteLine("Please insert a filter option [1 to 6]:");
        var A = Console.ReadLine();

        if (A != null)
        {
            if (A == "1")
                filtered = new PersonHasEsqInCompany().FilterFunc(results);
            else if (A == "2")
                filtered = new PersonLivesInDerbyshire().FilterFunc(results);
            else if (A == "3")
                filtered = new PersonHouseNumberEquals3().FilterFunc(results);
            else if (A == "4")
                filtered = new PersonWebsiteLongerThan35().FilterFunc(results);
            else if (A == "5")
                filtered = new PersonLivesInSingleNumberPost().FilterFunc(results);
            else if (A == "6")
                filtered = new PersonPhone1LargerThanPhone2().FilterFunc(results);
            else
                filtered = new DefaultFilter().FilterFunc(results);
            Console.WriteLine("Counts:{0}", filtered.Count);
            Display.Display_in_Console_Debug(filtered);
        }
    }
}