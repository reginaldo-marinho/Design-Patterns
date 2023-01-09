class DeleteCommand : ICommand
{
    private BaseCommandAPiReceiver _receiver;

    public DeleteCommand(BaseCommandAPiReceiver receiver)
    {
        this._receiver = receiver;
    }

    public void Execute()
    {
        this._receiver.Delete();
    }
}