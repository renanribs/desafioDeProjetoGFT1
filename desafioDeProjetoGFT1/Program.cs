using desafioDeProjetoGFT1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeProjetoGFT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 23, "Knight", 100, 50);
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard", 100, 50);
            BlackWizard blackWizard = new BlackWizard("Mago", 42, "Black Wizard", 100, 80);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(blackWizard.Attack());
            

            Console.ReadKey();
        }
    }
}
