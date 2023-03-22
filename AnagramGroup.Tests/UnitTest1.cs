namespace AnagramGroup.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result = _test.GroupAnagrams(strs);
        IList<IList<string>> answer = new List<IList<string>>();
        IList<string> list = new List<string>();
        list.Add("eat");
        list.Add("tea");
        list.Add("ate");
        answer.Add(list);
        IList<string> list2= new List<string>();
        list2.Add("tan");
        list2.Add("nat");
        answer.Add(list2);
        IList<string> list3= new List<string>();
        list3.Add("bat");
        answer.Add(list3);
        bool trueFalse = true;

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != answer[i][j])
                {
                    trueFalse = false;
                }
            }
        }

        Assert.IsTrue(trueFalse);

    } [TestMethod]
    public void TestMethod2()
    {
        string[] strs = { "" };
        var result = _test.GroupAnagrams(strs);
        IList<IList<string>> answer = new List<IList<string>>();
        IList<string> list = new List<string>();
        list.Add("");
        answer.Add(list);
        bool trueFalse = true;
 
        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != answer[i][j])
                {
                    trueFalse = false;
                }
            }
        }

        Assert.IsTrue(trueFalse);

    } [TestMethod]
    public void TestMethod3()
    {
        string[] strs = { "a" };
        var result = _test.GroupAnagrams(strs);
        IList<IList<string>> answer = new List<IList<string>>();
        IList<string> list = new List<string>();
        list.Add("a");
        answer.Add(list);
       
        bool trueFalse = true;

        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != answer[i][j])
                {
                    trueFalse = false;
                }
            }
        }

        Assert.IsTrue(trueFalse);

    }
    
}