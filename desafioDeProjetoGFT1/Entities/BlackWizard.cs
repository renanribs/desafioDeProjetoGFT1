using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeProjetoGFT1.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string heroType, int HP, int MP)
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
    }
}
