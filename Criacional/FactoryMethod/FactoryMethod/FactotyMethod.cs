using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_
{
    class FactotyMethod
    {
        public IPersonagem EscolhaPersonagem(string escolha)
        {
            switch (escolha)
            {
                case "Kio":
                    return new Kyo();
                case "Rio":
                    return new Rio();
                case "Blue Mary":
                    return new BlueMary();
                default: return null; 
            }
        }
    }
}
