using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Prova_3_Bimestre
{
    internal class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro()
        {

        }
        public Cachorro(string raca, double tamanho, double peso) : base (tamanho, peso)
        {
            Raca = raca;
        }

        public override void Barulho()
        {
            Console.WriteLine("Au Au!"); ;
        }

    }
}
