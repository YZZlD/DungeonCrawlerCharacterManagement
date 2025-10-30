using System;
using System.Reflection.PortableExecutable;

namespace DungeonCrawlerCharacterManagement
{
    class Program
    {
        public static void Main(String[] args)
        {

            CharacterManagementMenu menu = new CharacterManagementMenu();
            List<CharacterManagementMenu> menuList = [menu];
            List<Character> characters = new List<Character>();

            List<Skill> skills = new List<Skill>
            {
                new Skill { Name = "Strike", Description = "A powerful strike.", Attribute = "Strength", RequiredAttributePoints = 10 },
                new Skill { Name = "Dodge", Description = "Avoid an attack.", Attribute = "Dexterity", RequiredAttributePoints = 15 },
                new Skill { Name = "Spellcast", Description = "Cast a spell.", Attribute = "Intelligence", RequiredAttributePoints = 20}
            };

            Character monk = new Character("Frank", "Monk", 10);
            Character priest = new Character("Franklin", "Priest", 20);
            monk.LearnSkill(skills[0]);
            monk.LearnSkill(skills[1]);
            characters.Add(monk);
            characters.Add(priest);


            CharacterManagementMenu character = DCCMHelperFunctions.GetObjectByNamePropertyFromEnumerable(menuList, "Frank");
            Console.WriteLine(character);
        }
    }
}