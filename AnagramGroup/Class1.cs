namespace AnagramGroup;
public class Class1
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedArray = new string(charArray);
            if (dictionary.ContainsKey(sortedArray))
            {
                dictionary[sortedArray].Add(strs[i]);
            }
            else
            {
                dictionary.Add(sortedArray, new List<string>() { strs[i] });
            }
        }

        var result = dictionary.Values.ToList();
        return result;
    }
}
