using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bixbu_UI.Threads
{
    public class ThreadSafeHashSet<T>
    {
        private readonly HashSet<T> hashSet;
        private readonly object syncLock = new object();

        public ThreadSafeHashSet()
        {
            hashSet = new HashSet<T>();
        }

        public bool Contains(T item)
        {
            lock (syncLock)
            {
                return hashSet.Contains(item);
            }
        }

        public void Add(T item)
        {
            lock (syncLock)
            {
                hashSet.Add(item);
            }
        }

        public void Remove(T item)
        {
            lock (syncLock)
            {
                hashSet.Remove(item);
            }
        }

        // Add additional methods as needed for your use case
    }
}
