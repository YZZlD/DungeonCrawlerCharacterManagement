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
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter class: ");
            string charClass = Console.ReadLine();
            Console.Write("Enter Total Attribute Points: ");
            int attributePoints = int.Parse(Console.ReadLine());

            _characterList.Add(new Character(name, charClass, attributePoints));
        }

        private void AssignSkillToACharacter(Character character)
        {
            

            Console.WriteLine($"\nTotal Attribute Points for this character: {character.AvailableAttributePoints}");
            Console.WriteLine($"Available skills:");
            foreach (Skill s in _skills)
            {
                Console.WriteLine($"{_skills.IndexOf(s) + 1}. {s}");
            }

            Console.Write("Select a skill to assign: ");
            int skillSelection = int.Parse(Console.ReadLine());
            Skill skill = _skills[skillSelection - 1];

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
            while(true)
            {
                Console.WriteLine("Main Menu:\n1. Create a character\n2. Assign skills\n3. Level up a character\n4. Display all character sheets\n5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                string name;
                switch(choice)
                {
                    case "1":
                        CreateCharacter();
                        break;
                    case "2":
                        Console.Write("Enter character name: ");
                        name = Console.ReadLine();
                        AssignSkillToACharacter(DCCMHelperFunctions.GetObjectByNamePropertyFromEnumerable(_characterList, name));
                        break;
                    case "3":
                     Console.Write("Enter character name: ");
                        name = Console.ReadLine();

                        LevelUpACharacter(DCCMHelperFunctions.GetObjectByNamePropertyFromEnumerable(_characterList, name));
                        break;
                    case "4":
                        DisplayAllCharacterSheets();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;
                }
            }
        }
    }
}