using System.Globalization;
using CSVQ.Model;

namespace CSVQ.IO;

public class CSVHelperReader : BasicReader
{
    /// <summary>
    /// Read local csv file by CsvHelper package
    /// and store data in a List of Person record which defined in CSVQ.Model
    /// </summary>
    public List<Person> Qresults = new(); // final list results for public accessing

    public override void BeforeRead()
    {
    }

    public override void Reader(string path)
    {
        BeforeRead();
        using (var reader = new StreamReader(path))
        using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Person>();
            foreach (var record in records) Qresults.Add(record);
        }

        AfterRead();
    }

    public override void AfterRead()
    {
    }
}