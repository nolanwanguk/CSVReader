using CSVQ.Model;
using CSVQ.Utility;

namespace CSVQ.IO;

public class CsvReader : BasicReader
{
    private List<string> _content = new();
    public List<Person> Qresults = new();

    public override void BeforeRead()
    {
    }

    public override void Reader(string path)
    {
        _content = File.ReadAllLines(path).ToList();
    }

    public override void AfterRead()
    {
        for (var i = 0; i < _content.Count; i++)
        {
            if (i == 0) continue;
            var row = CsvParser.Decouple(_content[i]);
            Qresults.Add(new Person(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],
                row[10]));
        }
    }
}