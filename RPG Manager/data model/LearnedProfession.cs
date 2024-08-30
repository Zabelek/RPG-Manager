using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager.data_model
{
    public class LearnedProfession
    {
        public Profession profession;
        private int level;

        public LearnedProfession(Profession profession, int level)
        {
            this.profession = profession;
            this.level = level;
        }
        public int getLevel() { return level; }
        public void setLevel(int level) 
        {
            if (level > 0 && level < 11)
                this.level = level;
            else if (level > 11)
                this.level = 10;
            else
                this.level = 1;
        }
    }
}
