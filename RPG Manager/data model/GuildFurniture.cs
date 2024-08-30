using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager.data_model
{
    public class GuildFurniture
    {
        public String name, description, imagePath;

        public GuildFurniture(String name, String description, String imagePath)
        {
            this.name = name;
            this.description = description;
            this.imagePath = imagePath;
        }
    }
}
