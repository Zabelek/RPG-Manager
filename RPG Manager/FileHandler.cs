using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RPG_Manager
{
    public static class FileHandler
    {
        public static void setupHeroes()
        {
            String[] heroFiles = Directory.GetFiles(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Heroes"), "*.txt", SearchOption.AllDirectories);
            for (int i = 0; i < heroFiles.Length; i++)
            {
                using (StreamReader sr = new StreamReader(heroFiles[i]))
                {
                    Hero hero = new Hero();
                    String[] tempDir = heroFiles[i].Split("\\");
                    hero.filePath = tempDir.Last();
                    hero.name = sr.ReadLine();
                    hero.race = sr.ReadLine();
                    hero.age = sr.ReadLine();
                    hero.weight = sr.ReadLine();
                    hero.strength = Int32.Parse(sr.ReadLine());
                    hero.dextrity = Int32.Parse(sr.ReadLine());
                    hero.endurance = Int32.Parse(sr.ReadLine());
                    hero.charisma = Int32.Parse(sr.ReadLine());
                    hero.intelligence = Int32.Parse(sr.ReadLine());
                    hero.magic = Int32.Parse(sr.ReadLine());
                    hero.perception = Int32.Parse(sr.ReadLine());
                    hero.currentHP = Int32.Parse(sr.ReadLine());
                    hero.maxHP = Int32.Parse(sr.ReadLine());
                    hero.notes = "";
                    hero.gold = 0;
                    if (String.Compare(sr.ReadLine(), "Umiejętności:") == 0)
                    {
                        //import umiejętności
                        string temp = sr.ReadLine();
                        while (String.Compare(temp, "Talenty:") != 0)
                        {
                            hero.professions.Add(new LearnedProfession(Session.registeredProfessions.Find(x => String.Compare(x.name, temp) == 0), Int32.Parse(sr.ReadLine())));
                            temp = sr.ReadLine();
                        }
                        //import talentów
                        temp = sr.ReadLine();
                        while (String.Compare(temp, "Plecak:") != 0)
                        {
                            hero.abilities.Add(Session.registeredAbilities.Find(x => String.Compare(x.name, temp) == 0));
                            temp = sr.ReadLine();
                        }
                        //import plecaka
                        hero.gold = Int32.Parse(sr.ReadLine());
                        temp = sr.ReadLine();
                        while (String.Compare(temp, "Heteronomicon:") != 0)
                        {
                            hero.backpack.Add(new Item(Session.registeredItems.Find(x => String.Compare(x.name, temp) == 0), 1, 1, false, false));

                            temp = sr.ReadLine();
                        }
                        temp = sr.ReadLine();
                        //import heteronomiconu
                        while (String.Compare(temp, "Notatki:") != 0)
                        {
                            hero.heteronomicon.Add(temp);
                            temp = sr.ReadLine();
                        }
                        temp = sr.ReadLine();
                        while (temp != null)
                        {
                            hero.notes += temp + "\n";
                            temp = sr.ReadLine();
                        }
                    }
                    String[] subs = heroFiles[i].Split(".txt");
                    hero.imagePath = subs[0] + ".png";
                    Session.registeredHeroes.Add(hero);
                }
            }
        }
        public static void setupAbilities()
        {
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Abilities.txt")))
            {
                String temp = sr.ReadLine();
                while (temp != null)
                {
                    Session.registeredAbilities.Add(new Ability(temp, sr.ReadLine()));
                    temp = sr.ReadLine();
                }
            }
            foreach (Ability ability in Session.registeredAbilities) { Debug.WriteLine(ability.name); }
        }
        public static void setupProfessions()
        {
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Professions.txt")))
            {
                String temp = sr.ReadLine();
                while (temp != null)
                {
                    Session.registeredProfessions.Add(new Profession(temp, sr.ReadLine()));
                    temp = sr.ReadLine();
                }
            }
        }
        public static void setupItems()
        {
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Items.txt")))
            {
                String temp = sr.ReadLine();
                while (temp != null)
                {
                    String temp1 = sr.ReadLine();
                    String temp2 = sr.ReadLine();
                    String temp3 = sr.ReadLine();
                    Session.registeredItems.Add(new ItemType(temp, temp1,
                        Session.registeredItemCategories.Find(x => String.Compare(x.name, temp2) == 0), temp3));
                    temp = sr.ReadLine();
                }
            }
            Debug.WriteLine(Session.registeredItems.Count());
        }
        public static void setupGuild()
        {
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Gildia.txt")))
            {
                Session.guildMoney = Int32.Parse(sr.ReadLine());
                String temp = sr.ReadLine();
                {
                    while (temp != null)
                    {
                        Session.guildFurnitures.Add(new GuildFurniture(temp, sr.ReadLine(), sr.ReadLine()));
                        temp = sr.ReadLine();
                    }
                }
            }
        }
        public static void saveAbilities()
        {
            using (StreamWriter wr = new StreamWriter(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Abilities.txt")))
            {
                foreach(Ability ability in Session.registeredAbilities)
                {
                    wr.WriteLine(ability.name);
                    wr.WriteLine(ability.description);
                }
                wr.Close();
            }
        }
        public static void saveProfessions()
        {
            using (StreamWriter wr = new StreamWriter(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Professions.txt")))
            {
                foreach (Profession prof in Session.registeredProfessions)
                {
                    wr.WriteLine(prof.name);
                    wr.WriteLine(prof.statsType);
                }
                wr.Close();
            }
        }
        public static void saveItems()
        {
            using (StreamWriter wr = new StreamWriter(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Items.txt")))
            {
                foreach (ItemType item in Session.registeredItems)
                {
                    wr.WriteLine(item.name);
                    wr.WriteLine(item.description);
                    wr.WriteLine(item.category.name);
                    wr.WriteLine(item.imagePath);
                }
                wr.Close();
            }
        }
        public static void saveHeroes()
        {
            foreach (Hero hero in Session.registeredHeroes)
            {
                if(hero.filePath != null)
                {
                    String dir = "assets\\Heroes\\"+hero.filePath;
                    using (StreamWriter wr = new StreamWriter(System.IO.Path.Combine(Directory.GetCurrentDirectory(), dir)))
                    {
                        wr.WriteLine(hero.name);
                        wr.WriteLine(hero.race);
                        wr.WriteLine(hero.age);
                        wr.WriteLine(hero.weight);
                        wr.WriteLine(hero.strength);
                        wr.WriteLine(hero.dextrity);
                        wr.WriteLine(hero.endurance);
                        wr.WriteLine(hero.charisma);
                        wr.WriteLine(hero.intelligence);
                        wr.WriteLine(hero.magic);
                        wr.WriteLine(hero.perception);
                        wr.WriteLine(hero.currentHP);
                        wr.WriteLine(hero.maxHP);
                        wr.WriteLine("Umiejętności:");
                        foreach(LearnedProfession prof in hero.professions)
                        {
                            wr.WriteLine(prof.profession.name);
                            wr.WriteLine(prof.getLevel());
                        }
                        wr.WriteLine("Talenty:");
                        foreach(Ability ability in hero.abilities)
                        {
                            wr.WriteLine(ability.name);
                        }
                        wr.WriteLine("Plecak:");
                        wr.WriteLine(hero.gold);
                        foreach(Item item in hero.backpack)
                        {
                            wr.WriteLine(item.type.name);
                        }
                        wr.WriteLine("Heteronomicon:");
                        foreach(String str in hero.heteronomicon)
                        {
                            wr.WriteLine(str);
                        }
                        wr.WriteLine("Notatki:");
                        wr.Write(hero.notes);
                        wr.Close();
                    }
                }
                else
                {
                    //zaimplementować dla nowoutworzonych bohaterów
                }
            }
        }
        public static void saveGuild()
        {
            using (StreamWriter wr = new StreamWriter(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Gildia.txt")))
            {
                wr.WriteLine(Session.guildMoney);
                foreach (GuildFurniture furniture in Session.guildFurnitures)
                {
                    wr.WriteLine(furniture.name);
                    wr.WriteLine(furniture.description);
                    wr.WriteLine(furniture.imagePath);
                }
                wr.Close();
            }
        }
    }
}
