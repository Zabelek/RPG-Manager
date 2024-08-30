using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager.data_model
{
    public class ItemCategory
    {
        public String name { get; set; }
        public String imagePath { get; set; }

        public ItemCategory(string name, string imagePath)
        {
            this.name = name;
            this.imagePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), imagePath);
        }
    }
}
