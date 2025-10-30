using System;

namespace DungeonCrawlerCharacterManagement
{
    class Skill
    {
        private string _name;
        private string _description;
        private string _attribute;
        private int _requiredAttributePoints;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Attribute { get { return _attribute; } set { _attribute = value; } }
        public int RequiredAttributePoints { get { return _requiredAttributePoints; } set { _requiredAttributePoints = value; } }

        public Skill()
        {

        }

        public override string ToString()
        {
            return $"{Name} - {Description} - {Attribute} - Point Requirement: {RequiredAttributePoints}";
        }
    }
}