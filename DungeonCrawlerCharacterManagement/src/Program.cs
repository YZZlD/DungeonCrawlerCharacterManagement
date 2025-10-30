using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;

namespace DungeonCrawlerCharacterManagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            CharacterManagementMenu menu = new CharacterManagementMenu();

            menu.RunMenu();
        }
    }
}