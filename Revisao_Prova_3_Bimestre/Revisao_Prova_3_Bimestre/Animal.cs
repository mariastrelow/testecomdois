using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Prova_3_Bimestre
{
    internal class Animal
    {
        public double Tamanho { get; set; }
        public double Peso { get; set; }

        public Animal()
        {

        }
        public Animal(double tamanho, double peso)
        {
            this.Tamanho = tamanho;
            this.Peso = peso;
        }
        public double Imc()
        {
           return Peso / (Tamanho * Tamanho);
        }
        public virtual void Barulho()
        {
            Console.WriteLine("Barulho!");
        }
    }
}
