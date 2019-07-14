using System;
using System.Collections.Generic;
using System.Linq;

class WithIndex<T>
{
    public T Value;
    public int Index;
    public WithIndex(T value, int index)
    {
        this.Value = value;
        this.Index = index;
    }
}

static class Program
{
    static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());

        var inputs = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s))
            .ToArray();

        var array1 = new int[1];
        foreach (var i in Enumerable.Range(0, 1))
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        int w = 1, h = 1;
        var array2 = new int[h, w];
        foreach (var y in Enumerable.Range(0, h))
        {
            var _inputs = Console.ReadLine()
               .Split(' ')
               .Select(s => int.Parse(s))
               .ToArray();
            foreach (var x in Enumerable.Range(0, w))
            {
                array2[y, x] = _inputs[x];
            }
        }
    }

    static IEnumerable<WithIndex<T>> WithIndex<T>(this IEnumerable<T> sequence)
    {
        int index = 0;
        foreach (var item in sequence)
        {
            yield return new WithIndex<T>(item, index);
            index++;
        }
    }
}

