public class Colleague1 : ColleagueBase
{
    public Colleague1(IMediator mediator) : base(mediator)
    {
    }
    public void SendMensage()
    {
        this._mediator.Notify("",this);
    }

    public void Popup()
    {
        Console.WriteLine("Pop Full Screnn");
    }
}