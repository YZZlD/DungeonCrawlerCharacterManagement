using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

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
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                } 
            }

            return default;
        }
    }
}