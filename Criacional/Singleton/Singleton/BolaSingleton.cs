using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /* Padrão: Criacional
     * Nome: Singleton
     * Objetivo: Criar uma unica instancia que pode ser compartilhada outros objeto
     * Beneficio: Cria um unico objeto na memória 
     */
    sealed class  BolaSingleton
    {
        private static BolaSingleton Bola = null;
        public static BolaSingleton GetBolaSingleton()
        {
            if (Bola == null)
            {
                Bola = new BolaSingleton();
                Console.WriteLine("Bola em Jogo");
            }
            Console.WriteLine("Obtendo bola");
            return Bola;
        }

        
    }
}
