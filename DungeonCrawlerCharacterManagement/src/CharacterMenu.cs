using System;

namespace DungeonCrawlerCharacterManagement
{
    class CharacterManagementMenu
    {
        private List<Character> _characterList = new List<Character>();
        
        private List<Skill> _skills = new List<Skill>
        {
            new Skill { Name = "Strike", Description = "A powerful strike.", Attribute = "Strength", RequiredAttributePoints = 10 },
            new Skill { Name = "Dodge", Description = "Avoid an attack.", Attribute = "Dexterity", RequiredAttributePoints = 15 },
            new Skill { Name = "Spellcast", Description = "Cast a spell.", Attribute = "Intelligence", RequiredAttributePoints = 20}
        };

        private void CreateCharacter()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Console.Write("Enter class:");
            string charClass = Console.ReadLine();
            Console.Write("Enter Total Attribute Points: ");
            int attributePoints = int.Parse(Console.ReadLine());

            _characterList.Add(new Character(name, charClass, attributePoints));
        }

        private void AssignSkill(Character character, Skill skill)
        {
            if (character.LearnSkill(skill))
            {
                Console.WriteLine($"Skill: {skill.Name} added to {character.Name}");
                return;
            }
            Console.WriteLine("Not enough attribute points are available.");
        }

        private void LevelUpACharacter(Character character)
        {
            character.LevelUp();
            Console.WriteLine($"{character.Name} is now a Level: {character.Level} Character");
        }

        private void DisplayAllCharacterSheets()
        {
            Console.WriteLine("All Characters in the character sheet.......................");
            foreach (Character c in _characterList)
            {
                Console.WriteLine($"{c}\n");
            }
            Console.WriteLine("End.........................................................");
        }

        public void RunMenu()
        {
            
        }
    }
}