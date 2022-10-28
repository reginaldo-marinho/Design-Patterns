using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_
{
    class Program
    {
        /*
         Designer: Factory Methodo | Método de Fabrica, fornece uma classe para criar objetos em uma super classe, mas permite que subclasse alterem o tipo dos objetos que serão criados
         Objetivo: Cria instancias de forma dinamica
         */
        static void Main(string[] args)
        {
            FactotyMethod factoty = new FactotyMethod();
            Console.WriteLine("Kio | Rio | Blue Mary");
            Console.WriteLine();
            Console.WriteLine("Escolha um personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = factoty.EscolhaPersonagem(escolha);
            Console.WriteLine($"Você escolheu o personagem: ");
            personagem.Escolhido();
            Console.ReadKey();
        }
    }
}
