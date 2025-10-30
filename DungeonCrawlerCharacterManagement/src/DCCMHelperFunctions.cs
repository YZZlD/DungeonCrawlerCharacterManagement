using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CSharp.RuntimeBinder;

namespace DungeonCrawlerCharacterManagement
{
    static class DCCMHelperFunctions
    {
        public static T GetObjectByNamePropertyFromEnumerable<T>(IEnumerable<T> objs, string name)
        {
            foreach (T obj in objs)
            {
                dynamic o = obj;
                try
                {
                    if (o.Name == name) return obj;
                } catch(RuntimeBinderException e)
                {
                    Console.WriteLine("Object does not have property [Name].");
                    return default;
                } 
            }

            return default;
        }
    }
}