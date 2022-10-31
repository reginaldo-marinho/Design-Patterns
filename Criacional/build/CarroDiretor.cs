public class CarroDiretor 
{
    public  void CriarCarroPopular(IBuilder builder){
        builder.Reset();
        builder.SetRoda();
        builder.SetSom();
        builder.SetPortas(2);
    }
    public  void CriarCarroLuxo(IBuilder builder){
        builder.Reset();
        builder.SetRoda();
        builder.SetSom();
        builder.SetPortas(4);

    }
}