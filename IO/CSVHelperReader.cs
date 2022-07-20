using CSVQ.Model;
using System.Globalization;

namespace CSVQ.IO;

public class CSVHelperReader:BasicReader
{
    public List<Person> Qresults = new List<Person>();
    public override void BeforeRead() { }
    public override void Reader(string path)
    {
        using (var reader = new StreamReader(path))
        using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Person>();
            foreach (var record in records)
            {
                Qresults.Add(record);
            }
        }
    }
    public override void AfterRead(){}
    
}