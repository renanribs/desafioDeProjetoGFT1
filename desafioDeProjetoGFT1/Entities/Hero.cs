using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeProjetoGFT1.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string heroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;


        }

        public Hero ()
        {

        }

        public string Name;
        public int Level;
        public string heroType;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.heroType + this.HP + " " + this.MP;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }

    }

}
