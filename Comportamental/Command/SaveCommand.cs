class SaveCommand : ICommand
{
    private BaseCommandAPiReceiver _receiver;

    public SaveCommand(BaseCommandAPiReceiver receiver)
    {
        this._receiver = receiver;
    }
    public void Execute()
    {
        this._receiver.Save();
    }
}