using System.Collections;
using System.Text;

string[] myStrings = ["a", "b", "c"];

Console.WriteLine($"myStrings is {Format(myStrings)}");
Console.WriteLine($"myStrings contains a: {myStrings.Contains("a")}");
Console.WriteLine($"myStings has length: {myStrings.Length}");

List<string> myStringList = ["a", "b", "c"];
// myStringList.Capacity = 100;

Console.WriteLine("=== List ===");
Console.WriteLine($"myStringList is {Format(myStringList)}");
Console.WriteLine($"myStringList contain a: {myStringList.Contains("a")}");
Console.WriteLine($"myStringList contain d: {myStringList.Contains("d")}");
Console.WriteLine($"myStringList has length: {myStringList.Count}");
Console.WriteLine($"myStringList has capacity: {myStringList.Capacity}");

myStringList.Add("d");
myStringList.Add("b");

Console.WriteLine("=== Added d ===");
Console.WriteLine($"myStringList is {Format(myStringList)}");
Console.WriteLine($"myStringList contain a: {myStringList.Contains("a")}");
Console.WriteLine($"myStringList contain d: {myStringList.Contains("d")}");
Console.WriteLine($"myStringList has length: {myStringList.Count}");
Console.WriteLine($"myStringList has capacity: {myStringList.Capacity}");

Console.WriteLine($"removing b: {myStringList.Remove("b")}");
Console.WriteLine($"removing x: {myStringList.Remove("x")}");
Console.WriteLine($"myStringList is {Format(myStringList)}");

myStringList.Insert(1, "X");
myStringList.Insert(0, "Y");
Console.WriteLine($"myStringList is {Format(myStringList)}");

myStringList.RemoveAt(0);
myStringList.RemoveAt(1);
Console.WriteLine($"myStringList is {Format(myStringList)}");

myStringList.RemoveAt(myStringList.Count - 1);
Console.WriteLine($"myStringList is {Format(myStringList)}");

return;

static string Format(IEnumerable enumerable)
{
    StringBuilder sb = new("[");
    string separator = "";

    foreach (object? item in enumerable)
    {
        if (item == null) continue;
        sb.Append(separator);
        sb.Append(item.ToString());
        separator = ", ";
    }

    sb.Append("]");
    return sb.ToString();
}