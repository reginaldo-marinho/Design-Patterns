class AlterCommand : ICommand
{
    private BaseCommandAPiReceiver _receiver;

    public AlterCommand(BaseCommandAPiReceiver receiver)
    {
        this._receiver = receiver;
    }

    public void Execute()
    {
        this._receiver.Alter();
    }
}