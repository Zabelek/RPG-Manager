using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager
{
    static class Session
    {
        public static List<Hero> registeredHeroes { get; set; }
        public static List<ItemType> registeredItems { get; set; }
        public static List<Ability> registeredAbilities { get; set; }
        public static List<ItemCategory> registeredItemCategories { get; set; }
        public static List<Profession> registeredProfessions { get; set; }
        public static List<GuildFurniture> guildFurnitures { get; set; }
        public static int guildMoney { get; set; }

        public static void initiate()
        {
            registeredHeroes = new List<Hero>();
            registeredItems = new List<ItemType>();
            registeredAbilities = new List<Ability>();
            registeredItemCategories = new List<ItemCategory>();
            registeredProfessions = new List<Profession>();
            guildFurnitures = new List<GuildFurniture>();
            guildMoney = 0;
            registeredItemCategories.Add(new ItemCategory("Hełm", "assets\\Item Categories\\helm.png"));
            registeredItemCategories.Add(new ItemCategory("Zbroja", "assets\\Item Categories\\zbroja.png"));
            registeredItemCategories.Add(new ItemCategory("Zwój", "assets\\Item Categories\\zwoj.png"));
            registeredItemCategories.Add(new ItemCategory("Biżuteria", "assets\\Item Categories\\bizuteria.png"));
            registeredItemCategories.Add(new ItemCategory("Buty", "assets\\Item Categories\\buty.png"));
            registeredItemCategories.Add(new ItemCategory("Książka", "assets\\Item Categories\\ksiazka.png"));
            registeredItemCategories.Add(new ItemCategory("Laska", "assets\\Item Categories\\laska.png"));
            registeredItemCategories.Add(new ItemCategory("Łuk", "assets\\Item Categories\\luk.png"));
            registeredItemCategories.Add(new ItemCategory("Materiał", "assets\\Item Categories\\material.png"));
            registeredItemCategories.Add(new ItemCategory("Miecz", "assets\\Item Categories\\miecz.png"));
            registeredItemCategories.Add(new ItemCategory("Mikstura", "assets\\Item Categories\\mikstura.png"));
            registeredItemCategories.Add(new ItemCategory("Pozostałe", "assets\\Item Categories\\pozostale.png"));
            registeredItemCategories.Add(new ItemCategory("Rękawice", "assets\\Item Categories\\rekawice.png"));
            registeredItemCategories.Add(new ItemCategory("Roślina", "assets\\Item Categories\\roslina.png"));
            registeredItemCategories.Add(new ItemCategory("Spodnie", "assets\\Item Categories\\spodnie.png"));
            registeredItemCategories.Add(new ItemCategory("Tarcza", "assets\\Item Categories\\tarcza.png"));
            registeredItemCategories.Add(new ItemCategory("Włócznia", "assets\\Item Categories\\wlocznia.png"));
            registeredItemCategories.Add(new ItemCategory("Złoto", "assets\\Item Categories\\zloto.png"));
            registeredItemCategories.Add(new ItemCategory("Jedzenie", "assets\\Item Categories\\jedzenie.png"));
            registeredItemCategories.Add(new ItemCategory("Wierzchowiec", "assets\\Item Categories\\wierzchowiec.png"));
            FileHandler.setupItems();
            FileHandler.setupAbilities();
            FileHandler.setupProfessions();
            FileHandler.setupHeroes();
            FileHandler.setupGuild();
        }
    }
}
