public class Colleague2 : ColleagueBase
{
    public Colleague2(IMediator mediator) : base(mediator)
    {
    }
    public void SendMensage()
    {
        this._mediator.Notify("",this);
    }
    public void Popup()
    {
        Console.WriteLine("Popup Custom");
    }
}