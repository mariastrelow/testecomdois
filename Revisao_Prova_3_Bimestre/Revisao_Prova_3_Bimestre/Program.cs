using System;
using Revisao_Prova_3_Bimestre;
class Program
{
    static void Main(string[] args)
    {
        List<Animal> animal = new List<Animal>();
        List<Cachorro> cachorro = new List<Cachorro>();
        Console.WriteLine("Informações");
        
        Animal an = new Animal();
        an.Tamanho = 5.6;
        an.Peso = 3.9;
        animal.Add(an);

        Cachorro c = new Cachorro();
        c.Raca = "Labrador";
        c.Tamanho = 4.3;
        c.Peso = 9.0;

        Cachorro c2 = new Cachorro();
        c2.Raca = "Chiuaua";
        c2.Tamanho = 1.5;
        c2.Peso = 3.0;
       
        Cachorro c3 = new Cachorro();
        c3.Raca = "Pinscher";
        c3.Tamanho = 2.3;
        c3.Peso = 5.0;
        cachorro.Add(c);
        cachorro.Add(c2);
        cachorro.Add(c3);

        cachorro = cachorro.OrderBy(c => c.Tamanho).ToList();
        List<Cachorro> cachorroComPesoGrande = cachorro.Where(x => x.Peso >= 2).ToList();
        cachorroComPesoGrande.Add(c);
        cachorroComPesoGrande.Add(c2);
        cachorroComPesoGrande.Add(c3);
        
        
        foreach(Animal a in animal)
        {
            Console.WriteLine($"Animal: \nTamanho: {a.Tamanho}\nPeso: {a.Peso}\n IMC: {a.Imc()}");
        }
        foreach(Cachorro ac in cachorro)
        {
            Console.WriteLine($"\n\nCachorro: \nRaca: {ac.Raca}\nTamanho: {ac.Tamanho}\nPeso: {ac.Peso}\nIMC: {ac.Imc()}");
        }
        foreach(Cachorro peso in cachorroComPesoGrande)
        {
            Console.WriteLine(peso.Peso);
        }
    }
}
//\nBarulho: {c.Barulho()}