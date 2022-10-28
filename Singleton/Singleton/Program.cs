using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Da mesma forma que no mundo  real, em um jogo de futebol existe somente uma bola
                Para que isso sejá representado na OO, podemos uitilizar o padrão Singleton que permite a criação de uma unica instância
            */
            BolaSingleton bola = BolaSingleton.GetBolaSingleton();  // cria a instancia de uma nova bola
            BolaSingleton bola1 = BolaSingleton.GetBolaSingleton(); // utiliza a bola em jogo
            BolaSingleton bola2 = BolaSingleton.GetBolaSingleton(); // utiliza a bola em jogo
            BolaSingleton bola3 = BolaSingleton.GetBolaSingleton(); // utiliza a bola em jogo
            BolaSingleton bola4 = BolaSingleton.GetBolaSingleton(); // utiliza a bola em jogo
            BolaSingleton bola5 = BolaSingleton.GetBolaSingleton(); // utiliza a bola em jogo
            BolaSingleton bola6 = BolaSingleton.GetBolaSingleton(); // utiliza a bola em jogo
            Console.Read();
        }
    }
}
