using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    internal class Character
    {
        public Character(String name)
        {
            this.name = name;
        }

        private String name;
        private Vocation vocation;
     
        public String getName()
            {
                return name;
            }
        
        public void atacar()
        {

        }

        public void curar()
        {

        }

      

    }
}
