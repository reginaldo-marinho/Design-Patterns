public class CarroPopularBuilder : IBuilder
{
    private CarroPopular _CarroPopular = null;
    public void Reset(){
        _CarroPopular = new  CarroPopular();
    }
    public void SetRoda(){
        Console.WriteLine("Criando Roda com Calotas");
    }
    public void SetSom(){
        Console.WriteLine("Criando som ambiente philips");
    }
    public void SetPortas(int quantidade){
        Console.WriteLine($"Adicionando {quantidade} portas ao Carro");
    }
    
    public CarroPopular GetResult(){
        return this._CarroPopular;
    }

}