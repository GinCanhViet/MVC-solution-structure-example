using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace GBlog.Service.Caching
{
    public class InMemoryCache : ICacheService
    {
        //https://stackoverflow.com/a/349111
        public T GetOrSet<T>(string cacheKey, int minutesCaching, Func<T> getItemCallback) where T : class
        {
            if (!(MemoryCache.Default.Get(cacheKey) is T item))
            {
                item = getItemCallback();
                MemoryCache.Default.Add(cacheKey, item, DateTime.Now.AddMinutes(minutesCaching));
            }
            return item;
        }
        public T Get<T>(string key)
        {
            return (T)MemoryCache.Default.Get(key);
        }

        //public IEnumerable<T> GetList<T>(IEnumerable<string> keyList)
        //{
        //    List<T> listCache = new List<T>();
        //    foreach (var item in MemoryCache.Default)
        //    {

        //        dynamic cache = new { cache = item.Key, value = item.Value };
        //        listCache.Add((T)cache);
        //    }
        //    return listCache;
        //}

        public void Remove(string key)
        {
            MemoryCache.Default.Remove(key);
        }

        public void Remove(IEnumerable<string> keyList)
        {
            foreach (string key in keyList)
            {
                MemoryCache.Default.Remove(key);
            }
        }
        public void Dispose()
        {
            MemoryCache.Default.Dispose();
        }
    }

    interface ICacheService
    {
        T GetOrSet<T>(string cacheKey, int minutesCaching, Func<T> getItemCallback) where T : class;
        void Dispose();
    }
}
