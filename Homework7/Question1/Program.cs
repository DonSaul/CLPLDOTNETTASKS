// using System.Collections.Generic;
// using System.Linq;

internal class Program
{
  class MyUtils
  {
    public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dictionary)
    {
      bool areEqual = true;

      foreach (string item in list)
      {
        if (!dictionary.ContainsValue(item))
          areEqual = false;
      }

      foreach (string dictValue in dictionary.Values)
      {
        if (!list.Contains(dictValue))
          areEqual = false;
      }

      return areEqual;
    }
  }

  private static void Main(string[] args)
  {
    var list1 = new List<string> { "aa", "bb", "aa", "dd", "cc", "zz" };
    var dictionary1 = new Dictionary<string, string> { { "1", "aa" }, { "2", "bb" }, { "3", "aa" }, { "4", "dd" }, { "5", "cc" }, { "6", "zz" } };

    var list2 = new List<string> { "aa", "bb", "aa", "zz" };
    var dictionary2 = new Dictionary<string, string> { { "1", "aa" }, { "2", "zz" }, { "3", "aa" }, { "6", "dd" } };

    var list3 = new List<string> { "aa", "bb", "aa", "zz" };
    var dictionary3 = new Dictionary<string, string> { { "1", "aa" }, { "2", "bb" }, { "3", "aa" } };

    var list4 = new List<string> { "aa", "bb", "aa", "dd", "cc", "zz" };
    var dictionary4 = new Dictionary<string, string> { { "1", "zz" }, { "2", "cc" }, { "3", "dd" }, { "4", "aa" }, { "5", "bb" }, { "6", "aa" } };

    var list5 = new List<string> { "aa" };
    var dictionary5 = new Dictionary<string, string> { { "1", "aa" }, { "2", "bb" }, { "3", "aa" }, { "4", "dd" }, { "5", "cc" }, { "6", "zz" } };


    Console.Write("EXPECTED: True\tRESULT: ");
    Console.WriteLine(MyUtils.ListDictionaryCompare(list1, dictionary1));

    Console.Write("EXPECTED: False\tRESULT: ");
    Console.WriteLine(MyUtils.ListDictionaryCompare(list2, dictionary2));

    Console.Write("EXPECTED: False\tRESULT: ");
    Console.WriteLine(MyUtils.ListDictionaryCompare(list3, dictionary3));

    Console.Write("EXPECTED: True\tRESULT: ");
    Console.WriteLine(MyUtils.ListDictionaryCompare(list4, dictionary4));

    Console.Write("EXPECTED: False\tRESULT: ");
    Console.WriteLine(MyUtils.ListDictionaryCompare(list5, dictionary5));

  }
}