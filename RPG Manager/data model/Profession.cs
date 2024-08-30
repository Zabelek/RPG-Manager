using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Manager
{
    public class Profession
    {
        public string name, statsType;

        public Profession(string name, string statsType)
        {
            this.name = name;
            this.statsType = statsType;
        }
    }
}
