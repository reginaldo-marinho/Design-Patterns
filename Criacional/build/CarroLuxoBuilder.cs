public class CarroLuxoBuilder : IBuilder
{
    private CarroLuxo Carro = null;
    public void Reset(){
        this.Carro = new CarroLuxo();
    }
    public void SetRoda(){
        Console.WriteLine("criando roda de liga leve");
    }
    public void SetSom(){
        Console.WriteLine("criando som de alta qualidade Pionner");
    }
    
    public void SetPortas(int quantidade){
        Console.WriteLine($"Adicionando {quantidade} portas ao Carro");
    }

    public CarroLuxo GetResult(){
        return this.Carro;
    }
}