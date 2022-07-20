using CSVQ.Utility;
namespace Tests;

public class UtilityTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Concat()
    {
        Assert.That(CsvParser.Concat(new string[]{"\"aaa","kkk\""}), Is.EqualTo(("aaakkk")));
    }

    [Test]
    public void Test_Decouple()
    {
        Assert.Pass();
        //Assert.That(CsvParser.Decouple("France,Andrade,\"Elliott, John W Esq\",8 Moor Place,East Southbourne and Tuckton W,Bournemouth,BH6 3BE,01347-368222,01935-821636,france.andrade@hotmail.com,http://www.elliottjohnwesq.co.uk"),Is.EqualTo(new List<string>{"France","Andrade","Elliott, John W Esq","8 Moor Place","East Southbourne and Tuckton W","Bournemouth","BH6 3BE","01347-368222,01935-821636","france.andrade@hotmail.com","http://www.elliottjohnwesq.co.uk"}));
    }
}