namespace Bixbu_UI.Threads;


using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class ConcurrentHashSet<T>
{
    private readonly ConcurrentDictionary<T, byte> dictionary = new ConcurrentDictionary<T, byte>();

    public bool Add(T item)
    {
        return dictionary.TryAdd(item, 0);
    }

    public bool Contains(T item)
    {
        return dictionary.ContainsKey(item);
    }

    public bool Remove(T item)
    {
        return dictionary.TryRemove(item, out _);
    }

    public IEnumerable<T> ToList()
    {
        return dictionary.Keys;
    }
}
