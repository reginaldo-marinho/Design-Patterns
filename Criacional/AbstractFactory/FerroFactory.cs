public class FerroFactory: AbstractFactory
{
    public IMesa CriarMesa(){
        return new MesaFerro();
    }
    public ICadeira CriarCadeira(){
        return new CadeiraFerro();
    }
}