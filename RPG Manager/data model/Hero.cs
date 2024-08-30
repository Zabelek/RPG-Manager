using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager
{
    public class Hero
    {
        public String name { get; set; }
        public String race, age, weight;
        public int strength, dextrity, endurance, charisma, intelligence, magic, perception;
        public List<LearnedProfession> professions;
        public List<Ability> abilities;
        public List<Item> backpack;
        public List<String> heteronomicon;
        public String imagePath;
        public String notes;
        public String filePath;
        public int maxHP, currentHP;
        public int gold;

        public Hero()
        {
            this.professions = new List<LearnedProfession>();
            this.abilities = new List<Ability>();
            this.backpack = new List<Item>();
            this.heteronomicon = new List<String>();

        }
        public Hero(string name, string race, string age, string weight, int strength, int dextrity, int endurance, int charisma, int intelligence, 
            int magic, int perception, List<LearnedProfession> professions, List<Ability> abilities, List<Item> backpack, List<String> heteronomicon, 
            string imagePath, string notes)
        {
            this.name = name;
            this.race = race;
            this.age = age;
            this.weight = weight;
            this.strength = strength;
            this.dextrity = dextrity;
            this.endurance = endurance;
            this.charisma = charisma;
            this.intelligence = intelligence;
            this.magic = magic;
            this.perception = perception;
            this.professions = professions;
            this.abilities = abilities;
            this.backpack = backpack;
            this.heteronomicon = heteronomicon;
            this.imagePath = imagePath;
            this.notes = notes;
            Session.registeredHeroes.Add(this);
        }
        public void setCurrentHp(int hp)
        {
            if(hp<0) currentHP=0;
            else if(hp>maxHP) currentHP = maxHP;
            else currentHP = hp;
        }
    }
}
