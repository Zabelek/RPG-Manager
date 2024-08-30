using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager.data_model
{
    public class Item
    {
        public ItemType type;
        public int x, y;
        public bool isEquipped, isDamaged;
        public Item(ItemType type, int x, int y, bool isEquipped, bool isDamaged)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.isEquipped = isEquipped;
            this.isDamaged = isDamaged;
        }
        public void move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
