public class Endereco 
{
    public Endereco(string logradouro, int numero){
        this.Logradouro = logradouro;
        this.Numero = numero;
    }
    public string Logradouro {get;set;} = "";
    public int Numero {get;set;}
    
}
public class Pessoa 
{
    public string Nome {get;set;} = "";
    public string Sobrenome {get;set;} = "";
    public int Idade {get;set;}
    public  Endereco Endereco;

    public Pessoa ShallowCopy(){
        return (Pessoa) this.MemberwiseClone();
    }
}