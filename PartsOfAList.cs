using System;
using System.Linq;
public class PartList
{
    public static string[][] Partlist(string[] arr) =>    
        Enumerable
            .Range(0, arr.Length - 1)
            .Aggregate(new string[arr.Length - 1][], (previous, current) =>
            {
                previous[current] = new[] { string.Join(" ", arr.Take(current + 1)), string.Join(" ", arr.Skip(current + 1)) };
                return previous;
            }); 
}