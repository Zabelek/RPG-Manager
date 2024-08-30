using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager
{
    public class ItemType
    {
        public String name, description, imagePath;
        public ItemCategory category;

        public ItemType(string name, string description, ItemCategory category, string imagePath)
        {
            this.name = name;
            this.description = description;
            this.imagePath = imagePath;
            this.category = category;
        }
    }
}
