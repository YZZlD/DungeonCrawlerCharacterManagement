using System;

namespace DungeonCrawlerCharacterManagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Character> characters = new List<Character>();

            List<Skill> skills = new List<Skill>
            {
                new Skill { Name = "Strike", Description = "A powerful strike.", Attribute = "Strength", RequiredAttributePoints = 10 },
                new Skill { Name = "Dodge", Description = "Avoid an attack.", Attribute = "Dexterity", RequiredAttributePoints = 15 },
                new Skill { Name = "Spellcast", Description = "Cast a spell.", Attribute = "Intelligence", RequiredAttributePoints = 20}
            };

            Character monk = new Character("Frank", "Monk", 10);
            //monk.LearnSkill(skills[0]);
            Console.WriteLine(monk);
        }
    }
}