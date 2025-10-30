using System;

namespace DungeonCrawlerCharacterManagement
{
    class Character
    {
        private string _name;
        private string _class;
        private int _level;
        private int _hitPoints;
        private int _availableAttributePoints;
        private List<Skill> _skills;

        public string Name { get { return _name; } private set { _name = value; } }
        public string Class { get { return _class; } private set { _class = value; } }
        public int Level { get { return _level; } set { _level = value; } }
        public int HitPoints { get { return _hitPoints; } private set { _hitPoints = value; } }
        public int AvailableAttributePoints { get { return _availableAttributePoints; } private set { _availableAttributePoints = value; } }
        public List<Skill> Skills { get { return _skills; } private init{ _skills = value; } }

        public Character(string name, string characterClass, int attributePoints)
        {
            Name = name;
            Class = characterClass;
            AvailableAttributePoints = attributePoints;
            Level = 1;
            HitPoints = 10 + (AvailableAttributePoints / 2);
            Skills = new List<Skill>();
        }

        public bool LearnSkill(Skill skill)
        {
            if (AvailableAttributePoints < skill.RequiredAttributePoints) return false;

            Skills.Add(skill);
            AvailableAttributePoints -= skill.RequiredAttributePoints;
            return true;
        }

        public void LevelUp()
        {
            Level += 1;
            HitPoints += 5;
            AvailableAttributePoints += 10;
        }

        public override string ToString()
        {
            return $@"Name: {Name}, Class: {Class}, Level: {Level}, HitPoints: {HitPoints}, Available Attribute Points: {AvailableAttributePoints}
Skills:
{(Skills.Count!=0?String.Join(Environment.NewLine, Skills):"There are no skills assigned yet...!")}";
        }
        
    }
}