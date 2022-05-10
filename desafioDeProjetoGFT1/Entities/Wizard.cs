using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeProjetoGFT1.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string heroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;

        }

        public override string Attack()
        {
            return this.Name + " Lançou uma magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + "Lançou uma super magia com bonus de ataque de " + Bonus;
            }else
            {
                return this.Name + "Lançou uma magia com bonus de " + Bonus;
            }
            
        }
    }
}
