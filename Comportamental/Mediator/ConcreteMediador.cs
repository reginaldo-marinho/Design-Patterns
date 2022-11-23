/*
    ConcreteMediador é que recebe e distribui as mensagens 
*/
public class ConcreteMediador: IMediator
{
    private Colleague1? _colleague1;
    private Colleague2? _colleague2;
    private Colleague3? _colleague3; 
    public Colleague1 colleague1 
    { 
        set {this._colleague1 = value;} 
    }
    public Colleague2 colleague2 
    { 
        set {this._colleague2 = value;} 
    }
    public Colleague3 colleague3 
    { 
        set {this._colleague3 = value;} 
    }
    
    /*
        Permite que cada ações de conjunto de objetos variem idependente uma das outras 
    */
    public void Notify(string msg, ColleagueBase colleague)
    {
        if (colleague == _colleague1)
        {
            this._colleague1?.Popup();
            this._colleague2?.Popup();
            this._colleague3?.Popup();
        }
        if (colleague == _colleague2)
        {
            this._colleague2?.Popup();
            this._colleague3?.Popup();
        }
        if (colleague == _colleague3)
        {
            this._colleague3?.Popup();
        }
    }
}