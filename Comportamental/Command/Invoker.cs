public class Invoker
{
    private ICommand Command {get;set;}
    private ICommand SaveCommand {get;set;}
    private ICommand AlterCommand {get;set;}
    private ICommand DeleteCommand {get;set;}
    public Invoker(ICommand saveCommand,ICommand alterCommand,ICommand deleteCommand)
    {
        this.SaveCommand = saveCommand;
        this.DeleteCommand = alterCommand;
        this.AlterCommand = deleteCommand;
    }
    public Invoker(ICommand command){
        this.Command = command;
    }
    public void ExecCommand(){
        if (this.Command is SaveCommand){
            this.Save();
        }
        if (this.Command is AlterCommand){
            this.Alter();
        }
        if (this.Command is DeleteCommand){
            this.Delete();
        }
    }
    private void Save(){
        this.Command.Execute();
    }
    private void Alter(){
        this.Command.Execute();
    }
    private void Delete(){
        this.Command.Execute();
    }

}