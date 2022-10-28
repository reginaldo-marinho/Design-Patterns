public class Cliente
{
    private AbstractFactory _abstractFactory;
    public Cliente(AbstractFactory abstractFactory){
        this._abstractFactory = abstractFactory;
    }
    public void  SomeOperation(){
        ICadeira cadeira = _abstractFactory.CriarCadeira();
        cadeira.CriarCadeira();
        IMesa mesa = _abstractFactory.CriarMesa();
        mesa.CriarMesa();
    }
}