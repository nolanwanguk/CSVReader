using CSVQ.Model;
using CSVQ.Utility;
using CsvHelper;
using System;
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
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                var record = csv.GetRecord<Person>();
                Qresults.Add(record);
            }
        }
    }
    public override void AfterRead(){}
    
}