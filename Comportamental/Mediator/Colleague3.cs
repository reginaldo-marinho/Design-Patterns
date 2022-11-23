public class Colleague3 : ColleagueBase
{
    public Colleague3(IMediator mediator) : base(mediator)
    {
        
    }
    public void SendMensage()
    {
        this._mediator.Notify("",this);
    }
    public void Popup()
    {
        Console.WriteLine("Popup Defaut");
    }
}