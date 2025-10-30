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

        public string Name{get{return _name}; set{_name = value}};
    }
}