public class MadeiraFactory : AbstractFactory
{
    public IMesa CriarMesa(){
        return new MesaMadeira();
    }
    public ICadeira CriarCadeira(){
        return new CadeiraMadeira();
    }
}