using CSVQ.IO;
using CSVQ.Utility;
using CSVQ.Model;
using CSVQ.Filters;

namespace CSVQ
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Start");
            var reader = new CSVHelperReader();
            reader.Reader(@"Data/input.csv");
            var results = reader.Qresults;
            var filter = new PersonHouseNumberEquals3();
            var f = filter.FilterFunc(results);
            Console.WriteLine("Counts:{0}",f.Count);
            Display.Display_in_Console_Debug(f);
        }
    }
}

